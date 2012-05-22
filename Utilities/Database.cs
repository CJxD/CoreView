using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Reflection;

namespace CoreView
{
    public static class Database
    {
        private static SQLiteConnection Connection;

        // Boolean to flag if an abort is requested
        private static bool abortOperation = false;
		public static void AbortRetrieval()
        {
            abortOperation = true;
        }
		public static void ResetAbort()
        {
            abortOperation = false;
        }

        /// <summary>
        /// Prepares the database for first use. Will write a database to disk if none exists.
        /// </summary>
        /// <returns>True if initialisation succeeded, otherwise false.</returns>
        public static bool Initialise()
        {
            try
            {
                if (File.Exists("Heuristics.db"))
                {
                    // Create a new connection to the existing file
                    Connection = new SQLiteConnection("Data Source=Heuristics.db;New=False;Compress=True;");

					// Test an open/close command
					Connection.Open();
					Connection.Close();
                }
                else
                {
                    // Create a new database
                    Connection = new SQLiteConnection("Data Source=Heuristics.db;New=True;Compress=True;");
                    Connection.Open();
                    // Create tables
                    SQLiteCommand command = Connection.CreateCommand();

                    command.CommandText = "CREATE TABLE comments("
                        + "id INTEGER NOT NULL PRIMARY KEY,"
                        + "comments TEXT)";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE processor("
                        + "id INTEGER NOT NULL,"
                        + "instance INTEGER NOT NULL,"
                        + "Architecture TEXT,"
                        + "Availability TEXT,"
                        + "CacheL2 INTEGER,"
                        + "CacheL3 INTEGER,"
                        + "Caption TEXT,"
                        + "Cores INTEGER,"
                        + "CurrentClock INTEGER,"
                        + "ErrorDescription TEXT,"
                        + "Family TEXT,"
                        + "Manufacturer TEXT,"
                        + "Model TEXT,"
                        + "ReferenceClock INTEGER,"
                        + "Revision INTEGER,"
                        + "Socket TEXT,"
                        + "Status TEXT,"
                        + "Stepping TEXT,"
                        + "Temperature INT,"
                        + "ThermalDesignPower INTEGER,"
                        + "Threads INTEGER,"
                        + "Usage INTEGER,"
                        + "FOREIGN KEY(id) REFERENCES computer(id),"
                        + "PRIMARY KEY(id, instance))";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE motherboard("
                        + "id INTEGER NOT NULL,"
                        + "instance INTEGER NOT NULL,"
                        + "Availability TEXT,"
                        + "ErrorDescription TEXT,"
                        + "Manufacturer TEXT,"
                        + "Model TEXT,"
                        + "ProductID TEXT,"
                        + "SerialID TEXT,"
                        + "Status TEXT,"
                        + "Temperature INTEGER,"
                        + "FOREIGN KEY(id) REFERENCES computer(id),"
                        + "PRIMARY KEY(id, instance))";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE bios("
                        + "id INTEGER NOT NULL,"
                        + "instance INTEGER NOT NULL,"
                        + "Info TEXT,"
                        + "SerialID TEXT,"
                        + "Version TEXT,"
                        + "FOREIGN KEY(id) REFERENCES computer(id),"
                        + "PRIMARY KEY(id, instance))";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE memorydevice("
                        + "id INTEGER NOT NULL,"
                        + "instance INTEGER NOT NULL,"
                        + "Availability TEXT,"
                        + "Bank TEXT,"
                        + "Capacity INTEGER,"
                        + "DeviceLocation TEXT,"
                        + "ErrorDescription TEXT,"
                        + "Manufacturer TEXT,"
                        + "Model TEXT,"
                        + "Speed INTEGER,"
                        + "Status TEXT,"
                        + "FOREIGN KEY(id) REFERENCES computer(id),"
                        + "PRIMARY KEY(id, instance))";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE graphicsadapter("
                        + "id INTEGER NOT NULL,"
                        + "instance INTEGER NOT NULL,"
                        + "Architecture TEXT,"
                        + "Availability TEXT,"
                        + "BitsPerPixel INTEGER,"
                        + "CurrentClock INTEGER,"
                        + "CurrentRefresh INTEGER,"
                        + "DriverDate TEXT,"
                        + "DriverVersion TEXT,"
                        + "ErrorDescription TEXT,"
                        + "HorizontalResolution INTEGER,"
                        + "MaxRefresh INTEGER,"
                        + "MemorySize INTEGER,"
                        + "MemoryType TEXT,"
                        + "MinRefresh INTEGER,"
                        + "Name TEXT,"
                        + "Status TEXT,"
                        + "Temperature INTEGER,"
                        + "VerticalResolution INTEGER,"
                        + "FOREIGN KEY(id) REFERENCES computer(id),"
                        + "PRIMARY KEY(id, instance))";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE networkadapter("
                        + "id INTEGER NOT NULL,"
                        + "instance INTEGER NOT NULL,"
                        + "AdapterType TEXT,"
                        + "Availability TEXT,"
                        + "ConnectionStatus TEXT,"
                        + "CurrentSpeed INTEGER,"
                        + "ErrorDescription TEXT,"
                        + "Manufacturer TEXT,"
                        + "MACAddress TEXT,"
                        + "MaxSpeed INTEGER,"
                        + "Name TEXT,"
                        + "PhysicalAdapter INTEGER,"
                        + "Status TEXT,"
                        + "FOREIGN KEY(id) REFERENCES computer(id),"
                        + "PRIMARY KEY(id, instance))";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE harddrive("
                        + "id INTEGER NOT NULL,"
                        + "instance INTEGER NOT NULL,"
                        + "Availability TEXT,"
                        + "Capacity INTEGER,"
                        + "ErrorDescription TEXT,"
                        + "Manufacturer TEXT,"
                        + "Name TEXT,"
                        + "Partitions INTEGER,"
                        + "Status TEXT,"
                        + "Temperature INTEGER,"
                        + "FOREIGN KEY(id) REFERENCES computer(id),"
                        + "PRIMARY KEY(id, instance))";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE opticaldrive("
                        + "id INTEGER NOT NULL,"
                        + "instance INTEGER NOT NULL,"
                        + "Availability TEXT,"
                        + "ErrorDescription TEXT,"
                        + "Manufacturer TEXT,"
                        + "Media Type TEXT,"
                        + "Name TEXT,"
                        + "Status TEXT,"
                        + "TransferRate INTEGER,"
                        + "FOREIGN KEY(id) REFERENCES computer(id),"
                        + "PRIMARY KEY(id, instance))";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE pcicard("
                        + "id INTEGER NOT NULL,"
                        + "instance INTEGER NOT NULL,"
                        + "Manufacturer TEXT,"
                        + "Model TEXT,"
                        + "Slot TEXT,"
                        + "Status TEXT,"
                        + "Tag TEXT,"
                        + "VccVoltageModes TEXT,"
                        + "FOREIGN KEY(id) REFERENCES computer(id),"
                        + "PRIMARY KEY(id, instance))";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE usbdevice("
                        + "id INTEGER NOT NULL,"
                        + "instance INTEGER NOT NULL,"
                        + "Availability TEXT,"
                        + "Description TEXT,"
                        + "ErrorDescription TEXT,"
                        + "Manufacturer TEXT,"
                        + "Name TEXT,"
                        + "Status TEXT,"
                        + "FOREIGN KEY(id) REFERENCES computer(id),"
                        + "PRIMARY KEY(id, instance))";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE driver("
                        + "id INTEGER NOT NULL,"
                        + "instance INTEGER NOT NULL,"
                        + "Date TEXT,"
                        + "Name TEXT,"
                        + "Publisher TEXT,"
                        + "Version TEXT,"
                        + "FOREIGN KEY(id) REFERENCES computer(id),"
                        + "PRIMARY KEY(id, instance))";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE software("
                        + "id INTEGER NOT NULL,"
                        + "instance INTEGER NOT NULL,"
                        + "Date TEXT,"
                        + "Name TEXT,"
                        + "Publisher TEXT,"
                        + "Version TEXT,"
                        + "FOREIGN KEY(id) REFERENCES computer(id),"
                        + "PRIMARY KEY(id, instance))";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE conflict("
                        + "id INTEGER NOT NULL,"
                        + "instance INTEGER NOT NULL,"
                        + "Device1 TEXT,"
                        + "Device2 TEXT,"
                        + "Resource TEXT,"
                        + "FOREIGN KEY(id) REFERENCES computer(id),"
                        + "PRIMARY KEY(id, instance))";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE process("
                        + "id INTEGER NOT NULL,"
                        + "instance INTEGER NOT NULL,"
                        + "CPU INTEGER,"
                        + "ExecutableName TEXT,"
                        + "ImageName TEXT,"
                        + "IO INTEGER,"
                        + "Memory INTEGER,"
                        + "PID INTEGER,"
                        + "FOREIGN KEY(id) REFERENCES computer(id),"
                        + "PRIMARY KEY(id, instance))";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE log("
                        + "id INTEGER NOT NULL,"
                        + "instance INTEGER NOT NULL,"
                        + "Category TEXT,"
                        + "DateTime TEXT,"
                        + "EventID INTEGER,"
                        + "Level TEXT,"
                        + "Message TEXT,"
                        + "Source TEXT,"
                        + "FOREIGN KEY(id) REFERENCES computer(id),"
                        + "PRIMARY KEY(id, instance))";
                    command.ExecuteNonQuery();

                    Connection.Close();
                }
				return true;
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
				return false;
            }
        }

        /// <summary>
        /// Adds a single device instance to the database.
        /// </summary>
        /// <param name="deviceInstance">The object to store into the database.</param>
        /// <param name="className">The name of the class the object belongs to.</param>
        /// <param name="id">The numerical ID of the computer of which the object belongs.</param>
        /// <param name="instance">The numerical ID of the object in its parent class.</param>
        /// <returns>True if the operation was successful, otherwise false.</returns>
        public static bool AddToDB(object deviceInstance, string className, int id, int instance)
        {
            if (deviceInstance != null && Connection != null && !abortOperation)
            {
                try
                {
                    Connection.Open();
                    // If the database has been opened, continue
                    if (Connection.State == ConnectionState.Open)
                    {
                        // Get the properties of the given device class
                        FieldInfo[] classFields = deviceInstance.GetType().GetFields();

                        SQLiteCommand command = Connection.CreateCommand();

                        // Create a SQL statement to add values
                        command.CommandText = "INSERT INTO "
                                + className
                                + " VALUES('"
                                + id + "','"
                                + instance;

                        // Loop through each field in the class to get values
                        foreach (FieldInfo field in classFields)
                        {
                            // If it's SMARTData, don't store it!
                            if (field.FieldType != typeof(SMARTData))
                            {
                                command.CommandText += "','" + field.GetValue(deviceInstance);
                            }
                        }

                        // End the query string and execute it
                        command.CommandText += "')";
                        command.ExecuteNonQuery();

                        // End
                        Connection.Close();
                        return true;
                    }
                    else
                    {
                        Connection.Close();
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Connection.Close();
                    ErrorDialogue errorReporter = new ErrorDialogue(e);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

		/// <summary>
		/// Special function for adding comments to the database
		/// </summary>
		/// <param name="comments">The comments to add.</param>
		/// <param name="id">The ID of the computer for which the comment belong.</param>
        /// <returns>True if the operation was successful, otherwise false.</returns>
		public static bool AddCommentsToDB(string comments, int id)
		{
            if (Connection != null && !abortOperation)
			{
				try
				{
					Connection.Open();
					// If the database has been opened, continue
					if (Connection.State == ConnectionState.Open)
					{
						SQLiteCommand command = Connection.CreateCommand();

						// Create a SQL statement to add values
						command.CommandText = "INSERT INTO comments VALUES('"
								+ id
								+ "','"
								+ comments;
						command.CommandText += "')";
						command.ExecuteNonQuery();

						// End
						Connection.Close();
						return true;
					}
					else
					{
						Connection.Close();
						return false;
					}
				}
				catch (Exception e)
				{
					Connection.Close();
					ErrorDialogue errorReporter = new ErrorDialogue(e);
					return false;
				}
			}
			else
			{
				return false;
			}
		}

        /// <summary>
        /// Deletes an entire computer from the database.
        /// </summary>
        /// <param name="id">The ID of the computer to delete.</param>
        /// <returns>True if the operation was successful, otherwise false.</returns>
		public static bool DeleteFromDB(int id)
		{
            if (Connection != null && !abortOperation)
			{
				try
				{
					Connection.Open();
					// If the database has been opened, continue
					if (Connection.State == ConnectionState.Open)
					{
						SQLiteCommand command = Connection.CreateCommand();

						// Deletes a computer from the all tables in the database prior to updating the information
						foreach (string classString in ClassList.DatabaseClasses)
						{
                            if (abortOperation) break;
							command.CommandText = "DELETE FROM " + classString + " WHERE id='" + id + "'";
							command.ExecuteNonQuery();
						}

                        // Delete from comments
                        command.CommandText = "DELETE FROM comments WHERE id='"
                                + id
                                + "'";
                        command.ExecuteNonQuery();

						// End
						Connection.Close();
						return true;
					}
					else
					{
						Connection.Close();
						return false;
					}
				}
				catch (Exception e)
				{
					Connection.Close();
					ErrorDialogue errorReporter = new ErrorDialogue(e);
					return false;
				}
			}
			else
			{
				return false;
			}
		}

        /// <summary>
        /// Gets all of the ID numbers present in the database.
        /// </summary>
        /// <returns>An array of ID numbers.</returns>
        public static int[] GetIDNumbers()
        {
            // Gets the ID numbers of all known computers
            if (Connection != null && !abortOperation)
            {
                try
                {
                    List<int> idNumbers = new List<int>();
                    SQLiteCommand command = Connection.CreateCommand();
                    SQLiteDataReader data;

                    // Get all IDs from one of the tables. Comments is best as IDs are unique to the rows.
                    Connection.Open();
                    command.CommandText = "SELECT id FROM comments";
                    data = command.ExecuteReader();

                    // For each record
                    while (data.Read())
                    {
                        // Add the id field to the id numbers list
                        idNumbers.Add(Convert.ToInt32(data[0]));
                    }

                    Connection.Close();

                    // Set the list of ids as an array of integers
                    return idNumbers.ToArray();
                }
                catch (Exception e)
                {
                    Connection.Close();
                    ErrorDialogue errorReporter = new ErrorDialogue(e);
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets all of the information about a computer from the database in the form of a PC class.
        /// </summary>
        /// <param name="id">The ID of the computer to retrieve from the database.</param>
        /// <returns>A PC class containing all related information.</returns>
        public static PC GetComputer(int id)
        {
            if (Connection != null && !abortOperation)
            {
                PC fetched = new PC();

                SQLiteCommand command = Connection.CreateCommand();
                SQLiteDataReader data;
                FieldInfo field, classField;
                DataTable table;

                // Loop through each class and get each row of the table for the specified index
                foreach (string classString in ClassList.DatabaseClasses)
                {
                    if (abortOperation) break;
                    // Open database connection
                    Connection.Open();

                    // If the database has been opened, continue
                    if (Connection.State == ConnectionState.Open)
                    {
                        // Select the computer entry with the given id
                        command.CommandText = "SELECT * FROM "
                            + classString
                            + " WHERE id='"
                            + id
                            + "'";
                        data = command.ExecuteReader();

                        // Move data to a DataTable
                        table = new DataTable();
                        table.Load(data);

                        // Destroy the connection whilst working on the data to minimise corruption
                        data.Dispose();
                        Connection.Close();

                        // Get the appropriate computer field to write to
                        field = fetched.GetType().GetField(classString);

                        // Iterate through each record and add the data to the class container
                        foreach (DataRow row in table.Rows)
                        {
                            if (abortOperation) break;
                            // Prepare container by making a new instance of the reffered class
                            object classContainer = Activator.CreateInstance(Type.GetType("CoreView." + classString));
                            foreach (DataColumn column in table.Columns)
                            {
                                if (abortOperation) break;
                                // Organise the fetched data into an appropriate class container
                                // Get the field referred to by the current column
                                classField = classContainer.GetType().GetField(column.ColumnName);
                                if (classField != null)
                                {
                                    // Insert the field into the class container converted as its native data type
                                    classField.SetValue(classContainer, Convert.ChangeType(row[column], classField.FieldType));
                                }
                            }
                            // Add this class container to the computer's field list
                            field.FieldType.GetMethod("Add").Invoke(field.GetValue(fetched), new[] { classContainer });
                        }
                    }
                    Connection.Close();
                }

                Connection.Open();
                if (Connection.State == ConnectionState.Open)
                {
                    // Get comments
                    command.CommandText = "SELECT * FROM "
                            + "comments"
                            + " WHERE id='"
                            + id
                            + "'";
                    data = command.ExecuteReader();

                    // The comments are in column 1
                    while (data.Read()) fetched.Comments = Convert.ToString(data[1]);
                }
                Connection.Close();

                // Finally, apprend the ID number
                fetched.ID = id;

                // Return the found data as a whole PC object
                return fetched;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Compares 2 computers, the base and target.
        /// Appends a numerical score to the target computer.
        /// </summary>
        /// <param name="targetComputer">The target computer PC instance.</param>
        /// <param name="baseComputer">The base computer PC instance.</param>
        public static void GetScore(PC targetComputer, PC baseComputer)
        {
            Type currentClass;
            FieldInfo currentList;
            FieldInfo[] classFields;
            IEnumerable baseList;
            IEnumerable targetList;
            double temporaryScore;

            // Reset score first
            targetComputer.Score = 0;

            foreach (string classString in ClassList.DatabaseClasses)
            {
                if (abortOperation) break;
                // Get each class's element list for both base and target computers
                currentClass = Type.GetType("CoreView." + classString);
                currentList = baseComputer.GetType().GetField(classString);

                classFields = currentClass.GetFields();

                // Get the lists as generic enumerable objects
                baseList = (IEnumerable)currentList.GetValue(baseComputer);
                targetList = (IEnumerable)currentList.GetValue(targetComputer);

                // For every field in the object of the element list
                foreach (FieldInfo field in classFields)
                {
                    if (abortOperation) break;
                    // Iterate through each and every object instance in the base/target lists
                    // Find a match between any combination of indexes
                    foreach (object baseObject in baseList)
                    {
                        if (abortOperation) break;
                        foreach (object targetObject in targetList)
                        {
                            if (abortOperation) break;
                            // If a match is found, give the target computer a higher score
                            if (field.GetValue(baseObject) == field.GetValue(targetObject))
                            {
                                // Base weight
                                temporaryScore = Configuration.Weightings[currentClass.Name][field.Name];
                                // Complaint-dependent multipliers
                                foreach (KeyValuePair<string, bool> complaint in Configuration.Complaints)
                                {
                                    if (complaint.Value == true)
                                    {
                                        // If the complaint is set, multiply the score by its respective entry
                                        temporaryScore *= Configuration.Weightings[complaint.Key][currentClass.Name];
                                    }
                                }
                                targetComputer.Score += temporaryScore;
                            }
                        }
                    }
                }
            }
        }
    }
}
