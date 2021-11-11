
namespace ObjectOrientedProgramming_Exercise
{
    partial class AdminPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.vehicleNamesComboBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.newVehicleEnginePowerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.newVehiclePassengerCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newVehicleTypeComboBox = new System.Windows.Forms.ComboBox();
            this.newVehicleColorComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newVehicleVariableNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.newVehicleVariableLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.newVehicleNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.newVehicleEnginePowerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVehiclePassengerCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVehicleVariableNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.backButton.Location = new System.Drawing.Point(186, 598);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(210, 73);
            this.backButton.TabIndex = 26;
            this.backButton.Text = "Geri";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(102, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 32);
            this.label8.TabIndex = 102;
            this.label8.Text = "Araç Sınıfı Seçiniz:";
            // 
            // vehicleNamesComboBox
            // 
            this.vehicleNamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleNamesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vehicleNamesComboBox.FormattingEnabled = true;
            this.vehicleNamesComboBox.Location = new System.Drawing.Point(372, 34);
            this.vehicleNamesComboBox.Name = "vehicleNamesComboBox";
            this.vehicleNamesComboBox.Size = new System.Drawing.Size(336, 39);
            this.vehicleNamesComboBox.TabIndex = 101;
            this.vehicleNamesComboBox.SelectedIndexChanged += new System.EventHandler(this.memberNames_ComboBox_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(133, 147);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(200, 32);
            this.label18.TabIndex = 106;
            this.label18.Text = "Yeni Araç Adı:";
            // 
            // newVehicleEnginePowerNumericUpDown
            // 
            this.newVehicleEnginePowerNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newVehicleEnginePowerNumericUpDown.Location = new System.Drawing.Point(338, 196);
            this.newVehicleEnginePowerNumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.newVehicleEnginePowerNumericUpDown.Name = "newVehicleEnginePowerNumericUpDown";
            this.newVehicleEnginePowerNumericUpDown.Size = new System.Drawing.Size(338, 38);
            this.newVehicleEnginePowerNumericUpDown.TabIndex = 121;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(154, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(178, 32);
            this.label15.TabIndex = 120;
            this.label15.Text = "Motor Gücü:";
            // 
            // newVehiclePassengerCountNumericUpDown
            // 
            this.newVehiclePassengerCountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newVehiclePassengerCountNumericUpDown.Location = new System.Drawing.Point(338, 249);
            this.newVehiclePassengerCountNumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.newVehiclePassengerCountNumericUpDown.Name = "newVehiclePassengerCountNumericUpDown";
            this.newVehiclePassengerCountNumericUpDown.Size = new System.Drawing.Size(338, 38);
            this.newVehiclePassengerCountNumericUpDown.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(89, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 32);
            this.label1.TabIndex = 122;
            this.label1.Text = "Yolcu Kapasitesi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(188, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 124;
            this.label2.Text = "Araç Tipi:";
            // 
            // newVehicleTypeComboBox
            // 
            this.newVehicleTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newVehicleTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newVehicleTypeComboBox.FormattingEnabled = true;
            this.newVehicleTypeComboBox.Location = new System.Drawing.Point(338, 303);
            this.newVehicleTypeComboBox.Name = "newVehicleTypeComboBox";
            this.newVehicleTypeComboBox.Size = new System.Drawing.Size(338, 39);
            this.newVehicleTypeComboBox.TabIndex = 125;
            // 
            // newVehicleColorComboBox
            // 
            this.newVehicleColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newVehicleColorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newVehicleColorComboBox.FormattingEnabled = true;
            this.newVehicleColorComboBox.Location = new System.Drawing.Point(338, 357);
            this.newVehicleColorComboBox.Name = "newVehicleColorComboBox";
            this.newVehicleColorComboBox.Size = new System.Drawing.Size(338, 39);
            this.newVehicleColorComboBox.TabIndex = 127;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(162, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 32);
            this.label3.TabIndex = 126;
            this.label3.Text = "Araç Rengi:";
            // 
            // newVehicleVariableNumericUpDown
            // 
            this.newVehicleVariableNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newVehicleVariableNumericUpDown.Location = new System.Drawing.Point(338, 411);
            this.newVehicleVariableNumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.newVehicleVariableNumericUpDown.Name = "newVehicleVariableNumericUpDown";
            this.newVehicleVariableNumericUpDown.Size = new System.Drawing.Size(338, 38);
            this.newVehicleVariableNumericUpDown.TabIndex = 129;
            // 
            // newVehicleVariableLabel
            // 
            this.newVehicleVariableLabel.AutoSize = true;
            this.newVehicleVariableLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newVehicleVariableLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newVehicleVariableLabel.Location = new System.Drawing.Point(154, 411);
            this.newVehicleVariableLabel.Name = "newVehicleVariableLabel";
            this.newVehicleVariableLabel.Size = new System.Drawing.Size(0, 32);
            this.newVehicleVariableLabel.TabIndex = 128;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.saveButton.Location = new System.Drawing.Point(418, 598);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(210, 73);
            this.saveButton.TabIndex = 130;
            this.saveButton.Text = "Kaydet";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newVehicleNameTextBox
            // 
            this.newVehicleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newVehicleNameTextBox.Location = new System.Drawing.Point(338, 143);
            this.newVehicleNameTextBox.Name = "newVehicleNameTextBox";
            this.newVehicleNameTextBox.Size = new System.Drawing.Size(338, 38);
            this.newVehicleNameTextBox.TabIndex = 131;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(800, 683);
            this.Controls.Add(this.newVehicleNameTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newVehicleVariableNumericUpDown);
            this.Controls.Add(this.newVehicleVariableLabel);
            this.Controls.Add(this.newVehicleColorComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newVehicleTypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newVehiclePassengerCountNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newVehicleEnginePowerNumericUpDown);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vehicleNamesComboBox);
            this.Controls.Add(this.backButton);
            this.MaximizeBox = false;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Page";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newVehicleEnginePowerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVehiclePassengerCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVehicleVariableNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox vehicleNamesComboBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown newVehicleEnginePowerNumericUpDown;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown newVehiclePassengerCountNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox newVehicleTypeComboBox;
        private System.Windows.Forms.ComboBox newVehicleColorComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown newVehicleVariableNumericUpDown;
        private System.Windows.Forms.Label newVehicleVariableLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox newVehicleNameTextBox;
    }
}