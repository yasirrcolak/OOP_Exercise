
namespace ObjectOrientedProgramming_Exercise.Forms
{
    partial class DetailsPage
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
            this.vehicleDetailListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // vehicleDetailListView
            // 
            this.vehicleDetailListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vehicleDetailListView.HideSelection = false;
            this.vehicleDetailListView.Location = new System.Drawing.Point(12, 12);
            this.vehicleDetailListView.Name = "vehicleDetailListView";
            this.vehicleDetailListView.Size = new System.Drawing.Size(890, 97);
            this.vehicleDetailListView.TabIndex = 0;
            this.vehicleDetailListView.UseCompatibleStateImageBehavior = false;
            // 
            // DetailsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(914, 121);
            this.Controls.Add(this.vehicleDetailListView);
            this.MaximizeBox = false;
            this.Name = "DetailsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detay Sayfası";
            this.Load += new System.EventHandler(this.DetailsPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView vehicleDetailListView;
    }
}