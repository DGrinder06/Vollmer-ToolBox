
namespace Vollmer_ToolBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new System.Windows.Forms.Panel();
            SidePanel = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            DXFtoCSVButton = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            panel3 = new System.Windows.Forms.Panel();
            CSV = new DXFtoCSV();
            RightTrianglePanel = new RightTriangle();
            dressingSpeedsCalculator1 = new DressingSpeedsCalculator();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(237, 237, 237);
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(DXFtoCSVButton);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(261, 797);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = System.Drawing.Color.FromArgb(237, 108, 5);
            SidePanel.Location = new System.Drawing.Point(0, 140);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new System.Drawing.Size(10, 44);
            SidePanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            button2.Location = new System.Drawing.Point(0, 190);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(261, 44);
            button2.TabIndex = 4;
            button2.Text = "Right Triangle Calculations";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            button1.Location = new System.Drawing.Point(0, 140);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(261, 44);
            button1.TabIndex = 3;
            button1.Text = "Dressing Speeds Calculator";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vollmer_werke_maschinenfabrik_gmbh_logo_logo;
            pictureBox1.Location = new System.Drawing.Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(249, 84);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // DXFtoCSVButton
            // 
            DXFtoCSVButton.FlatAppearance.BorderSize = 0;
            DXFtoCSVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DXFtoCSVButton.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            DXFtoCSVButton.Location = new System.Drawing.Point(0, 240);
            DXFtoCSVButton.Name = "DXFtoCSVButton";
            DXFtoCSVButton.Size = new System.Drawing.Size(261, 44);
            DXFtoCSVButton.TabIndex = 5;
            DXFtoCSVButton.Text = "CSV Calculator";
            DXFtoCSVButton.UseVisualStyleBackColor = true;
            DXFtoCSVButton.Click += DXFtoCSV_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(237, 108, 5);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox3);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(261, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(946, 36);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_minimize_window_24;
            pictureBox2.Location = new System.Drawing.Point(892, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(23, 24);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_close_window_24;
            pictureBox3.Location = new System.Drawing.Point(921, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(22, 23);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(CSV);
            panel3.Controls.Add(RightTrianglePanel);
            panel3.Controls.Add(dressingSpeedsCalculator1);
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(261, 32);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(946, 765);
            panel3.TabIndex = 3;
            // 
            // CSV
            // 
            CSV.Location = new System.Drawing.Point(0, -2);
            CSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            CSV.Name = "CSV";
            CSV.Size = new System.Drawing.Size(946, 765);
            CSV.TabIndex = 6;
            CSV.Load += CSV_Load;
            // 
            // RightTrianglePanel
            // 
            RightTrianglePanel.Location = new System.Drawing.Point(-3, -2);
            RightTrianglePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            RightTrianglePanel.Name = "RightTrianglePanel";
            RightTrianglePanel.Size = new System.Drawing.Size(946, 765);
            RightTrianglePanel.TabIndex = 2;
            RightTrianglePanel.Load += rightTriangle1_Load;
            // 
            // dressingSpeedsCalculator1
            // 
            dressingSpeedsCalculator1.Location = new System.Drawing.Point(0, -28);
            dressingSpeedsCalculator1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dressingSpeedsCalculator1.Name = "dressingSpeedsCalculator1";
            dressingSpeedsCalculator1.Size = new System.Drawing.Size(946, 765);
            dressingSpeedsCalculator1.TabIndex = 0;
            dressingSpeedsCalculator1.Load += dressingSpeedsCalculator1_Load_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1207, 797);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Gadugi", 9F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Vollmer Toolbox";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel SidePanel;
        private DressingSpeedsCalculator dressingSpeedsCalculator1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button DXFtoCSVButton;
        private RightTriangle RightTrianglePanel;
        private DXFtoCSV CSV;
    }
}

