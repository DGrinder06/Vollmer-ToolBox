using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Vollmer_ToolBox
{
    


    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;


        public Form1()
        {
            InitializeComponent();

            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

            dressingSpeedsCalculator1.BringToFront();

            panel2.Resize += (s, e) => PositionWindowButtons();
        }

        private bool isFullScreen = false;

        private Rectangle previousBounds;
        private FormBorderStyle previousBorderStyle;
        private FormWindowState previousWindowState;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            dressingSpeedsCalculator1.BringToFront();

        }

        public void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            RightTrianglePanel.BringToFront();
        }


        private void dressingSpeedsCalculator1_Load_1(object sender, EventArgs e)
        {

        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rightTriangle1_Load(object sender, EventArgs e)
        {

        }

        private void DXFtoCSV_Click(object sender, EventArgs e)
        {
            SidePanel.Height = DXFtoCSVButton.Height;
            SidePanel.Top = DXFtoCSVButton.Top;
            CSV.BringToFront();
        }

        private void CSV_Load(object sender, EventArgs e)
        {

        }

        private void FullScreenButton_Click(object sender, EventArgs e)
        {
            if (!isFullScreen)
            {
                previousBounds = this.Bounds;
                previousBorderStyle = this.FormBorderStyle;
                previousWindowState = this.WindowState;

                Screen screen = Screen.FromControl(this);

                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Bounds = screen.Bounds;

                isFullScreen = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = previousBorderStyle;
                this.Bounds = previousBounds;
                this.WindowState = previousWindowState;

                isFullScreen = false;
            }

            this.PerformLayout();
            PositionWindowButtons();
        }
        private void PositionWindowButtons()
        {
            int padding = 8;
            int spacing = 4;


            pictureBox3.Location = new Point(
                panel2.ClientSize.Width - pictureBox3.Width - padding,
                (panel2.ClientSize.Height - pictureBox3.Height) / 2);

            FullScreenButton.Location = new Point(
                pictureBox3.Left - FullScreenButton.Width - spacing,
                (panel2.ClientSize.Height - FullScreenButton.Height) / 2);

            pictureBox2.Location = new Point(
                FullScreenButton.Left - pictureBox2.Width - spacing,
                (panel2.ClientSize.Height - pictureBox2.Height) / 2);


            // Ensure the buttons are visible above other controls
            pictureBox2.BringToFront();
            FullScreenButton.BringToFront();
            pictureBox3.BringToFront();
        }
    }
}
