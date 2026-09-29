
namespace Vollmer_ToolBox
{
    partial class RightTriangle
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RightTriangle));
            radioButton1 = new System.Windows.Forms.RadioButton();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton3 = new System.Windows.Forms.RadioButton();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(58, 48);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(102, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tangent Angle";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(13, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(621, 364);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(286, 48);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(75, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Sin Angle";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(502, 48);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(79, 19);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "Cos Angle";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(401, 356);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(75, 23);
            textBox1.TabIndex = 7;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(199, 382);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new System.Drawing.Size(112, 23);
            textBox2.TabIndex = 9;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.Window;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(246, 358);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(21, 21);
            label2.TabIndex = 10;
            label2.Text = "A";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(26, 266);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new System.Drawing.Size(89, 23);
            textBox3.TabIndex = 11;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.Window;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(75, 242);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(20, 21);
            label3.TabIndex = 12;
            label3.Text = "B";
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(269, 242);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new System.Drawing.Size(112, 23);
            textBox4.TabIndex = 13;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.Window;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(319, 218);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(20, 21);
            label4.TabIndex = 14;
            label4.Text = "C";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.Window;
            label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            label1.Location = new System.Drawing.Point(482, 356);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(21, 30);
            label1.TabIndex = 8;
            label1.Text = "°";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(253, 443);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(128, 32);
            button1.TabIndex = 15;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(447, 443);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(134, 32);
            button2.TabIndex = 16;
            button2.Text = "Clear All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // RightTriangle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pictureBox1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "RightTriangle";
            Size = new System.Drawing.Size(652, 494);
            Load += RightTriangle_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
