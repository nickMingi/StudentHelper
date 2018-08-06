namespace StudentHelper
{
    partial class Maintenance
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
            this.groupBoxResultBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBoxResultBox
            // 
            this.groupBoxResultBox.Location = new System.Drawing.Point(3, 3);
            this.groupBoxResultBox.Name = "groupBoxResultBox";
            this.groupBoxResultBox.Size = new System.Drawing.Size(419, 710);
            this.groupBoxResultBox.TabIndex = 0;
            this.groupBoxResultBox.TabStop = false;
            this.groupBoxResultBox.Text = "ResultBox";
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.groupBoxResultBox);
            this.Name = "Maintenance";
            this.Size = new System.Drawing.Size(978, 716);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResultBox;
    }
}
