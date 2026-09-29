using System;
using System.Windows.Forms;

namespace Vollmer_ToolBox
{
    public class NumericTextBoxHelper
    {
        public static void Attach(TextBox textBox)
        {
            textBox.KeyPress += NumericTextBox_KeyPress;
        }

        private static void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Allow Backspace, Delete, arrow keys, etc.
            if (char.IsControl(e.KeyChar))
                return;

            // Allow numbers
            if (char.IsDigit(e.KeyChar))
                return;

            // Allow one decimal point
            if (e.KeyChar == '.' && !textBox.Text.Contains("."))
                return;

            // Allow negative sign only at the beginning
            if (e.KeyChar == '-' &&
                textBox.SelectionStart == 0 &&
                !textBox.Text.Contains("-"))
            {
                return;
            }

            // Reject everything else
            e.Handled = true;
        }
    }
}
    

       