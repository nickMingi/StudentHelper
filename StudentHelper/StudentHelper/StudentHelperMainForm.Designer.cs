namespace StudentHelper
{
    partial class StudentHelperMainForm
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
            this.groupBoxMainControl = new System.Windows.Forms.GroupBox();
            this.groupBoxBottomControl = new System.Windows.Forms.GroupBox();
            this.groupBoxTopControl = new System.Windows.Forms.GroupBox();
            this.groupBoxSideControl = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBoxMainControl
            // 
            this.groupBoxMainControl.Location = new System.Drawing.Point(119, 122);
            this.groupBoxMainControl.Name = "groupBoxMainControl";
            this.groupBoxMainControl.Size = new System.Drawing.Size(978, 716);
            this.groupBoxMainControl.TabIndex = 10;
            this.groupBoxMainControl.TabStop = false;
            this.groupBoxMainControl.Text = "groupBox1";
            // 
            // groupBoxBottomControl
            // 
            this.groupBoxBottomControl.Location = new System.Drawing.Point(12, 844);
            this.groupBoxBottomControl.Name = "groupBoxBottomControl";
            this.groupBoxBottomControl.Size = new System.Drawing.Size(1085, 104);
            this.groupBoxBottomControl.TabIndex = 15;
            this.groupBoxBottomControl.TabStop = false;
            this.groupBoxBottomControl.Text = "groupBox2";
            // 
            // groupBoxTopControl
            // 
            this.groupBoxTopControl.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTopControl.Name = "groupBoxTopControl";
            this.groupBoxTopControl.Size = new System.Drawing.Size(1085, 104);
            this.groupBoxTopControl.TabIndex = 16;
            this.groupBoxTopControl.TabStop = false;
            this.groupBoxTopControl.Text = "groupBox2";
            // 
            // groupBoxSideControl
            // 
            this.groupBoxSideControl.Location = new System.Drawing.Point(1103, 12);
            this.groupBoxSideControl.Name = "groupBoxSideControl";
            this.groupBoxSideControl.Size = new System.Drawing.Size(125, 936);
            this.groupBoxSideControl.TabIndex = 17;
            this.groupBoxSideControl.TabStop = false;
            this.groupBoxSideControl.Text = "groupBox2";
            // 
            // StudentHelperMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 960);
            this.Controls.Add(this.groupBoxSideControl);
            this.Controls.Add(this.groupBoxTopControl);
            this.Controls.Add(this.groupBoxBottomControl);
            this.Controls.Add(this.groupBoxMainControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "StudentHelperMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qMainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxMainControl;
        private System.Windows.Forms.GroupBox groupBoxBottomControl;
        private System.Windows.Forms.GroupBox groupBoxTopControl;
        private System.Windows.Forms.GroupBox groupBoxSideControl;
    }
}

