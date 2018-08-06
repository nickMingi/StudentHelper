namespace StudentHelper
{
    partial class Alarm
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
            this.groupBoxAlarmList = new System.Windows.Forms.GroupBox();
            this.dataGridViewAlarmList = new System.Windows.Forms.DataGridView();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alarms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.groupBoxAlarmList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlarmList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAlarmList
            // 
            this.groupBoxAlarmList.Controls.Add(this.dataGridViewAlarmList);
            this.groupBoxAlarmList.Location = new System.Drawing.Point(54, 89);
            this.groupBoxAlarmList.Name = "groupBoxAlarmList";
            this.groupBoxAlarmList.Size = new System.Drawing.Size(848, 584);
            this.groupBoxAlarmList.TabIndex = 1;
            this.groupBoxAlarmList.TabStop = false;
            this.groupBoxAlarmList.Text = "Alarm List";
            // 
            // dataGridViewAlarmList
            // 
            this.dataGridViewAlarmList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlarmList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Section,
            this.Alarms,
            this.Contents});
            this.dataGridViewAlarmList.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewAlarmList.Name = "dataGridViewAlarmList";
            this.dataGridViewAlarmList.Size = new System.Drawing.Size(836, 559);
            this.dataGridViewAlarmList.TabIndex = 5;
            // 
            // Section
            // 
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            // 
            // Alarms
            // 
            this.Alarms.FillWeight = 200F;
            this.Alarms.HeaderText = "Alarms";
            this.Alarms.Name = "Alarms";
            this.Alarms.Width = 200;
            // 
            // Contents
            // 
            this.Contents.FillWeight = 500F;
            this.Contents.HeaderText = "Contents";
            this.Contents.Name = "Contents";
            this.Contents.Width = 500;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(729, 17);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(173, 66);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "CONFIRM";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.groupBoxAlarmList);
            this.Name = "Alarm";
            this.Size = new System.Drawing.Size(978, 716);
            this.groupBoxAlarmList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlarmList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxAlarmList;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.DataGridView dataGridViewAlarmList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alarms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contents;
    }
}
