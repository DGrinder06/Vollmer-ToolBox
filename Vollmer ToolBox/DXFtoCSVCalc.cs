using netDxf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Vollmer_ToolBox
{
    public partial class DXFtoCSV : UserControl
    {
        // ============================================================
        // PREVIEW DATA
        // ============================================================

        private List<(string EntityType, double X, double Y, double Z,
                      double Radius, double TangentAngle)> previewPoints
            = new List<(string EntityType, double X, double Y, double Z,
                        double Radius, double TangentAngle)>();


        // ============================================================
        // CONSTRUCTOR
        // ============================================================
        public DXFtoCSV()
        {
            InitializeComponent();
            SetupDXFPreviewPanel();
            CSVdataGridView.RowHeadersWidth = 50;
            CSVdataGridView.RowPostPaint += CSVdataGridView_RowPostPaint;
            NumericTextBoxHelper.Attach(IncrementsTextBox);
            NumericTextBoxHelper.Attach(CenterOffsetTextBox);
            NumericTextBoxHelper.Attach(WheelDiameterTextBox);
            NumericTextBoxHelper.Attach(ShearAngleBox);

        }

        // ============================================================
        // INCREMENTS TEXTBOX
        // ============================================================
        private void IncrementsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        // ============================================================
        // BROWSE FOR DXF
        // ============================================================

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            // 1. Create an instance of the OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // 2. Set options (Optional)
                openFileDialog.InitialDirectory = @"C:\";// Default starting folder

                //Force the browse window to ONLY show .dxf files by default
                openFileDialog.Filter = "DXF files (*.dxf)|*.dxf"; // File types allowed
                openFileDialog.FilterIndex = 1; // Default file filter index
                openFileDialog.RestoreDirectory = true; // Remembers the last folder used

                // 3. Show the dialog and check if the user clicked "OK"
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 4. Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    // Double-check the file extension programmatically
                    // (Using System.IO.Path to extract the extension safely)
                    string extension = System.IO.Path.GetExtension(filePath);

                    // 5. Display the path inside your textbox
                    DXFPath.Text = filePath;

                }
            }
        }

        // ============================================================
        // MAIN CALCULATE BUTTON
        // ============================================================

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // 1. Get the text currently selected in the ComboBox
            string selectedText = SpeedComboBox.Text;


            // 2. Declare a variable to hold your integer
            int assignedValue = 0;

            // 3. Match the string to your custom integer values
            switch (selectedText)
            {
                case "V1":
                    assignedValue = 1;
                    break;

                case "V2":
                    assignedValue = 2;
                    break;

                case "V3":
                    assignedValue = 3;
                    break;

                case "V4":
                    assignedValue = 4;
                    break;

                default:
                    assignedValue = 1; // Fallback default
                    SpeedComboBox.Text = "V1";
                    break;
            }

            // --------------------------------------------------------
            // CSV SETTINGS
            // --------------------------------------------------------

            // 1. Validate that a file path exists in the textbox
            string dxfPath = DXFPath.Text.Trim();
            string format = "F3";
            string sep = ";";
            CultureInfo culture = CultureInfo.GetCultureInfo("de-DE");

            // --------------------------------------------------------
            // CHECK FILE
            // --------------------------------------------------------

            if (string.IsNullOrEmpty(dxfPath) || !File.Exists(dxfPath))
            {
                MessageBox.Show("Please select a valid DXF file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Load the DXF Document using netDxf
                DxfDocument dxf = DxfDocument.Load(dxfPath);
                if (dxf == null)
                {
                    MessageBox.Show("Failed to load or parse the DXF file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (CenterOffsetTextBox.Text == "")
                {

                    CenterOffsetTextBox.Text = "0";
                }

                

                // 3. Define the destination CSV file path (saves it in the same folder)
                var points = new List<(string EntityType, double X, double Y, double Z, double Radius, double TangentAngle)>();

                // Keep track of coordinates we've already added
                var uniquePoints = new HashSet<(double X, double Y, double Z)>();


                // --------------------------------------------------------
                // Add line points
                // --------------------------------------------------------

                foreach (var line in dxf.Entities.Lines)
                {

                    double startX = Math.Round(line.StartPoint.X, 3);
                    double startY = Math.Round(line.StartPoint.Y, 3);
                    double startZ = Math.Round(line.StartPoint.Z, 3);

                    double endX = Math.Round(line.EndPoint.X, 3);
                    double endY = Math.Round(line.EndPoint.Y, 3);
                    double endZ = Math.Round(line.EndPoint.Z, 3);
                    double dx;
                    double dy;
                    double lineAngleRadians;
                    double lineAngle;
                    double tanAngle;

                    const double tolerance = 0.000001;

                    dx = startX - endX;
                    dy = startY - endY;

                    if (AlternateRadioButton.Checked)
                    {

                        if (dx > 0 && dy < 0)
                        {
                            lineAngleRadians = Math.Atan2(dx, dy);
                            lineAngle = (lineAngleRadians * 180 / Math.PI);
                            lineAngle = -lineAngle;
                        }
                        else if (dx < 0 && dy < 0)
                        {
                            lineAngleRadians = Math.Atan2(-dy, -dx);
                            lineAngle = (lineAngleRadians * 180 / Math.PI - 90);

                        }

                        else if (dx < 0 && dy > 0)
                        {
                            lineAngleRadians = Math.Atan2(dx, dy);
                            lineAngle = (lineAngleRadians * 180 / Math.PI) -90;

                        }

                        else
                        {
                            lineAngleRadians = Math.Atan2(dy, dx);
                            lineAngle = (lineAngleRadians * 180 / Math.PI );
                            lineAngle = -lineAngle;
                        }


                        


                        if (Math.Abs(dy) < tolerance)
                        {
                            lineAngle = -90.0;
                        }

                        else if (Math.Abs(dx) < tolerance)
                        {
                            if (dy > 0)
                                lineAngle = 0.0;
                            else
                                lineAngle = -180.0;
                        }

                    }
                    else
                    {

                        if (dx < 0 && dy > 0)
                        {
                            lineAngleRadians = Math.Atan2(dx, dy);
                            lineAngle = (lineAngleRadians * 180 / Math.PI);

                        }
                        else if (dx > 0 && dy > 0)
                        {
                            lineAngleRadians = Math.Atan2(-dy, -dx);
                            lineAngle = (lineAngleRadians * 180 / Math.PI);

                        }

                        else if (dx < 0 && dy < 0)
                        {
                            lineAngleRadians = Math.Atan2(-dy, -dx);
                            lineAngle = (lineAngleRadians * 180 / Math.PI) + 90;
                            lineAngle = -lineAngle;

                        }

                        else
                        {

                            lineAngleRadians = Math.Atan2(dx, dy);
                            lineAngle = (lineAngleRadians * 180 / Math.PI) - 180;

                        }
                    
                    }
                    if (Math.Abs(dy) < tolerance)
                    {
                        lineAngle = -90.0;
                    }
                    else if (Math.Abs(dx) < tolerance)
                    {
                        MessageBox.Show(
                            "Please insure a slight angle in the vertical direction on your DXF.",
                            "Invalid Distance",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }


                    tanAngle = Math.Round(lineAngle, 3);
                    

                    if (uniquePoints.Add((endX, endY, endZ)))
                    {
                        points.Add(("Line", startX, startY, startZ, 0.0, tanAngle));
                    }

                    if (uniquePoints.Add((startX, startY, startZ)))
                    {
                        points.Add(("Line", endX, endY, endZ, 0.0, tanAngle));
                    }
                }


                //
                // Maximum distance allowed between points on a circle
                //

                double maxPointDistance;

                string incrementText = IncrementsTextBox.Text.Trim();

                // Try German format first
                if (!double.TryParse(
                    incrementText,
                    NumberStyles.Float,
                    CultureInfo.GetCultureInfo("de-DE"),
                    out maxPointDistance))
                {
                    // If that failed, try English format
                    if (!double.TryParse(
                        incrementText,
                        NumberStyles.Float,
                        CultureInfo.InvariantCulture,
                        out maxPointDistance))
                    {
                        MessageBox.Show(
                            "Please enter a valid Radius increment, such as 0.5.",
                            "Invalid Distance",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                }

                if (maxPointDistance <= 0)
                {
                    MessageBox.Show(
                        "Radius increments must be greater than zero.",
                        "Invalid Distance",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
                if (maxPointDistance >= 1.0)
                {
                    MessageBox.Show(
                        "Radius increments must be less than 1.0.",
                        "Invalid Distance",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                //---------------------------------
                // Calculate Wheel Diameter to Radius
                //---------------------------------
                double wheelDiameter;

                if (!double.TryParse(WheelDiameterTextBox.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out wheelDiameter))
                {
                    MessageBox.Show("Please enter a valid wheel diameter.", "Invalid Wheel Diameter",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (wheelDiameter <= 0)
                {
                    MessageBox.Show("Wheel diameter must be greater than zero.", "Invalid Wheel Diameter",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                double wheelRadius = wheelDiameter / 2.0;



                // --------------------------------------------------------
                // Add points around arcs
                // --------------------------------------------------------

                foreach (var arc in dxf.Entities.Arcs)
                {
                    double centerX = arc.Center.X;
                    double centerY = arc.Center.Y;
                    double centerZ = arc.Center.Z;
                    double radius = arc.Radius;
                    double startX = centerX + radius * Math.Cos(arc.StartAngle * Math.PI / 180.0);
                    double startY = centerY + radius * Math.Sin(arc.StartAngle * Math.PI / 180.0);
                    double endX = centerX + radius * Math.Cos(arc.EndAngle * Math.PI / 180.0);
                    double endY = centerY + radius * Math.Sin(arc.EndAngle * Math.PI / 180.0);

                    if (radius <= 0)
                        continue;

                    double startAngle = arc.StartAngle;
                    double endAngle = arc.EndAngle;

                    //------------------------------
                    // Is concave and radius too big
                    //------------------------------
                    bool concave = (startAngle >= 180);
                    bool rightCenter = (endAngle > 90);

                    if (concave && wheelRadius >= radius)
                    {
                        MessageBox.Show("The wheel radius is larger than, or equal to one of the concave radii, please adjust the dxf radii",
                          "Invalid Value",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                        return;
                    }


                    double arcAngle = endAngle - startAngle;
                    if (arcAngle < 0)
                    {
                        arcAngle += 360.0;
                    }



                    double ratio = Math.Max(0.0, Math.Min(1.0, maxPointDistance / (2.0 * radius)));
                    double maxAngleRadians = 2.0 * Math.Asin(ratio);
                    double maxAngleDegrees = maxAngleRadians * 180.0 / Math.PI;

                    if (maxAngleDegrees <= 0)
                        continue;

                    int numberOfSegments = Math.Max(1, (int)Math.Ceiling(arcAngle / maxAngleDegrees));

                    // Actual angular distance between generated points.
                    double angleIncrement = arcAngle / numberOfSegments;

                    var arcCoordinates = new List<(double X, double Y, double Z)>();



                    // ----------------------------------------------------
                    // Generate points
                    // ----------------------------------------------------
                    for (int i = 0; i <= numberOfSegments; i++)
                    {
                        double currentAngleDeg = startAngle + (i * angleIncrement);
                        double rad = currentAngleDeg * Math.PI / 180.0;

                        double px = Math.Round(centerX + radius * Math.Cos(rad), 3);
                        double py = Math.Round(centerY + radius * Math.Sin(rad), 3);
                        double pz = Math.Round(centerZ, 3);

                        arcCoordinates.Add((px, py, pz));
                    }



                    for (int i = 0; i < arcCoordinates.Count; i++)
                    {

                        var current = arcCoordinates[i];
                        double startTangentAngle;
                        double tangentAngle;


                        if (AlternateRadioButton.Checked && (concave))

                        {
                            startTangentAngle = startAngle - 360;
                            tangentAngle = startTangentAngle + (i * angleIncrement);
                            tangentAngle = Math.Round(tangentAngle, 3);
                        }
                        else if (AlternateRadioButton.Checked && (!concave))
                        {
                            if (rightCenter)
                            {
                                startTangentAngle = startAngle - 180;
                                tangentAngle = startTangentAngle + (i * angleIncrement);
                                tangentAngle = Math.Round(tangentAngle, 3);
                            }
                            else
                            {
                                startTangentAngle = startAngle - 180;
                                tangentAngle = startTangentAngle + (i * angleIncrement);
                                tangentAngle = Math.Round(tangentAngle, 3);
                            }
                        }
                        else

                        if (concave)
                        {
                            startTangentAngle = startAngle - 180;
                            tangentAngle = startTangentAngle + (i * angleIncrement);
                            tangentAngle = Math.Round(-tangentAngle, 3);
                        }

                        else
                        {
                            if (rightCenter)
                            {
                                startTangentAngle = startAngle - 180;
                                tangentAngle = startTangentAngle - (i * angleIncrement);
                                tangentAngle = Math.Round(tangentAngle, 3);
                            }

                            else 
                            {
                                startTangentAngle = startAngle  ;
                                tangentAngle = -startTangentAngle - (i * angleIncrement);
                                tangentAngle = Math.Round(tangentAngle, 3);
                            }
                        }


                        if (uniquePoints.Add((current.X, current.Y, current.Z)))
                        {
                            points.Add(("Arc", current.X, current.Y, current.Z, radius, tangentAngle));
                        }

                    }
                }

                var sorted = points;

                if (ReverseCheckBox.Checked)
                {
                    sorted = points.OrderBy(p => p.X).ToList();

                }
                else
                {
                    // 4. Preserve the order in which the points were generated
                    sorted = points.OrderByDescending(p => p.X).ToList();
                }

                // --------------------------------------------------------
                // Update DXF preview
                // --------------------------------------------------------

                previewPoints = sorted.ToList();

                DXFViewerPanel.Invalidate();


                // 5. Build CSV and write file
                string csvPath = Path.ChangeExtension(dxfPath, ".csv");
                var sb = new StringBuilder();
                sb.AppendLine("Y;Z;X;A;C;Feed;Theta;Tau");

                File.WriteAllText(csvPath, sb.ToString());

                MessageBox.Show($"File saved successfully:\n\n{csvPath}","File Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);

                foreach (var p in sorted)
                {

                    string x = p.X.ToString(format, culture);

                    double shearAngle = 0;
                    double centerOffset = double.Parse(CenterOffsetTextBox.Text);


                    double.TryParse(ShearAngleBox.Text, NumberStyles.Float, culture, out shearAngle);


                    double angleRadians = shearAngle * Math.PI / 180.0;

                    // Use the first point as the reference
                    double firstX = sorted.First().X;
                    double lastX = sorted.Last().Z;
                    double firstY;
                    double calculatedY;

                    if (ReverseCheckBox.Checked)
                    {
                        firstY = sorted.First().Z + (p.X - lastX) * Math.Tan(angleRadians);
                        calculatedY = p.Z;
                        calculatedY = -firstY + centerOffset;
                    }
                    else
                    {
                        firstY = sorted.First().Z + centerOffset;
                        calculatedY = p.Z;
                        calculatedY = firstY - (p.X - firstX) * Math.Tan(angleRadians);
                    }

                    double tangentAngle = p.TangentAngle;



                    string z = p.Y.ToString(format, culture);
                    string y = calculatedY.ToString(format, culture);
                    string r = p.Radius.ToString(format, culture);
                    string a = 0.00.ToString(format, culture);
                    string feed = assignedValue.ToString(format, culture);
                    string c = string.Empty;

                    if (ShearAngleBox.Text == "")
                    {

                        ShearAngleBox.Text = "0";
                    }



                    if (AlternateRadioButton.Checked)
                    {
                        double cValue = 180;

                        if (double.TryParse(ShearAngleBox.Text, NumberStyles.Float, culture, out shearAngle))
                        {
                            cValue = (cValue + shearAngle);
                        }

                        c = cValue.ToString(format, culture);
                    }
                    else
                    {

                        if (double.TryParse(ShearAngleBox.Text, NumberStyles.Float, culture, out double cValue))
                        {
                            c = cValue.ToString(format, culture);
                        }
                    }

                    string t = p.TangentAngle.ToString(format, culture);



                    sb.AppendLine($"{y}{sep}{z}{sep}{x}{sep}{a}{sep}{c}{sep}{feed}{sep}{t}{sep}{a}");

                }

                File.WriteAllText(csvPath, sb.ToString(), Encoding.UTF8);

                // Clear existing data
                CSVdataGridView.DataSource = null;
                CSVdataGridView.Columns.Clear();
                CSVdataGridView.Rows.Clear();

                // Read CSV
                string[] lines = File.ReadAllLines(csvPath);

                if (lines.Length == 0)
                {
                    MessageBox.Show("CSV file is empty.");
                    return;
                }

                // Create DataTable
                DataTable table = new DataTable();

                // -----------------------------------------
                // Create columns from header
                // -----------------------------------------

                string[] headers = lines[0].Split(';');

                foreach (string header in headers)
                {
                    table.Columns.Add(header.Trim());
                }

                // -----------------------------------------
                // Add CSV rows
                // -----------------------------------------

                for (int i = 1; i < lines.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(lines[i]))
                        continue;

                    string[] values = lines[i].Split(';');

                    // Only add rows with the correct number of columns
                    if (values.Length == table.Columns.Count)
                    {
                        table.Rows.Add(values);
                    }
                }

                // -----------------------------------------
                // Display DataTable in DataGridView
                // -----------------------------------------

                CSVdataGridView.AutoGenerateColumns = true;
                CSVdataGridView.DataSource = table;

                // Optional formatting
                CSVdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (DataGridViewColumn column in CSVdataGridView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }





            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during conversion: {ex.Message} Make sure the dxf file is 2007", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        private void CAxisTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void SpeedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void IncrementsTextBox_Enter(object sender, EventArgs e)
        {

        }

        private void CAxisTextBox_Enter(object sender, EventArgs e)
        {
            CSVPictureBox.Image = Properties.Resources.ShearPic;
        }

        private void CAxisTextBox_Leave(object sender, EventArgs e)
        {
            CSVPictureBox.Image = Properties.Resources.OpenProcedurePic;
            if (double.TryParse(
        ShearAngleBox.Text,
        NumberStyles.Float,
        CultureInfo.GetCultureInfo("de-DE"),
        out double value))
            {
                if (AlternateRadioButton1 && value > 20)
                {
                    MessageBox.Show(
                        "The shear angle cannot be greater than 20 when Alternate is selected.",
                        "Invalid Value",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    ShearAngleBox.Text = "20";
                }
                if (!AlternateRadioButton1 && value > 15)
                {
                    MessageBox.Show(
                        "The shear angle cannot be greater than 15.",
                        "Invalid Value",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    ShearAngleBox.Text = "15";
                }
                else
                {
                    ShearAngleBox.Text = ShearAngleBox.Text; // Keep the value as is if it's valid
                }

            }
        }

        private void CSVdataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            CSVdataGridView.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();

        }

        private void AlternateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AlternateRadioButton.Checked)
            {
                CSVPictureBox.Image = Properties.Resources.GrindingPositionTwo;
            }
            else
            {
                CSVPictureBox.Image = Properties.Resources.OpenProcedurePic;
            }
        }
        private bool AlternateRadioButton1 = false;
        private void AlternateRadioButton_Leave(object sender, EventArgs e)
        {
            CSVPictureBox.Image = Properties.Resources.OpenProcedurePic;
        }

        private void AlternateRadioButton_Click(object sender, EventArgs e)
        {
            AlternateRadioButton1 = !AlternateRadioButton1;
            AlternateRadioButton.Checked = AlternateRadioButton1;
        }

        private void WheelDiameterTextBox_Enter(object sender, EventArgs e)
        {
            CSVPictureBox.Image = Properties.Resources.WheelDiameter;
        }

        private void WheelDiameterTextBox_Leave(object sender, EventArgs e)
        {
            CSVPictureBox.Image = Properties.Resources.OpenProcedurePic;
        }

        private void CenterOffsetTextBox_Enter(object sender, EventArgs e)
        {
            CSVPictureBox.Image = Properties.Resources.SideDistance;
        }

        private void CenterOffsetTextBox_Leave(object sender, EventArgs e)
        {
            CSVPictureBox.Image = Properties.Resources.OpenProcedurePic;

        }

        private bool ReverseCheckBox1 = false;
        private void ReverseCheckBox_Click(object sender, EventArgs e)
        {
            ReverseCheckBox1 = !ReverseCheckBox1;
            ReverseCheckBox.Checked = ReverseCheckBox1;
        }

        private void SetupDXFPreviewPanel()
        {
            DXFViewerPanel.BackColor = Color.White;
            DXFViewerPanel.BorderStyle = BorderStyle.FixedSingle;

            // Enable double buffering to prevent flickering
            typeof(Panel)
                .GetProperty("DoubleBuffered",
                    System.Reflection.BindingFlags.Instance |
                    System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(DXFViewerPanel, true, null);

            DXFViewerPanel.Paint += DXFViewerPanel_Paint;
            DXFViewerPanel.Resize += DXFViewerPanel_Resize;
        }
        private void DXFViewerPanel_Resize(object sender, EventArgs e)
        {
            DXFViewerPanel.Invalidate();    
        }
        // ============================================================
        // DRAW PREVIEW
        // ============================================================

        private void DXFViewerPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.Clear(Color.White);

            if (previewPoints == null || previewPoints.Count == 0)
            {
                using (Font font = new Font("Segoe UI", 10))
                using (Brush brush = new SolidBrush(Color.Gray))
                {
                    string message = "No DXF points generated";

                    SizeF size = g.MeasureString(message, font);

                    g.DrawString(
                        message,
                        font,
                        brush,
                        (DXFViewerPanel.Width - size.Width) / 2,
                        (DXFViewerPanel.Height - size.Height) / 2);
                }

                return;
            }


            // --------------------------------------------------------
            // Find drawing bounds
            // --------------------------------------------------------

            double minX = previewPoints.Min(p => p.X);
            double maxX = previewPoints.Max(p => p.X);

            double minY = previewPoints.Min(p => p.Y);
            double maxY = previewPoints.Max(p => p.Y);

            double width = maxX - minX;
            double height = maxY - minY;

            // Prevent division by zero
            if (width < 0.000001)
                width = 1;

            if (height < 0.000001)
                height = 1;


            // --------------------------------------------------------
            // Panel margins
            // --------------------------------------------------------

            const float margin = 30;

            float availableWidth =
                DXFViewerPanel.ClientSize.Width - (margin * 2);

            float availableHeight =
                DXFViewerPanel.ClientSize.Height - (margin * 2);

            if (availableWidth <= 0 || availableHeight <= 0)
                return;


            // --------------------------------------------------------
            // Calculate scale
            // --------------------------------------------------------

            double scaleX = availableWidth / width;
            double scaleY = availableHeight / height;

            // Use the same scale for X and Y so the geometry
            // does not become distorted.
            double scale = Math.Min(scaleX, scaleY);


            // --------------------------------------------------------
            // Center the drawing
            // --------------------------------------------------------

            double drawingWidth = width * scale;
            double drawingHeight = height * scale;

            double offsetX =
                (DXFViewerPanel.ClientSize.Width - drawingWidth) / 2.0;

            double offsetY =
                (DXFViewerPanel.ClientSize.Height - drawingHeight) / 2.0;


            // --------------------------------------------------------
            // Convert DXF coordinates to screen coordinates
            // --------------------------------------------------------

            PointF ToScreen(double x, double y)
            {
                float screenX =
                    (float)(offsetX + (x - minX) * scale);

                // Windows screen Y increases downward,
                // DXF Y increases upward.
                float screenY =
                    (float)(offsetY + (maxY - y) * scale);

                return new PointF(screenX, screenY);
            }


            // --------------------------------------------------------
            // Draw axes
            // --------------------------------------------------------

            using (Pen axisPen = new Pen(Color.LightGray, 1))
            {
                // X axis
                if (minY <= 0 && maxY >= 0)
                {
                    PointF p1 = ToScreen(minX, 0);
                    PointF p2 = ToScreen(maxX, 0);

                    g.DrawLine(axisPen, p1, p2);
                }

                // Y axis
                if (minX <= 0 && maxX >= 0)
                {
                    PointF p1 = ToScreen(0, minY);
                    PointF p2 = ToScreen(0, maxY);

                    g.DrawLine(axisPen, p1, p2);
                }
            }


            // --------------------------------------------------------
            // Draw connecting path
            // --------------------------------------------------------

            using (Pen pathPen = new Pen(Color.DodgerBlue, 1.5f))
            {
                for (int i = 1; i < previewPoints.Count; i++)
                {
                    var previous = previewPoints[i - 1];
                    var current = previewPoints[i];

                    PointF p1 = ToScreen(previous.X, previous.Y);
                    PointF p2 = ToScreen(current.X, current.Y);

                    g.DrawLine(pathPen, p1, p2);
                }
            }


            // --------------------------------------------------------
            // Draw points
            // --------------------------------------------------------

            const float pointSize = 6;

            for (int i = 0; i < previewPoints.Count; i++)
            {
                var point = previewPoints[i];

                PointF screenPoint = ToScreen(point.X, point.Y);

                Brush brush;

                if (point.EntityType == "Line")
                {
                    brush = Brushes.Red;
                }
                else
                {
                    brush = Brushes.Blue;
                }

                float x = screenPoint.X - pointSize / 2;
                float y = screenPoint.Y - pointSize / 2;

                g.FillEllipse(brush,x,y,pointSize,pointSize);
            }


            // --------------------------------------------------------
            // Highlight first point
            // --------------------------------------------------------

            PointF firstPoint =ToScreen(previewPoints.First().X,previewPoints.First().Y);

            using (Pen firstPen = new Pen(Color.Green, 2))
            {
                g.DrawEllipse(firstPen,firstPoint.X - 5,firstPoint.Y - 5,10,10);
            }


            // --------------------------------------------------------
            // Highlight last point
            // --------------------------------------------------------

            PointF lastPoint = ToScreen(previewPoints.Last().X,previewPoints.Last().Y);

            using (Pen lastPen = new Pen(Color.Black, 2))
            {
                g.DrawEllipse(lastPen,lastPoint.X - 5,lastPoint.Y - 5,10,10);
            }


            // --------------------------------------------------------
            // Draw point count
            // --------------------------------------------------------

            using (Font font = new Font("Segoe UI", 8))
            using (Brush brush = new SolidBrush(Color.DimGray))
            {
                string text =
                    $"Points: {previewPoints.Count}";

                g.DrawString(text,font,brush,5,5);
            }
        }
    }
}





