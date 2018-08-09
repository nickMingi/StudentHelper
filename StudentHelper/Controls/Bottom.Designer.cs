namespace StudentHelper
{
    partial class Bottom
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
            this.buttonOperation = new System.Windows.Forms.Button();
            this.buttonConfiguration = new System.Windows.Forms.Button();
            this.buttonPlan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOperation
            // 
            this.buttonOperation.Location = new System.Drawing.Point(3, 1);
            this.buttonOperation.Name = "buttonOperation";
            this.buttonOperation.Size = new System.Drawing.Size(119, 100);
            this.buttonOperation.TabIndex = 1;
            this.buttonOperation.Text = "OPERATION";
            this.buttonOperation.UseVisualStyleBackColor = true;
            this.buttonOperation.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonConfiguration
            // 
            this.buttonConfiguration.Location = new System.Drawing.Point(128, 1);
            this.buttonConfiguration.Name = "buttonConfiguration";
            this.buttonConfiguration.Size = new System.Drawing.Size(119, 100);
            this.buttonConfiguration.TabIndex = 2;
            this.buttonConfiguration.Text = "CONFIGURATION";
            this.buttonConfiguration.UseVisualStyleBackColor = true;
            this.buttonConfiguration.Click += new System.EventHandler(this.buttonConfiguration_Click);
            // 
            // buttonPlan
            // 
            this.buttonPlan.Location = new System.Drawing.Point(253, 1);
            this.buttonPlan.Name = "buttonPlan";
            this.buttonPlan.Size = new System.Drawing.Size(119, 100);
            this.buttonPlan.TabIndex = 3;
            this.buttonPlan.Text = "PLAN";
            this.buttonPlan.UseVisualStyleBackColor = true;
            this.buttonPlan.Click += new System.EventHandler(this.buttonPlan_Click);
            // 
            // Bottom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.buttonPlan);
            this.Controls.Add(this.buttonConfiguration);
            this.Controls.Add(this.buttonOperation);
            this.Name = "Bottom";
            this.Size = new System.Drawing.Size(1085, 104);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOperation;
        private System.Windows.Forms.Button buttonConfiguration;
        private System.Windows.Forms.Button buttonPlan;
    }
}
