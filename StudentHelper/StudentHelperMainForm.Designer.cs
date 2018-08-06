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
            this.top1 = new StudentHelper.Top();
            this.side1 = new StudentHelper.Side();
            this.bottom1 = new StudentHelper.Bottom();
            this.maintenance1 = new StudentHelper.Maintenance();
            this.SuspendLayout();
            // 
            // top1
            // 
            this.top1.Location = new System.Drawing.Point(12, 12);
            this.top1.Name = "top1";
            this.top1.Size = new System.Drawing.Size(1085, 104);
            this.top1.TabIndex = 7;
            // 
            // side1
            // 
            this.side1.Location = new System.Drawing.Point(1103, 12);
            this.side1.Name = "side1";
            this.side1.Size = new System.Drawing.Size(125, 936);
            this.side1.TabIndex = 6;
            // 
            // bottom1
            // 
            this.bottom1.Location = new System.Drawing.Point(12, 844);
            this.bottom1.Name = "bottom1";
            this.bottom1.Size = new System.Drawing.Size(1085, 104);
            this.bottom1.TabIndex = 5;
            // 
            // maintenance1
            // 
            this.maintenance1.Location = new System.Drawing.Point(119, 122);
            this.maintenance1.Name = "maintenance1";
            this.maintenance1.Size = new System.Drawing.Size(978, 716);
            this.maintenance1.TabIndex = 8;
            // 
            // StudentHelperMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 960);
            this.Controls.Add(this.maintenance1);
            this.Controls.Add(this.top1);
            this.Controls.Add(this.side1);
            this.Controls.Add(this.bottom1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "StudentHelperMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qMainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private Bottom bottom1;
        private Side side1;
        private Top top1;
        private Maintenance maintenance1;
    }
}

