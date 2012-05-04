using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace CoreView
{
	public static class Configuration
	{
		// Further options can be added here as properties
		// The options will be automatically added to configuration files
		// To prevent an option from being stored, write it as a field

		// Booleans to set of certain error messages have been displayed already
		public static bool DatabaseErrorDisplayed = false;
		public static bool FileReadErrorDisplayed = false;
		public static bool PermissionErrorDisplayed = false;
		public static bool ReadErrorDisplayed = false;

		// Load WMI at the start or when tabs are invoked
		public static bool LoadWMIAtStart { get; set; }
		// Load only hardware at start
		public static bool LoadHardwareAtStart { get; set; }

		// Log viewing preferences
		public static bool OnlyErrorLogs { get; set; }
		public static uint LogAgeMax { get; set; }

		// Show splash screen or not
		public static bool ShowSplash { get; set; }

		/* The weightings dictionary
		 * Stores in the form
		 *	Class
		 *	{
		 *		Attribute : Value
		 *		Attribute : Value
		 *	}
		 *	Class ...
		*/
		public static Dictionary<string, DictionaryWithDefault<string, double>> Weightings { get; set; }

		// Field to store complaints and whether they are enabled or not
		// The names of the complaints here must be the same as the checkbox names
		public static Dictionary<string, bool> Complaints = new Dictionary<string, bool>
        {
            {"ComplaintBSOD", false},
            {"ComplaintDeviceIssue", false},
            {"ComplaintDisplayIssue", false},
            {"ComplaintInputIssue", false},
            {"ComplaintLockouts", false},
            {"ComplaintProgramIssue", false},
            {"ComplaintScreenLag", false},
            {"ComplaintSlowBoot", false},
            {"ComplaintSluggish", false},
            {"ComplaintSoundIssue", false}
        };

		// Function to retrieve all configuration options from an XML document and put the values into this class
		public static void GetConfig()
		{
			try
			{
				// Test whether config exists or not
				if (!File.Exists("config.xml"))
				{
					// If the config doesn't exist, write the defaults to a new file and continue
					File.WriteAllText("config.xml", Properties.Resources.config_default);
				}

				// Prepare config file for reading
				XmlDocument configFile = new XmlDocument();
				configFile.Load("config.xml");
				XmlNode node;

				// General configuration read
				PropertyInfo[] configProperties = typeof(Configuration).GetProperties();
				// For each field in the configuration class, retrieve the respective element
				foreach (PropertyInfo configOption in configProperties)
				{
					if (configOption.Name != "Weightings")
					{
						// Select the node
						node = configFile.SelectSingleNode("//configuration/general/option[@name='" + configOption.Name + "']");
						if (node != null)
						{
							// Convert the string to the type of the property
							configOption.SetValue(null, Convert.ChangeType(node.InnerXml, configOption.PropertyType), null);
						}
						else
						{
							// This sort of error would usually be in ErrorDialogue
							// However, I want the program to continue executing when this problem occurs
							if (!FileReadErrorDisplayed)
							{
								MessageBox.Show("There was a problem with reading config.xml. "
									+ "Please check there are no file errors or the file is in use."
									+ Environment.NewLine
									+ "To rebuild the configuration, delete config.xml and re-run CoreView.",
									"Configuration Failure",
									MessageBoxButtons.OK,
									MessageBoxIcon.Error
								);
								FileReadErrorDisplayed = true;
							}
						}
					}
				}


				Weightings = new Dictionary<string, DictionaryWithDefault<string, double>>();
				DictionaryWithDefault<string, double> temp = new DictionaryWithDefault<string, double>(0.3);
				Type classType;
				FieldInfo[] classFields;

				// For each class, create a new weightings dictionary specific to that class
				foreach (string classString in ClassList.DatabaseClasses)
				{
					// Initialise class weight dictionary
					Weightings[classString] = new DictionaryWithDefault<string, double>(0.3);

					// Get the weights for each field in the class
					classType = Type.GetType("CoreView." + classString);
					classFields = classType.GetFields();
					foreach (FieldInfo classField in classFields)
					{
						node = configFile.SelectSingleNode("//configuration/standardweights/" + classString + "/weight[@name='" + classField.Name + "']");
						if (node != null)
						{
							// Add the weight key and weight value to the new dictionary
                            // Use InvariantCulture to prevent the decimal separator bug in different languages.
                            Weightings[classString].Add(classField.Name, Convert.ToDouble(node.InnerXml, CultureInfo.InvariantCulture));
						}
					}
				}

				// For each complaint type, create a new weightings dictionary
				foreach (string complaint in Complaints.Keys)
				{
					// Initialise class weight dictionary
					Weightings[complaint] = new DictionaryWithDefault<string, double>(0.3);

					// Get the weights for each field in the class
					foreach (string classString in ClassList.DatabaseClasses)
					{
						node = configFile.SelectSingleNode("//configuration/standardweights/" + complaint + "/weight[@name='" + classString + "']");
						if (node != null)
						{
							// Add the weight key and weight value to the new dictionary
                            Weightings[complaint].Add(classString, Convert.ToDouble(node.InnerXml, CultureInfo.InvariantCulture));
						}
					}
				}
			}
			catch (Exception e)
			{
				ErrorDialogue errorReporter = new ErrorDialogue(e);
			}
		}

		// Function to get all fields in the Configuration class and output the values to an XML document
		public static void SetConfig()
		{
			try
			{
				// Settings for XML file
				XmlWriterSettings settings = new XmlWriterSettings();
				settings.Indent = true;
				settings.IndentChars = "\t";

				// Create a new file for writing
				// Also overwrites if a file already exists
				XmlWriter configFile = XmlWriter.Create("config.xml", settings);

				// Create file headers
				configFile.WriteStartDocument();
				configFile.WriteStartElement("configuration");

				// Start of general configuration
				configFile.WriteStartElement("general");

				// Add general Configuration, not weights yet.
				PropertyInfo[] configProperties = typeof(Configuration).GetProperties();
				// For each field in the configuration class, add its name and value as an element
				foreach (PropertyInfo configOption in configProperties)
				{
					if (configOption.Name != "Weightings")
					{
						configFile.WriteStartElement("option");
						configFile.WriteAttributeString("name", configOption.Name);
						configFile.WriteString(Convert.ToString(configOption.GetValue(null, null)));
						configFile.WriteEndElement();
					}
				}

				// End of general configuration
				configFile.WriteEndElement();

				// Start of weights configuration
				configFile.WriteStartElement("standardweights");

				// Add weights
				// Get the headings from each hardware/software class
				FieldInfo[] classFields;

				// Loop through a list of all the available classes
				// Universal for-loop to get the fields of every class
				foreach (string classString in ClassList.DatabaseClasses)
				{

					classFields = Type.GetType("CoreView." + classString).GetFields();

					configFile.WriteStartElement(classString);
					foreach (FieldInfo field in classFields)
					{
						/* If no value is currently set, the default value 0.3 will be read
						 * Add weights by in the form <Class><weight name="Property">Weight</weight>...</Class>
						 * example:
						 * <Processor>
						 *      <weight name="Architecture">0.4</weight>
						 *      <weight name="Availability">0.6</weight>
						 * </Processor>
						*/
						configFile.WriteStartElement("weight");
						configFile.WriteAttributeString("name", field.Name);
						configFile.WriteString(Convert.ToString(Weightings[classString][field.Name]));
						configFile.WriteEndElement();
					}
					configFile.WriteEndElement();
				}

				// Loop through complaints
				foreach (string complaint in Complaints.Keys)
				{
					// Initialise class weight dictionary
					Weightings[complaint] = new DictionaryWithDefault<string, double>(0.3);

					configFile.WriteStartElement(complaint);
					foreach (string classString in ClassList.DatabaseClasses)
					{
						configFile.WriteStartElement("weight");
						configFile.WriteAttributeString("name", classString);
						configFile.WriteString(Convert.ToString(Weightings[complaint][classString]));
						configFile.WriteEndElement();
					}
					configFile.WriteEndElement();
				}

				// End of weights configuration
				configFile.WriteEndElement();

				// Finish and save
				configFile.WriteEndElement();
				configFile.WriteEndDocument();
				configFile.Close();
			}
			catch (Exception e)
			{
				ErrorDialogue errorReporter = new ErrorDialogue(e);
			}
		}
	}

    // A class to quickly enable 'default' values in a dictionary.
    // Useful for getting weights if the weight name does not exist.
    // Sourced from: http://stackoverflow.com/questions/2601477/dictionary-returning-a-default-value-if-the-key-does-not-exist
    public class DictionaryWithDefault<TKey, TValue> : Dictionary<TKey, TValue>
    {
        TValue _default;
        public TValue DefaultValue
        {
            get { return _default; }
            set { _default = value; }
        }
        public DictionaryWithDefault() : base() { }
        public DictionaryWithDefault(TValue defaultValue)
            : base()
        {
            _default = defaultValue;
        }
        public new TValue this[TKey key]
        {
            get { return base.ContainsKey(key) ? base[key] : _default; }
            set { base[key] = value; }
        }
    }
}
