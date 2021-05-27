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
        double legAC = 0;
        double legAB = 0;
        double Angle = 0;
        


        public RightTriangle()
        {
            InitializeComponent();
        }
        
        private void RightTriangle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
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
            textBox4.ReadOnly = false;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.ReadOnly = false;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = true;
        }
       
        private void tan()
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Incomplete Data");
            }
                else if (textBox1.Text == "")
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                }
                else if (textBox2.Text == "")
                {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = false;
                }
                else if (textBox3.Text == "")
                {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = true;
                }
            

        }
        private void sin()
        {
           textBox1.Text = "s";
            
        }
        private void cos()
        {
            textBox1.Text = "c";            
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            calculation();
        }
    }
}
