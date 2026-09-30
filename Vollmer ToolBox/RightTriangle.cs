using System;
using System.Windows.Forms;

namespace Vollmer_ToolBox
{
    public partial class RightTriangle : UserControl
    {
        // Prevent TextChanged events from clearing values
        // while the program is performing a calculation.
        private bool isCalculating = false;

        // Keep track of the two values entered by the user.
        // This allows the calculator to distinguish user input
        // from values it calculated.
        private bool userEnteredAngle = false;
        private bool userEnteredA = false;
        private bool userEnteredB = false;
        private bool userEnteredC = false;

        public RightTriangle()
        {
            InitializeComponent();

            NumericTextBoxHelper.Attach(textBox1);
            NumericTextBoxHelper.Attach(textBox2);
            NumericTextBoxHelper.Attach(textBox3);
            NumericTextBoxHelper.Attach(textBox4);

            InitializeForm();
        }

        // =========================================================
        // INITIALIZATION
        // =========================================================

        private void InitializeForm()
        {
            isCalculating = false;

            userEnteredAngle = false;
            userEnteredA = false;
            userEnteredB = false;
            userEnteredC = false;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            // All four boxes are available for user input.
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;

            textBox1.Focus();
        }

        // =========================================================
        // RESET
        // =========================================================

        private void ResetCalculator()
        {
            isCalculating = true;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            userEnteredAngle = false;
            userEnteredA = false;
            userEnteredB = false;
            userEnteredC = false;

            isCalculating = false;

            textBox1.Focus();
        }

        // =========================================================
        // UNIT CONVERSION
        // =========================================================

        private double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        private double RadiansToDegrees(double radians)
        {
            return radians * 180.0 / Math.PI;
        }

        // =========================================================
        // VALIDATION
        // =========================================================

        private bool TryGetNumber(
            TextBox textBox,
            string name,
            out double value)
        {
            value = 0;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                return false;
            }

            if (!double.TryParse(textBox.Text, out value))
            {
                MessageBox.Show(
                    $"{name} must contain a valid number.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox.Focus();

                return false;
            }

            if (double.IsNaN(value) || double.IsInfinity(value))
            {
                MessageBox.Show(
                    $"{name} contains an invalid value.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox.Focus();

                return false;
            }

            return true;
        }

        private bool ValidateSide(double value, string name)
        {
            if (value <= 0)
            {
                MessageBox.Show(
                    $"{name} must be greater than zero.",
                    "Invalid Triangle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private bool ValidateAngle(double angle)
        {
            if (angle <= 0 || angle >= 90)
            {
                MessageBox.Show(
                    "The angle must be greater than 0° and less than 90°.",
                    "Invalid Angle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        // =========================================================
        // CALCULATE
        // =========================================================

        private void CalculateTriangle()
        {
            // -----------------------------------------------------
            // Read whatever is currently in the textboxes.
            // -----------------------------------------------------

            bool hasAngle = TryGetNumber(
                textBox1,
                "Angle",
                out double angle);

            bool hasA = TryGetNumber(
                textBox2,
                "Leg A",
                out double a);

            bool hasB = TryGetNumber(
                textBox3,
                "Leg B",
                out double b);

            bool hasC = TryGetNumber(
                textBox4,
                "Hypotenuse C",
                out double c);

            // -----------------------------------------------------
            // Count values that were actually entered by the user.
            // -----------------------------------------------------

            int userInputCount = 0;

            if (userEnteredAngle)
                userInputCount++;

            if (userEnteredA)
                userInputCount++;

            if (userEnteredB)
                userInputCount++;

            if (userEnteredC)
                userInputCount++;

            // -----------------------------------------------------
            // We need exactly two user inputs.
            // -----------------------------------------------------

            if (userInputCount != 2)
            {
                MessageBox.Show(
                    "Please enter exactly two values.\n\n" +
                    "You can enter any two of:\n" +
                    "• Angle\n" +
                    "• Leg A\n" +
                    "• Leg B\n" +
                    "• Hypotenuse C",
                    "Input Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            isCalculating = true;

            try
            {
                // =================================================
                // CASE 1
                // ANGLE + A
                // Calculate B + C
                // =================================================

                if (userEnteredAngle && userEnteredA)
                {
                    if (!ValidateAngle(angle))
                        return;

                    if (!ValidateSide(a, "Leg A"))
                        return;

                    double radians = DegreesToRadians(angle);

                    b = a * Math.Tan(radians);
                    c = a / Math.Cos(radians);

                    textBox3.Text = b.ToString("F4");
                    textBox4.Text = c.ToString("F4");

                    return;
                }

                // =================================================
                // CASE 2
                // ANGLE + B
                // Calculate A + C
                // =================================================

                if (userEnteredAngle && userEnteredB)
                {
                    if (!ValidateAngle(angle))
                        return;

                    if (!ValidateSide(b, "Leg B"))
                        return;

                    double radians = DegreesToRadians(angle);

                    a = b / Math.Tan(radians);
                    c = b / Math.Sin(radians);

                    textBox2.Text = a.ToString("F4");
                    textBox4.Text = c.ToString("F4");

                    return;
                }

                // =================================================
                // CASE 3
                // ANGLE + C
                // Calculate A + B
                // =================================================

                if (userEnteredAngle && userEnteredC)
                {
                    if (!ValidateAngle(angle))
                        return;

                    if (!ValidateSide(c, "Hypotenuse C"))
                        return;

                    double radians = DegreesToRadians(angle);

                    a = c * Math.Cos(radians);
                    b = c * Math.Sin(radians);

                    textBox2.Text = a.ToString("F4");
                    textBox3.Text = b.ToString("F4");

                    return;
                }

                // =================================================
                // CASE 4
                // A + B
                // Calculate Angle + C
                // =================================================

                if (userEnteredA && userEnteredB)
                {
                    if (!ValidateSide(a, "Leg A"))
                        return;

                    if (!ValidateSide(b, "Leg B"))
                        return;

                    angle = RadiansToDegrees(
                        Math.Atan2(b, a));

                    c = Math.Sqrt(
                        (a * a) + (b * b));

                    textBox1.Text = angle.ToString("F2");
                    textBox4.Text = c.ToString("F4");

                    return;
                }

                // =================================================
                // CASE 5
                // A + C
                // Calculate Angle + B
                // =================================================

                if (userEnteredA && userEnteredC)
                {
                    if (!ValidateSide(a, "Leg A"))
                        return;

                    if (!ValidateSide(c, "Hypotenuse C"))
                        return;

                    if (a >= c)
                    {
                        MessageBox.Show(
                            "Leg A must be smaller than Hypotenuse C.",
                            "Invalid Triangle",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    angle = RadiansToDegrees(
                        Math.Acos(a / c));

                    b = Math.Sqrt(
                        (c * c) - (a * a));

                    textBox1.Text = angle.ToString("F2");
                    textBox3.Text = b.ToString("F4");

                    return;
                }

                // =================================================
                // CASE 6
                // B + C
                // Calculate Angle + A
                // =================================================

                if (userEnteredB && userEnteredC)
                {
                    if (!ValidateSide(b, "Leg B"))
                        return;

                    if (!ValidateSide(c, "Hypotenuse C"))
                        return;

                    if (b >= c)
                    {
                        MessageBox.Show(
                            "Leg B must be smaller than Hypotenuse C.",
                            "Invalid Triangle",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    angle = RadiansToDegrees(
                        Math.Asin(b / c));

                    a = Math.Sqrt(
                        (c * c) - (b * b));

                    textBox1.Text = angle.ToString("F2");
                    textBox2.Text = a.ToString("F4");

                    return;
                }
            }
            finally
            {
                isCalculating = false;
            }
        }


        // =========================================================
        // HANDLE USER INPUT
        // =========================================================

        private void HandleUserInputChange(TextBox changedBox)
        {
            /*
             * If the user changes a textbox after a calculation,
             * we need to assume that the old calculated values
             * are no longer valid.
             *
             * We therefore start a new calculation.
             */

            // If the user has already entered two values,
            // changing one of them should start a fresh calculation.
            int currentUserInputs = 0;

            if (userEnteredAngle)
                currentUserInputs++;

            if (userEnteredA)
                currentUserInputs++;

            if (userEnteredB)
                currentUserInputs++;

            if (userEnteredC)
                currentUserInputs++;

            // -----------------------------------------------------
            // Identify which box the user changed.
            // -----------------------------------------------------

            if (changedBox == textBox1)
                userEnteredAngle = true;

            else if (changedBox == textBox2)
                userEnteredA = true;

            else if (changedBox == textBox3)
                userEnteredB = true;

            else if (changedBox == textBox4)
                userEnteredC = true;

            // -----------------------------------------------------
            // If this is a fresh calculation and two inputs
            // haven't already been established, we're done.
            // -----------------------------------------------------

            currentUserInputs = 0;

            if (userEnteredAngle)
                currentUserInputs++;

            if (userEnteredA)
                currentUserInputs++;

            if (userEnteredB)
                currentUserInputs++;

            if (userEnteredC)
                currentUserInputs++;

            // -----------------------------------------------------
            // If the user is starting a new calculation after
            // everything was previously calculated, clear the
            // generated values.
            // -----------------------------------------------------

            if (currentUserInputs > 2)
            {
                StartNewCalculation(changedBox);
            }
        }

        // =========================================================
        // START A NEW CALCULATION
        // =========================================================

        private void StartNewCalculation(TextBox changedBox)
        {
            isCalculating = true;

            /*
             * The textbox that was changed is considered the
             * first input of the new calculation.
             */

            string newValue = changedBox.Text;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            // Reset input tracking.
            userEnteredAngle = false;
            userEnteredA = false;
            userEnteredB = false;
            userEnteredC = false;

            // Put the changed value back.
            changedBox.Text = newValue;

            if (changedBox == textBox1)
                userEnteredAngle = true;

            else if (changedBox == textBox2)
                userEnteredA = true;

            else if (changedBox == textBox3)
                userEnteredB = true;

            else if (changedBox == textBox4)
                userEnteredC = true;

            isCalculating = false;
        }

        // =========================================================
        // BUTTONS
        // =========================================================

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateTriangle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetCalculator();
        }

        // =========================================================
        // LOAD
        // =========================================================

        private void RightTriangle_Load(object sender, EventArgs e)
        {
        }

        // These can remain if they are connected in the Designer.
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (isCalculating)
                return;

            HandleUserInputChange(textBox3);
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (isCalculating)
                return;

            HandleUserInputChange(textBox2);
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            if (isCalculating)
                return;

            HandleUserInputChange(textBox4);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (isCalculating)
                return;

            HandleUserInputChange(textBox1);
        }
    }
}
