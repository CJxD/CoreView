using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CoreView
{
    public class Graph
    {
        private Panel Target;
        private Control TargetControl;
        public bool DrawAxes { get; set; }
        private float GridSpacing;
		public float MaxValue { get; set; }
		public float MinValue { get; set; }
        public int Resolution { get; set; }
        private int SampleCount;
        public List<GraphSeries> Series { get; set; }
        private float ZeroIndex;

        public Graph(Panel graphArea, bool drawAxes)
        {
            // Initialise graph series list
            this.Series = new List<GraphSeries>();

            // Initialise redraw events
            this.Target = graphArea;
            this.TargetControl = (Control)this.Target;
            this.TargetControl.Paint += new PaintEventHandler(this.DrawGraph);

			// Set a max value of 1 to avoid division by zero if something goes wrong
			this.MaxValue = 1;
            this.DrawAxes = drawAxes;
            // Automatic resolution of 10 pixels per point
            this.Resolution = 10;
        }

		// Creates a redraw event
		public void Redraw()
		{
			this.TargetControl.Invalidate();
		}
		// This function may only be called by a redraw event
        private void DrawGraph(object sender, PaintEventArgs e)
        {
            // Set up graphic options
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Recalculate sample count if width has changed
            // Round up
            this.SampleCount = (int)Math.Ceiling((float)this.Target.Width / this.Resolution);

            foreach (GraphSeries series in this.Series)
            {
                // Recalculate maximum and minimum values
                if (series.MaxValue > this.MaxValue) this.MaxValue = series.MaxValue;
                if (series.MinValue < this.MinValue) this.MinValue = series.MinValue;

                // Recalculate zero index as difference between 0 and lowest value
                // This shows where the line y=0 is (only perform if the lowest value is less than 0
                if (this.MinValue < 0)
                {
                    this.ZeroIndex = 0 - this.MinValue;
                }

                // Change CoordinateMemory size if target width changed
                series.ResizeMemory(this.SampleCount + 1);
            }

            // If the box is big enough, include labels. Otherwise, dont.
            if (this.DrawAxes && this.Target.Height > 120)
            {
                this.DrawGridLines(e, true);
                this.WriteSeriesKey(e);
            }
            else
            {
                this.DrawGridLines(e, false);
            }

            // Number to calculate the pixel scale in proportion to the minimum and maximum values
            float scale = this.Target.Height / (this.MaxValue - this.MinValue);

            // Iterate through each x coordinate and plot the respective y coordinate
            // Resolution is the number of pixels per x coordinate
            // Start at point 2 (which is the value of resolution at this point)
            float fromX, fromY, toX, toY;

            // Iterate through each graph series
            foreach (GraphSeries series in this.Series)
            {
                // Add Resoltion to the counter for each iteration to go to the next x coordinate
                for (int i = 1; i <= this.SampleCount; i++)
                {
                    // Start from the right (width - value = distance from right)
                    fromX = this.Target.Width - i * this.Resolution;
                    // Calculate the y coordinate as a proportion of the height
                    // Add the offset for the zero index incase negative numbers are present
                    fromY = (series.CoordinateMemory[i] + this.ZeroIndex) * scale;
                    // Reverse y coordinate for the same reason as the x coordinate
                    fromY = this.Target.Height - fromY;

                    // Same again for the second coordinate (subtract 1 unit from the counter for all instances here on)
                    toX = this.Target.Width - (i - 1) * this.Resolution;
                    toY = (series.CoordinateMemory[i - 1] + this.ZeroIndex) * scale;
                    toY = this.Target.Height - toY;
                    e.Graphics.DrawLine(
                        series.Pen,
                        fromX,
                        fromY,
                        toX,
                        toY
                    );
                }
            }
        }

        private void DrawGridLines(PaintEventArgs e, bool includeLabels)
        {
            // Find the units as tens, hundreds, thousands etc by taking a base-10 logarithm, rounding it down, then raising ten by this number
            // This gives us the lowest useful scale factor
			float tenPower = (float)Math.Log10(this.MaxValue - this.MinValue);
			// This if statement will reduce the scale in cases where the maximum value will only meet the first scale line
			// For example, a percentage scale will use intervals of 10 rather than 100
			// If the power of 10 is a whole number, it's just at the tip of the scale
			if (tenPower % 1 == 0) tenPower -= 1;
            this.GridSpacing = (float)Math.Pow(10, Math.Floor(tenPower));

            float scale = this.Target.Height / (this.MaxValue - this.MinValue);

            // Y Axis
            // Get the y values of Grid Space and Zero Index in pixels
            int gridSpaceValue = Convert.ToInt32(this.GridSpacing * scale);
			int zeroValue = Convert.ToInt32(this.ZeroIndex * scale);

            // For each grid space between the Zero Index and the height of the container, draw a grid line
            // Up from Zero Index
            for (int i = zeroValue; i < this.Target.Height; i += gridSpaceValue)
            {
                // Reverse the height to get value from bottom to top instead of top to bottom
                e.Graphics.DrawLine(
                    new Pen(Color.CadetBlue, 1),
                    0,
                    this.Target.Height - i,
                    this.Target.Width,
                    this.Target.Height - i
                );
                if (includeLabels)
                {
                    // Write label
                    // Label value is the iteration counter divided by the formula to work out pixel height from value
                    // Offset of (10, 15)
                    e.Graphics.DrawString(
                        Convert.ToString((i / gridSpaceValue) * this.GridSpacing),
                        new Font("Courier New", 10),
                        new SolidBrush(Color.PowderBlue),
                        new Point(10, this.Target.Height - (i + 15))
                    );
                }
            }
            // Down from Zero Index
            for (int i = zeroValue; i > 0; i -= gridSpaceValue)
            {
                e.Graphics.DrawLine(
                    new Pen(Color.CadetBlue, 1),
                    0,
                    this.Target.Height - i,
                    this.Target.Width,
                    this.Target.Height - i
                );
                if (includeLabels)
                {
                    e.Graphics.DrawString(
                        Convert.ToString((i / gridSpaceValue) * this.GridSpacing),
                        new Font("Courier New", 10),
                        new SolidBrush(Color.PowderBlue),
                        new Point(10, this.Target.Height - (i + 15))
                    );
                }
            }
            // Thick zero line
            e.Graphics.DrawLine(new Pen(Color.CadetBlue, 3), 0, this.Target.Height - zeroValue, 0, this.Target.Height - zeroValue);

            // X Axis
            // Grid lines parallel to the x axis are fixed to 5 samples per grid
            for (int i = 0; i < this.Target.Width; i += this.Resolution * 5)
            {
                // Reverse the width for the same reasons as above
                e.Graphics.DrawLine(
                    new Pen(Color.CadetBlue, 1),
                    this.Target.Width - i,
                    0,
                    this.Target.Width - i,
                    this.Target.Height
                );
            }
        }

        private void WriteSeriesKey(PaintEventArgs e)
        {
            // Height is increased for each series label in the key. This is to stack them.
            int height = 0;

            // Write labels and lines for a key
            foreach (GraphSeries series in this.Series)
            {
                // Calculate x location by subtracting the length of the string from the width
                int location = this.Target.Width - (series.Name.Length * 8);

                // Write label
                e.Graphics.DrawString(
                    series.Name,
                    new Font("Courier New", 10),
                    new SolidBrush(series.Pen.Color),
                    new Point(location - 35, height)
                );
                // Draw line
                e.Graphics.DrawLine(
                    series.Pen,
                    this.Target.Width - 25,
                    height + 8,
                    this.Target.Width - 5,
                    height + 8
                );

                // Increment height
                height += 20;
            }
        }
    }

    public class GraphSeries
    {
        public List<int> CoordinateMemory { get; private set; }
        public float MaxValue { get; private set; }
        public float MinValue { get; private set; }
        public string Name { get; set; }
        public Pen Pen { get; set; }
        public float ZeroIndex { get; private set; }

        public GraphSeries(string name, Pen linePen)
        {
            this.CoordinateMemory = new List<int>();

            this.Name = name;
            this.Pen = linePen;
        }

        public void AddValue(int value)
        {
            InsertCoordinate(value);
        }

        public void ResizeMemory(int sampleCount)
        {
            // Recalculates the capacity of the CoordinateMemory based on Target width
            // Trim digits from the end if necessary
            for (int i = this.CoordinateMemory.Count - 1; i >= sampleCount; i--)
            {
                this.CoordinateMemory.RemoveAt(i);
            }
            // Resize capacity
            this.CoordinateMemory.Capacity = sampleCount;

            // Fill any uninitialised spaces with zero values
            for (int i = this.CoordinateMemory.Count; i < this.CoordinateMemory.Capacity; i++)
            {
                this.CoordinateMemory.Add(0);
            }
        }

        private void InsertCoordinate(int coordinate)
        {
            // Insert new coordinate at start
            this.CoordinateMemory.Insert(0, coordinate);

            // Set new max/min values
            if (this.CoordinateMemory[0] > this.MaxValue)
            {
                this.MaxValue = this.CoordinateMemory[0];
            }
            else if (this.CoordinateMemory[0] < this.MinValue)
            {
                this.MinValue = this.CoordinateMemory[0];
            }
        }
    }
}
