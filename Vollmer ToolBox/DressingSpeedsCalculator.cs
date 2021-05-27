using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vollmer_ToolBox
{
    public partial class DressingSpeedsCalculator : UserControl
    {
        double dressingWheelRPM = 0;
        double grindingWheelRPM = 0;
        double grindingWheelDiameter = 0;
        double dressingWheelDiameter = 0;
        bool checkbox = false;
        double checkBoxValue = 0;

        
        public DressingSpeedsCalculator()
        {
            InitializeComponent();
                        
        }

       

        private void DressingSpeedsCalculator_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
           
        }
        //calculation
        private void calculation()
        {
            string machine = comboBox1.SelectedItem.ToString();
            int indexNumber = comboBox1.FindString(machine);


            checkbox = checkBox1.Checked;
            if (checkbox)
            {
                checkBoxValue = 2;
            }
            else
            {
                checkBoxValue = 1.2;
            }

            

            grindingWheelDiameter = Convert.ToDouble(textBox1.Text);
            grindingWheelRPM = Convert.ToDouble(textBox3.Text);
            dressingWheelDiameter = Convert.ToDouble(textBox2.Text);
            dressingWheelRPM = (grindingWheelDiameter * 3.14 * grindingWheelRPM / 60000 * checkBoxValue * 60000) / (dressingWheelDiameter * 3.14);
            if (dressingWheelRPM > 4500)
            {
                MessageBox.Show("Dressing Wheel RPMs are over 4500");
            }
            else
            {
                if (indexNumber == 0)
                {
                    if (grindingWheelRPM <= 1700)
                    {
                        MessageBox.Show("Grinding Wheel RPMs cannot be less than 1700 on the Vgrind");
                    }
                    else
                    {
                        textBox4.Text = Convert.ToString(Math.Round(dressingWheelRPM,4));
                    }
                }
                else
                   if (grindingWheelRPM > 1000)
                {
                    MessageBox.Show("Grinding wheel RPMs cannot be higher than 1000 on the Rush");
                }
                else
                {
                    textBox4.Text = Convert.ToString(Math.Round(dressingWheelRPM, 4));
                }
                
            }
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Data Incomplete"); 
            }
            else
            {
                calculation();
            }
            
        }
        //allows only numeric values to be entered
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //allows only numeric values to be entered
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //allows only numeric values to be entered
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

           
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //allows only numeric values to be entered
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
