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
            ShearAngleLabel = new System.Windows.Forms.Label();
            SpeedComboBox = new System.Windows.Forms.ComboBox();
            SpeedLabel = new System.Windows.Forms.Label();
            CenterOffsetTextBox = new System.Windows.Forms.TextBox();
            CenterOffsetLabel = new System.Windows.Forms.Label();
            CSVPictureBox = new System.Windows.Forms.PictureBox();
            CSVdataGridView = new System.Windows.Forms.DataGridView();
            AlternateRadioButton = new System.Windows.Forms.RadioButton();
            WheelDiameterTextBox = new System.Windows.Forms.TextBox();
            WheelDiameterLabel = new System.Windows.Forms.Label();
            ReverseCheckBox = new System.Windows.Forms.CheckBox();
            DXFViewerPanel = new System.Windows.Forms.Panel();
            TypeComboBox = new System.Windows.Forms.ComboBox();
            MachiningTypeLabel = new System.Windows.Forms.Label();
            CAxisLabel = new System.Windows.Forms.Label();
            ThetaLabel = new System.Windows.Forms.Label();
            GrindingPositionComboBox = new System.Windows.Forms.ComboBox();
            GrindingStyleLabel = new System.Windows.Forms.Label();
            StyleComboBox = new System.Windows.Forms.ComboBox();
            StyleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)CSVPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CSVdataGridView).BeginInit();
            SuspendLayout();
            // 
            // BrowseButton
            // 
            BrowseButton.Location = new System.Drawing.Point(779, 227);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new System.Drawing.Size(75, 23);
            BrowseButton.TabIndex = 0;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = true;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // DXFPath
            // 
            DXFPath.Location = new System.Drawing.Point(142, 223);
            DXFPath.Name = "DXFPath";
            DXFPath.ReadOnly = true;
            DXFPath.Size = new System.Drawing.Size(631, 23);
            DXFPath.TabIndex = 1;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new System.Drawing.Point(438, 252);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new System.Drawing.Size(92, 37);
            CalculateButton.TabIndex = 3;
            CalculateButton.Text = "Export";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // DXFLabel
            // 
            DXFLabel.AutoSize = true;
            DXFLabel.Location = new System.Drawing.Point(108, 223);
            DXFLabel.Name = "DXFLabel";
            DXFLabel.Size = new System.Drawing.Size(28, 15);
            DXFLabel.TabIndex = 4;
            DXFLabel.Text = "DXF";
            // 
            // IncrementsTextBox
            // 
            IncrementsTextBox.Location = new System.Drawing.Point(177, 194);
            IncrementsTextBox.Name = "IncrementsTextBox";
            IncrementsTextBox.Size = new System.Drawing.Size(100, 23);
            IncrementsTextBox.TabIndex = 6;
            IncrementsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            IncrementsTextBox.Enter += IncrementsTextBox_Enter;
            // 
            // IncrementLabel
            // 
            IncrementLabel.AutoSize = true;
            IncrementLabel.Location = new System.Drawing.Point(177, 176);
            IncrementLabel.Name = "IncrementLabel";
            IncrementLabel.Size = new System.Drawing.Size(104, 15);
            IncrementLabel.TabIndex = 7;
            IncrementLabel.Text = "Radius Increments";
            // 
            // ShearAngleBox
            // 
            ShearAngleBox.Location = new System.Drawing.Point(524, 194);
            ShearAngleBox.Name = "ShearAngleBox";
            ShearAngleBox.Size = new System.Drawing.Size(100, 23);
            ShearAngleBox.TabIndex = 8;
            ShearAngleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            ShearAngleBox.Enter += CAxisTextBox_Enter;
            ShearAngleBox.Leave += CAxisTextBox_Leave;
            // 
            // ShearAngleLabel
            // 
            ShearAngleLabel.AutoSize = true;
            ShearAngleLabel.Location = new System.Drawing.Point(538, 176);
            ShearAngleLabel.Name = "ShearAngleLabel";
            ShearAngleLabel.Size = new System.Drawing.Size(70, 15);
            ShearAngleLabel.TabIndex = 9;
            ShearAngleLabel.Text = "Shear Angle";
            // 
            // SpeedComboBox
            // 
            SpeedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SpeedComboBox.FormattingEnabled = true;
            SpeedComboBox.Items.AddRange(new object[] { "V1", "V2", "V3", "V4" });
            SpeedComboBox.Location = new System.Drawing.Point(419, 194);
            SpeedComboBox.Name = "SpeedComboBox";
            SpeedComboBox.Size = new System.Drawing.Size(84, 23);
            SpeedComboBox.TabIndex = 10;
            SpeedComboBox.SelectedIndexChanged += SpeedComboBox_SelectedIndexChanged;
            // 
            // SpeedLabel
            // 
            SpeedLabel.AutoSize = true;
            SpeedLabel.Location = new System.Drawing.Point(419, 176);
            SpeedLabel.Name = "SpeedLabel";
            SpeedLabel.Size = new System.Drawing.Size(84, 15);
            SpeedLabel.TabIndex = 11;
            SpeedLabel.Text = "Speed Selector";
            // 
            // CenterOffsetTextBox
            // 
            CenterOffsetTextBox.Location = new System.Drawing.Point(302, 194);
            CenterOffsetTextBox.Name = "CenterOffsetTextBox";
            CenterOffsetTextBox.Size = new System.Drawing.Size(100, 23);
            CenterOffsetTextBox.TabIndex = 12;
            CenterOffsetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            CenterOffsetTextBox.Enter += CenterOffsetTextBox_Enter;
            CenterOffsetTextBox.Leave += CenterOffsetTextBox_Leave;
            // 
            // CenterOffsetLabel
            // 
            CenterOffsetLabel.AutoSize = true;
            CenterOffsetLabel.Location = new System.Drawing.Point(313, 176);
            CenterOffsetLabel.Name = "CenterOffsetLabel";
            CenterOffsetLabel.Size = new System.Drawing.Size(77, 15);
            CenterOffsetLabel.TabIndex = 13;
            CenterOffsetLabel.Text = "Center Offset";
            // 
            // CSVPictureBox
            // 
            CSVPictureBox.Image = (System.Drawing.Image)resources.GetObject("CSVPictureBox.Image");
            CSVPictureBox.Location = new System.Drawing.Point(279, 3);
            CSVPictureBox.Name = "CSVPictureBox";
            CSVPictureBox.Size = new System.Drawing.Size(377, 159);
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
            CSVdataGridView.Location = new System.Drawing.Point(0, 295);
            CSVdataGridView.Name = "CSVdataGridView";
            CSVdataGridView.ReadOnly = true;
            CSVdataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            CSVdataGridView.ShowEditingIcon = false;
            CSVdataGridView.Size = new System.Drawing.Size(946, 295);
            CSVdataGridView.TabIndex = 15;
            CSVdataGridView.RowPostPaint += CSVdataGridView_RowPostPaint;
            // 
            // AlternateRadioButton
            // 
            AlternateRadioButton.AutoSize = true;
            AlternateRadioButton.Location = new System.Drawing.Point(219, 261);
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
            WheelDiameterTextBox.Location = new System.Drawing.Point(638, 194);
            WheelDiameterTextBox.Name = "WheelDiameterTextBox";
            WheelDiameterTextBox.Size = new System.Drawing.Size(100, 23);
            WheelDiameterTextBox.TabIndex = 17;
            WheelDiameterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            WheelDiameterTextBox.Enter += WheelDiameterTextBox_Enter;
            WheelDiameterTextBox.Leave += WheelDiameterTextBox_Leave;
            // 
            // WheelDiameterLabel
            // 
            WheelDiameterLabel.AutoSize = true;
            WheelDiameterLabel.Location = new System.Drawing.Point(647, 176);
            WheelDiameterLabel.Name = "WheelDiameterLabel";
            WheelDiameterLabel.Size = new System.Drawing.Size(91, 15);
            WheelDiameterLabel.TabIndex = 18;
            WheelDiameterLabel.Text = "Wheel Diameter";
            // 
            // ReverseCheckBox
            // 
            ReverseCheckBox.AutoSize = true;
            ReverseCheckBox.Location = new System.Drawing.Point(597, 261);
            ReverseCheckBox.Name = "ReverseCheckBox";
            ReverseCheckBox.Size = new System.Drawing.Size(126, 19);
            ReverseCheckBox.TabIndex = 20;
            ReverseCheckBox.Text = "Reverse Processing";
            ReverseCheckBox.UseVisualStyleBackColor = true;
            ReverseCheckBox.Click += ReverseCheckBox_Click;
            // 
            // DXFViewerPanel
            // 
            DXFViewerPanel.BackColor = System.Drawing.Color.White;
            DXFViewerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DXFViewerPanel.Location = new System.Drawing.Point(0, 587);
            DXFViewerPanel.Name = "DXFViewerPanel";
            DXFViewerPanel.Size = new System.Drawing.Size(946, 178);
            DXFViewerPanel.TabIndex = 21;
            // 
            // TypeComboBox
            // 
            TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Normal Processing", "Pocketing" });
            TypeComboBox.Location = new System.Drawing.Point(61, 35);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new System.Drawing.Size(144, 23);
            TypeComboBox.TabIndex = 22;
            TypeComboBox.SelectedIndexChanged += TypeComboBox_SelectedIndexChanged;
            // 
            // MachiningTypeLabel
            // 
            MachiningTypeLabel.AutoSize = true;
            MachiningTypeLabel.Location = new System.Drawing.Point(83, 17);
            MachiningTypeLabel.Name = "MachiningTypeLabel";
            MachiningTypeLabel.Size = new System.Drawing.Size(92, 15);
            MachiningTypeLabel.TabIndex = 23;
            MachiningTypeLabel.Text = "Machining Type";
            // 
            // CAxisLabel
            // 
            CAxisLabel.AutoSize = true;
            CAxisLabel.Location = new System.Drawing.Point(532, 176);
            CAxisLabel.Name = "CAxisLabel";
            CAxisLabel.Size = new System.Drawing.Size(85, 15);
            CAxisLabel.TabIndex = 24;
            CAxisLabel.Text = "C Axis Position";
            // 
            // ThetaLabel
            // 
            ThetaLabel.AutoSize = true;
            ThetaLabel.Location = new System.Drawing.Point(677, 176);
            ThetaLabel.Name = "ThetaLabel";
            ThetaLabel.Size = new System.Drawing.Size(37, 15);
            ThetaLabel.TabIndex = 25;
            ThetaLabel.Text = "Theta";
            // 
            // GrindingPositionComboBox
            // 
            GrindingPositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            GrindingPositionComboBox.FormattingEnabled = true;
            GrindingPositionComboBox.Items.AddRange(new object[] { "9 O'Clock", "6 O'Clock", "3 O'Clock" });
            GrindingPositionComboBox.Location = new System.Drawing.Point(61, 79);
            GrindingPositionComboBox.Name = "GrindingPositionComboBox";
            GrindingPositionComboBox.Size = new System.Drawing.Size(144, 23);
            GrindingPositionComboBox.TabIndex = 26;
            GrindingPositionComboBox.SelectedIndexChanged += GrindingPositionComboBox_SelectedIndexChanged;
            // 
            // GrindingStyleLabel
            // 
            GrindingStyleLabel.AutoSize = true;
            GrindingStyleLabel.Location = new System.Drawing.Point(81, 61);
            GrindingStyleLabel.Name = "GrindingStyleLabel";
            GrindingStyleLabel.Size = new System.Drawing.Size(99, 15);
            GrindingStyleLabel.TabIndex = 27;
            GrindingStyleLabel.Text = "Grinding Position";
            // 
            // StyleComboBox
            // 
            StyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            StyleComboBox.FormattingEnabled = true;
            StyleComboBox.Items.AddRange(new object[] { "Face", "Periphery" });
            StyleComboBox.Location = new System.Drawing.Point(61, 123);
            StyleComboBox.Name = "StyleComboBox";
            StyleComboBox.Size = new System.Drawing.Size(144, 23);
            StyleComboBox.TabIndex = 28;
            StyleComboBox.SelectedIndexChanged += StyleComboBox_SelectedIndexChanged;
            // 
            // StyleLabel
            // 
            StyleLabel.AutoSize = true;
            StyleLabel.Location = new System.Drawing.Point(108, 105);
            StyleLabel.Name = "StyleLabel";
            StyleLabel.Size = new System.Drawing.Size(32, 15);
            StyleLabel.TabIndex = 29;
            StyleLabel.Text = "Style";
            // 
            // DXFtoCSV
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(StyleLabel);
            Controls.Add(StyleComboBox);
            Controls.Add(GrindingStyleLabel);
            Controls.Add(GrindingPositionComboBox);
            Controls.Add(ThetaLabel);
            Controls.Add(CAxisLabel);
            Controls.Add(MachiningTypeLabel);
            Controls.Add(TypeComboBox);
            Controls.Add(DXFViewerPanel);
            Controls.Add(ReverseCheckBox);
            Controls.Add(WheelDiameterLabel);
            Controls.Add(WheelDiameterTextBox);
            Controls.Add(AlternateRadioButton);
            Controls.Add(CSVdataGridView);
            Controls.Add(CSVPictureBox);
            Controls.Add(CenterOffsetLabel);
            Controls.Add(CenterOffsetTextBox);
            Controls.Add(SpeedLabel);
            Controls.Add(SpeedComboBox);
            Controls.Add(ShearAngleLabel);
            Controls.Add(ShearAngleBox);
            Controls.Add(IncrementLabel);
            Controls.Add(IncrementsTextBox);
            Controls.Add(DXFLabel);
            Controls.Add(CalculateButton);
            Controls.Add(DXFPath);
            Controls.Add(BrowseButton);
            Name = "DXFtoCSV";
            Size = new System.Drawing.Size(946, 765);
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
        private System.Windows.Forms.Label ShearAngleLabel;
        private System.Windows.Forms.ComboBox SpeedComboBox;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.TextBox CenterOffsetTextBox;
        private System.Windows.Forms.Label CenterOffsetLabel;
        private System.Windows.Forms.PictureBox CSVPictureBox;
        private System.Windows.Forms.DataGridView CSVdataGridView;
        private System.Windows.Forms.RadioButton AlternateRadioButton;
        private System.Windows.Forms.TextBox WheelDiameterTextBox;
        private System.Windows.Forms.Label WheelDiameterLabel;
        private System.Windows.Forms.CheckBox ReverseCheckBox;
        private System.Windows.Forms.Panel DXFViewerPanel;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label MachiningTypeLabel;
        private System.Windows.Forms.Label CAxisLabel;
        private System.Windows.Forms.Label ThetaLabel;
        private System.Windows.Forms.ComboBox GrindingPositionComboBox;
        private System.Windows.Forms.Label GrindingStyleLabel;
        private System.Windows.Forms.ComboBox StyleComboBox;
        private System.Windows.Forms.Label StyleLabel;
    }
}
