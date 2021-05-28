using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vollmer_ToolBox
{
    public partial class RightTriangle : UserControl

    {
        double legA = 0;
        double legB = 0;
        double legC = 0;
        double angle = 0;




     
        public RightTriangle()
        {
            InitializeComponent();
        }
        private void zeroVariable()
        {
            legA = 0;
            legB = 0;
            legC = 0;
            angle = 0;
            
        }
        private void RightTriangle_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox4.ReadOnly = true;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
        }

    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox4.ReadOnly = false;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox4.ReadOnly = false;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = true;
        }
       
    
        private void tan() // Function for Tangent selection
        {
            textBox4.ReadOnly = true;

            if (textBox1.ReadOnly == true)
            {
                textBox1.Text = "";
            }
            else if (textBox2.ReadOnly == true)
            {
                textBox2.Text = "";
            }
            else if (textBox3.ReadOnly == true)
            {
                textBox3.Text = "";
            }
            else
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                
            }
            if (textBox1.Text == "" && textBox2.Text == "" || textBox3.Text == "" && textBox2.Text == "" || textBox1.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Incomplete Data");
            }


            else if (textBox1.Text == "")  // Finding the Tangent Angle with known legs
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                legA = Convert.ToDouble(textBox2.Text);
                legB = Convert.ToDouble(textBox3.Text);
                angle = Math.Atan(legB / legA) * 180 / Math.PI;
                legC = legA / Math.Cos(angle * (Math.PI / 180));
                textBox1.Text = Convert.ToString(Math.Round(angle, 2));
                textBox4.Text = Convert.ToString(Math.Round(legC, 4));

            }
            else if (textBox2.Text == "") // Finding leg A with known B and angle
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = false;
                angle = Convert.ToDouble(textBox1.Text);
                legB = Convert.ToDouble(textBox3.Text);
                legA = legB / Math.Tan(angle * (Math.PI / 180));
                legC = legA / Math.Cos(angle * (Math.PI / 180));
                textBox2.Text = Convert.ToString(Math.Round(legA, 4));
                textBox4.Text = Convert.ToString(Math.Round(legC, 4));
            }
            else if (textBox3.Text == "") // Finding leg B with known A and angle
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = true;
                angle = Convert.ToDouble(textBox1.Text);
                legA = Convert.ToDouble(textBox2.Text);
                legB = legA * Math.Tan(angle * (Math.PI / 180));
                legC = legA / Math.Cos(angle * (Math.PI / 180));
                textBox3.Text = Convert.ToString(Math.Round(legB, 4));
                textBox4.Text = Convert.ToString(Math.Round(legC, 4));
            }

            
        }
        private void sin() // Function for sin selection
        {
            textBox2.ReadOnly = true;

            if (textBox1.ReadOnly == true)
            {
                textBox1.Text = "";
            }
            else if (textBox3.ReadOnly == true)
            {
                textBox3.Text = "";
            }
            else if (textBox4.ReadOnly == true)
            {
                textBox4.Text = "";
            }
            else
            {
                textBox1.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
            }
            if (textBox1.Text == "" && textBox3.Text == "" || textBox3.Text == "" && textBox4.Text == "" || textBox1.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Incomplete Data");
            }


            else if (textBox1.Text == "")  // Finding the Sin Angle with known legs
            {
                textBox1.ReadOnly = true;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                legB = Convert.ToDouble(textBox3.Text);
                legC = Convert.ToDouble(textBox4.Text);
                angle = Math.Asin(legB / legC) * 180 / Math.PI;
                legA = legC * Math.Cos(angle * (Math.PI / 180));
                textBox1.Text = Convert.ToString(Math.Round(angle, 2));
                textBox2.Text = Convert.ToString(Math.Round(legA, 4));
            }
            else if (textBox4.Text == "") // Finding leg C with known B and angle
            {
                textBox1.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = true;
                angle = Convert.ToDouble(textBox1.Text);
                legB = Convert.ToDouble(textBox3.Text);
                legC = legB / Math.Sin(angle * (Math.PI / 180));
                legA = legC * Math.Cos(angle * (Math.PI / 180));
                textBox4.Text = Convert.ToString(Math.Round(legC, 4));
                textBox2.Text = Convert.ToString(Math.Round(legA, 4));
            }
            else if (textBox3.Text == "") // Finding leg B with known C and angle
            {
                textBox1.ReadOnly = false;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = false;
                angle = Convert.ToDouble(textBox1.Text);
                legC = Convert.ToDouble(textBox4.Text);
                legB = legC * Math.Sin(angle * (Math.PI / 180));
                legA = legC * Math.Cos(angle * (Math.PI / 180));
                textBox3.Text = Convert.ToString(Math.Round(legB, 4));
                textBox2.Text = Convert.ToString(Math.Round(legA, 4));
            }

        }
        private void cos()
        {
            textBox3.ReadOnly = true;

            if (textBox1.ReadOnly == true)
            {
                textBox1.Text = "";
            }
            else if (textBox2.ReadOnly == true)
            {
                textBox2.Text = "";
            }
            else if (textBox4.ReadOnly == true)
            {
                textBox4.Text = "";
            }
            else
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox4.ReadOnly = false;
            }
            if (textBox1.Text == "" && textBox2.Text == "" || textBox2.Text == "" && textBox4.Text == "" || textBox1.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Incomplete Data");
            }


            else if (textBox1.Text == "")  // Finding the Cos Angle with known legs
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
                textBox4.ReadOnly = false;
                legA = Convert.ToDouble(textBox2.Text);
                legC = Convert.ToDouble(textBox4.Text);
                angle = Math.Acos(legA / legC) * 180 / Math.PI;
                legB = legA * Math.Tan(angle * (Math.PI / 180));
                textBox1.Text = Convert.ToString(Math.Round(angle, 2));
                textBox3.Text = Convert.ToString(Math.Round(legB, 4));
            }
            else if (textBox4.Text == "") // Finding leg C with known A and angle
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox4.ReadOnly = true;
                angle = Convert.ToDouble(textBox1.Text);
                legA = Convert.ToDouble(textBox2.Text);
                legC = legA / Math.Cos(angle * (Math.PI / 180));
                legB = legA * Math.Tan(angle * (Math.PI / 180));
                textBox4.Text = Convert.ToString(Math.Round(legC, 4));
                textBox3.Text = Convert.ToString(Math.Round(legB, 4));
            }
            else if (textBox2.Text == "") // Finding leg A with known C and angle
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = true;
                textBox4.ReadOnly = false;
                angle = Convert.ToDouble(textBox1.Text);
                legC = Convert.ToDouble(textBox4.Text);
                legA = legC * Math.Cos(angle * (Math.PI / 180));
                legB = legA * Math.Tan(angle * (Math.PI / 180));
                textBox2.Text = Convert.ToString(Math.Round(legA, 4));
                textBox3.Text = Convert.ToString(Math.Round(legB, 4));
            }
        }
        private void calculation()
        {
            
            if (radioButton1.Checked == true)
            {
                tan();
            }
            else if (radioButton2.Checked == true)
            {
                sin();

            }
            else if (radioButton3.Checked == true)
            {
                cos();
            }

        
            else
            {
                MessageBox.Show("Please select an Angle");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            zeroVariable();
            calculation();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            textBox4.ReadOnly = true;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
           
        }
    }
}
