
namespace ObjectOrientedProgramming_Exercise
{
    partial class UserPage
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
            this.vehicleNamesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vehiclesListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.backButton.Location = new System.Drawing.Point(287, 365);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(210, 73);
            this.backButton.TabIndex = 27;
            this.backButton.Text = "Geri";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // vehicleNamesComboBox
            // 
            this.vehicleNamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleNamesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vehicleNamesComboBox.FormattingEnabled = true;
            this.vehicleNamesComboBox.Location = new System.Drawing.Point(452, 30);
            this.vehicleNamesComboBox.Name = "vehicleNamesComboBox";
            this.vehicleNamesComboBox.Size = new System.Drawing.Size(336, 39);
            this.vehicleNamesComboBox.TabIndex = 103;
            this.vehicleNamesComboBox.SelectedIndexChanged += new System.EventHandler(this.vehiclesComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(307, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 102;
            this.label1.Text = "Araç Tipi:";
            // 
            // vehiclesListView
            // 
            this.vehiclesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vehiclesListView.HideSelection = false;
            this.vehiclesListView.Location = new System.Drawing.Point(12, 95);
            this.vehiclesListView.Name = "vehiclesListView";
            this.vehiclesListView.Size = new System.Drawing.Size(776, 253);
            this.vehiclesListView.TabIndex = 101;
            this.vehiclesListView.UseCompatibleStateImageBehavior = false;
            this.vehiclesListView.DoubleClick += new System.EventHandler(this.vehiclesListView_DoubleClick);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vehicleNamesComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehiclesListView);
            this.Controls.Add(this.backButton);
            this.MaximizeBox = false;
            this.Name = "UserPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Page";
            this.Load += new System.EventHandler(this.UserPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox vehicleNamesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView vehiclesListView;
    }
}