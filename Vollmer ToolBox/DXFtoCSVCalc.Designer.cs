namespace Vollmer_ToolBox
{
    partial class DXFtoCSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DXFtoCSV));
            BrowseButton = new System.Windows.Forms.Button();
            DXFPath = new System.Windows.Forms.TextBox();
            CalculateButton = new System.Windows.Forms.Button();
            DXFLabel = new System.Windows.Forms.Label();
            IncrementsTextBox = new System.Windows.Forms.TextBox();
            IncrementLabel = new System.Windows.Forms.Label();
            ShearAngleBox = new System.Windows.Forms.TextBox();
            CAxisLabel = new System.Windows.Forms.Label();
            SpeedComboBox = new System.Windows.Forms.ComboBox();
            SpeedLabel = new System.Windows.Forms.Label();
            CenterOffsetTextBox = new System.Windows.Forms.TextBox();
            CenterOffset = new System.Windows.Forms.Label();
            CSVPictureBox = new System.Windows.Forms.PictureBox();
            CSVdataGridView = new System.Windows.Forms.DataGridView();
            AlternateRadioButton = new System.Windows.Forms.RadioButton();
            WheelDiameterTextBox = new System.Windows.Forms.TextBox();
            WheelDiameterLabel = new System.Windows.Forms.Label();
            ReverseRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)CSVPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CSVdataGridView).BeginInit();
            SuspendLayout();
            // 
            // BrowseButton
            // 
            BrowseButton.Location = new System.Drawing.Point(687, 260);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new System.Drawing.Size(75, 23);
            BrowseButton.TabIndex = 0;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = true;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // DXFPath
            // 
            DXFPath.Location = new System.Drawing.Point(50, 260);
            DXFPath.Name = "DXFPath";
            DXFPath.ReadOnly = true;
            DXFPath.Size = new System.Drawing.Size(631, 23);
            DXFPath.TabIndex = 1;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new System.Drawing.Point(311, 289);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new System.Drawing.Size(92, 51);
            CalculateButton.TabIndex = 3;
            CalculateButton.Text = "Export";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // DXFLabel
            // 
            DXFLabel.AutoSize = true;
            DXFLabel.Location = new System.Drawing.Point(16, 264);
            DXFLabel.Name = "DXFLabel";
            DXFLabel.Size = new System.Drawing.Size(28, 15);
            DXFLabel.TabIndex = 4;
            DXFLabel.Text = "DXF";
            // 
            // IncrementsTextBox
            // 
            IncrementsTextBox.Location = new System.Drawing.Point(71, 231);
            IncrementsTextBox.Name = "IncrementsTextBox";
            IncrementsTextBox.Size = new System.Drawing.Size(100, 23);
            IncrementsTextBox.TabIndex = 6;
            IncrementsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            IncrementsTextBox.Enter += IncrementsTextBox_Enter;
            IncrementsTextBox.KeyPress += IncrementsTextBox_KeyPress;
            // 
            // IncrementLabel
            // 
            IncrementLabel.AutoSize = true;
            IncrementLabel.Location = new System.Drawing.Point(67, 213);
            IncrementLabel.Name = "IncrementLabel";
            IncrementLabel.Size = new System.Drawing.Size(104, 15);
            IncrementLabel.TabIndex = 7;
            IncrementLabel.Text = "Radius Increments";
            // 
            // ShearAngleBox
            // 
            ShearAngleBox.Location = new System.Drawing.Point(192, 231);
            ShearAngleBox.Name = "ShearAngleBox";
            ShearAngleBox.Size = new System.Drawing.Size(100, 23);
            ShearAngleBox.TabIndex = 8;
            ShearAngleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            ShearAngleBox.Enter += CAxisTextBox_Enter;
            ShearAngleBox.KeyPress += CAxisTextBox_KeyPress;
            ShearAngleBox.Leave += CAxisTextBox_Leave;
            // 
            // CAxisLabel
            // 
            CAxisLabel.AutoSize = true;
            CAxisLabel.Location = new System.Drawing.Point(206, 213);
            CAxisLabel.Name = "CAxisLabel";
            CAxisLabel.Size = new System.Drawing.Size(70, 15);
            CAxisLabel.TabIndex = 9;
            CAxisLabel.Text = "Shear Angle";
            // 
            // SpeedComboBox
            // 
            SpeedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SpeedComboBox.FormattingEnabled = true;
            SpeedComboBox.Items.AddRange(new object[] { "EIL", "V1", "V2", "V3", "V4" });
            SpeedComboBox.Location = new System.Drawing.Point(319, 231);
            SpeedComboBox.Name = "SpeedComboBox";
            SpeedComboBox.Size = new System.Drawing.Size(84, 23);
            SpeedComboBox.TabIndex = 10;
            SpeedComboBox.SelectedIndexChanged += SpeedComboBox_SelectedIndexChanged;
            // 
            // SpeedLabel
            // 
            SpeedLabel.AutoSize = true;
            SpeedLabel.Location = new System.Drawing.Point(319, 213);
            SpeedLabel.Name = "SpeedLabel";
            SpeedLabel.Size = new System.Drawing.Size(84, 15);
            SpeedLabel.TabIndex = 11;
            SpeedLabel.Text = "Speed Selector";
            // 
            // CenterOffsetTextBox
            // 
            CenterOffsetTextBox.Location = new System.Drawing.Point(434, 231);
            CenterOffsetTextBox.Name = "CenterOffsetTextBox";
            CenterOffsetTextBox.Size = new System.Drawing.Size(100, 23);
            CenterOffsetTextBox.TabIndex = 12;
            CenterOffsetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            CenterOffsetTextBox.Enter += CenterOffsetTextBox_Enter;
            CenterOffsetTextBox.KeyPress += CenterOffsetTextBox_KeyPress;
            CenterOffsetTextBox.Leave += CenterOffsetTextBox_Leave;
            // 
            // CenterOffset
            // 
            CenterOffset.AutoSize = true;
            CenterOffset.Location = new System.Drawing.Point(447, 213);
            CenterOffset.Name = "CenterOffset";
            CenterOffset.Size = new System.Drawing.Size(77, 15);
            CenterOffset.TabIndex = 13;
            CenterOffset.Text = "Center Offset";
            // 
            // CSVPictureBox
            // 
            CSVPictureBox.Image = (System.Drawing.Image)resources.GetObject("CSVPictureBox.Image");
            CSVPictureBox.Location = new System.Drawing.Point(162, 3);
            CSVPictureBox.Name = "CSVPictureBox";
            CSVPictureBox.Size = new System.Drawing.Size(404, 207);
            CSVPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            CSVPictureBox.TabIndex = 14;
            CSVPictureBox.TabStop = false;
            // 
            // CSVdataGridView
            // 
            CSVdataGridView.AllowUserToAddRows = false;
            CSVdataGridView.AllowUserToDeleteRows = false;
            CSVdataGridView.AllowUserToResizeColumns = false;
            CSVdataGridView.AllowUserToResizeRows = false;
            CSVdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CSVdataGridView.Location = new System.Drawing.Point(0, 367);
            CSVdataGridView.Name = "CSVdataGridView";
            CSVdataGridView.ReadOnly = true;
            CSVdataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            CSVdataGridView.ShowEditingIcon = false;
            CSVdataGridView.Size = new System.Drawing.Size(782, 269);
            CSVdataGridView.TabIndex = 15;
            CSVdataGridView.RowPostPaint += CSVdataGridView_RowPostPaint;
            // 
            // AlternateRadioButton
            // 
            AlternateRadioButton.AutoSize = true;
            AlternateRadioButton.Location = new System.Drawing.Point(94, 305);
            AlternateRadioButton.Name = "AlternateRadioButton";
            AlternateRadioButton.Size = new System.Drawing.Size(168, 19);
            AlternateRadioButton.TabIndex = 16;
            AlternateRadioButton.TabStop = true;
            AlternateRadioButton.Text = "Alternate Grinding Position";
            AlternateRadioButton.UseVisualStyleBackColor = true;
            AlternateRadioButton.CheckedChanged += AlternateRadioButton_CheckedChanged;
            AlternateRadioButton.Click += AlternateRadioButton_Click;
            AlternateRadioButton.Leave += AlternateRadioButton_Leave;
            // 
            // WheelDiameterTextBox
            // 
            WheelDiameterTextBox.Location = new System.Drawing.Point(556, 231);
            WheelDiameterTextBox.Name = "WheelDiameterTextBox";
            WheelDiameterTextBox.Size = new System.Drawing.Size(100, 23);
            WheelDiameterTextBox.TabIndex = 17;
            WheelDiameterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            WheelDiameterTextBox.Enter += WheelDiameterTextBox_Enter;
            WheelDiameterTextBox.KeyPress += WheelDiameterTextBox_KeyPress;
            WheelDiameterTextBox.Leave += WheelDiameterTextBox_Leave;
            // 
            // WheelDiameterLabel
            // 
            WheelDiameterLabel.AutoSize = true;
            WheelDiameterLabel.Location = new System.Drawing.Point(565, 213);
            WheelDiameterLabel.Name = "WheelDiameterLabel";
            WheelDiameterLabel.Size = new System.Drawing.Size(91, 15);
            WheelDiameterLabel.TabIndex = 18;
            WheelDiameterLabel.Text = "Wheel Diameter";
            // 
            // ReverseRadioButton
            // 
            ReverseRadioButton.AutoSize = true;
            ReverseRadioButton.Location = new System.Drawing.Point(488, 305);
            ReverseRadioButton.Name = "ReverseRadioButton";
            ReverseRadioButton.Size = new System.Drawing.Size(125, 19);
            ReverseRadioButton.TabIndex = 19;
            ReverseRadioButton.TabStop = true;
            ReverseRadioButton.Text = "Reverse Processing";
            ReverseRadioButton.UseVisualStyleBackColor = true;
            ReverseRadioButton.Click += ReverseRadioButton_Click;
            // 
            // DXFtoCSV
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(ReverseRadioButton);
            Controls.Add(WheelDiameterLabel);
            Controls.Add(WheelDiameterTextBox);
            Controls.Add(AlternateRadioButton);
            Controls.Add(CSVdataGridView);
            Controls.Add(CSVPictureBox);
            Controls.Add(CenterOffset);
            Controls.Add(CenterOffsetTextBox);
            Controls.Add(SpeedLabel);
            Controls.Add(SpeedComboBox);
            Controls.Add(CAxisLabel);
            Controls.Add(ShearAngleBox);
            Controls.Add(IncrementLabel);
            Controls.Add(IncrementsTextBox);
            Controls.Add(DXFLabel);
            Controls.Add(CalculateButton);
            Controls.Add(DXFPath);
            Controls.Add(BrowseButton);
            Name = "DXFtoCSV";
            Size = new System.Drawing.Size(782, 636);
            ((System.ComponentModel.ISupportInitialize)CSVPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CSVdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox DXFPath;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label DXFLabel;
        private System.Windows.Forms.TextBox IncrementsTextBox;
        private System.Windows.Forms.Label IncrementLabel;
        private System.Windows.Forms.TextBox ShearAngleBox;
        private System.Windows.Forms.Label CAxisLabel;
        private System.Windows.Forms.ComboBox SpeedComboBox;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.TextBox CenterOffsetTextBox;
        private System.Windows.Forms.Label CenterOffset;
        private System.Windows.Forms.PictureBox CSVPictureBox;
        private System.Windows.Forms.DataGridView CSVdataGridView;
        private System.Windows.Forms.RadioButton AlternateRadioButton;
        private System.Windows.Forms.TextBox WheelDiameterTextBox;
        private System.Windows.Forms.Label WheelDiameterLabel;
        private System.Windows.Forms.RadioButton ReverseRadioButton;
    }
}
