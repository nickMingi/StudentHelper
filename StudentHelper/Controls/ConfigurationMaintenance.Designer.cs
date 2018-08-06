namespace StudentHelper
{
    partial class ConfigurationMaintenance
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
            this.groupBoxUserConfiguration = new System.Windows.Forms.GroupBox();
            this.dataGridViewClasses = new System.Windows.Forms.DataGridView();
            this.Classes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxYearOfGrade = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxDegree = new System.Windows.Forms.TextBox();
            this.labelDegree = new System.Windows.Forms.Label();
            this.textBoxCollege = new System.Windows.Forms.TextBox();
            this.labelCollege = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonConfigurationSave = new System.Windows.Forms.Button();
            this.CollegeConfiguration = new System.Windows.Forms.GroupBox();
            this.textBoxGraduationCredits = new System.Windows.Forms.TextBox();
            this.labelGraduationCredits = new System.Windows.Forms.Label();
            this.textBoxCostCredits = new System.Windows.Forms.TextBox();
            this.dataGridViewMustTakeClassesConfig = new System.Windows.Forms.DataGridView();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCostPer3Credits = new System.Windows.Forms.Label();
            this.buttonDirectorySelect = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBoxUserConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasses)).BeginInit();
            this.CollegeConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMustTakeClassesConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUserConfiguration
            // 
            this.groupBoxUserConfiguration.Controls.Add(this.dataGridViewClasses);
            this.groupBoxUserConfiguration.Controls.Add(this.textBoxYearOfGrade);
            this.groupBoxUserConfiguration.Controls.Add(this.labelYear);
            this.groupBoxUserConfiguration.Controls.Add(this.textBoxDegree);
            this.groupBoxUserConfiguration.Controls.Add(this.labelDegree);
            this.groupBoxUserConfiguration.Controls.Add(this.textBoxCollege);
            this.groupBoxUserConfiguration.Controls.Add(this.labelCollege);
            this.groupBoxUserConfiguration.Controls.Add(this.textBoxUserName);
            this.groupBoxUserConfiguration.Controls.Add(this.labelUserName);
            this.groupBoxUserConfiguration.Location = new System.Drawing.Point(494, 3);
            this.groupBoxUserConfiguration.Name = "groupBoxUserConfiguration";
            this.groupBoxUserConfiguration.Size = new System.Drawing.Size(470, 641);
            this.groupBoxUserConfiguration.TabIndex = 0;
            this.groupBoxUserConfiguration.TabStop = false;
            this.groupBoxUserConfiguration.Text = "UserConfiguration";
            // 
            // dataGridViewClasses
            // 
            this.dataGridViewClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Classes,
            this.Grades});
            this.dataGridViewClasses.Location = new System.Drawing.Point(37, 154);
            this.dataGridViewClasses.Name = "dataGridViewClasses";
            this.dataGridViewClasses.Size = new System.Drawing.Size(241, 475);
            this.dataGridViewClasses.TabIndex = 9;
            // 
            // Classes
            // 
            this.Classes.HeaderText = "Classes";
            this.Classes.Name = "Classes";
            // 
            // Grades
            // 
            this.Grades.HeaderText = "Grades";
            this.Grades.Name = "Grades";
            // 
            // textBoxYearOfGrade
            // 
            this.textBoxYearOfGrade.Location = new System.Drawing.Point(133, 112);
            this.textBoxYearOfGrade.Name = "textBoxYearOfGrade";
            this.textBoxYearOfGrade.Size = new System.Drawing.Size(100, 20);
            this.textBoxYearOfGrade.TabIndex = 8;
            this.textBoxYearOfGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIntervale_KeyPress);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelYear.Location = new System.Drawing.Point(34, 112);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(101, 17);
            this.labelYear.TabIndex = 7;
            this.labelYear.Text = "Year Of Grade";
            // 
            // textBoxDegree
            // 
            this.textBoxDegree.Location = new System.Drawing.Point(342, 73);
            this.textBoxDegree.Name = "textBoxDegree";
            this.textBoxDegree.Size = new System.Drawing.Size(100, 20);
            this.textBoxDegree.TabIndex = 6;
            // 
            // labelDegree
            // 
            this.labelDegree.AutoSize = true;
            this.labelDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDegree.Location = new System.Drawing.Point(243, 73);
            this.labelDegree.Name = "labelDegree";
            this.labelDegree.Size = new System.Drawing.Size(55, 17);
            this.labelDegree.TabIndex = 5;
            this.labelDegree.Text = "Degree";
            // 
            // textBoxCollege
            // 
            this.textBoxCollege.Location = new System.Drawing.Point(133, 73);
            this.textBoxCollege.Name = "textBoxCollege";
            this.textBoxCollege.Size = new System.Drawing.Size(100, 20);
            this.textBoxCollege.TabIndex = 4;
            // 
            // labelCollege
            // 
            this.labelCollege.AutoSize = true;
            this.labelCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCollege.Location = new System.Drawing.Point(34, 73);
            this.labelCollege.Name = "labelCollege";
            this.labelCollege.Size = new System.Drawing.Size(55, 17);
            this.labelCollege.TabIndex = 3;
            this.labelCollege.Text = "College";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(133, 34);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserName.TabIndex = 2;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelUserName.Location = new System.Drawing.Point(34, 34);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(75, 17);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "UserName";
            // 
            // buttonConfigurationSave
            // 
            this.buttonConfigurationSave.Location = new System.Drawing.Point(889, 650);
            this.buttonConfigurationSave.Name = "buttonConfigurationSave";
            this.buttonConfigurationSave.Size = new System.Drawing.Size(75, 45);
            this.buttonConfigurationSave.TabIndex = 0;
            this.buttonConfigurationSave.Text = "SAVE";
            this.buttonConfigurationSave.UseVisualStyleBackColor = true;
            this.buttonConfigurationSave.Click += new System.EventHandler(this.buttonConfigurationSave_Click);
            // 
            // CollegeConfiguration
            // 
            this.CollegeConfiguration.Controls.Add(this.textBoxGraduationCredits);
            this.CollegeConfiguration.Controls.Add(this.labelGraduationCredits);
            this.CollegeConfiguration.Controls.Add(this.textBoxCostCredits);
            this.CollegeConfiguration.Controls.Add(this.dataGridViewMustTakeClassesConfig);
            this.CollegeConfiguration.Controls.Add(this.labelCostPer3Credits);
            this.CollegeConfiguration.Location = new System.Drawing.Point(3, 3);
            this.CollegeConfiguration.Name = "CollegeConfiguration";
            this.CollegeConfiguration.Size = new System.Drawing.Size(485, 326);
            this.CollegeConfiguration.TabIndex = 1;
            this.CollegeConfiguration.TabStop = false;
            this.CollegeConfiguration.Text = "CollegeConfiguration";
            // 
            // textBoxGraduationCredits
            // 
            this.textBoxGraduationCredits.Location = new System.Drawing.Point(142, 233);
            this.textBoxGraduationCredits.Name = "textBoxGraduationCredits";
            this.textBoxGraduationCredits.Size = new System.Drawing.Size(100, 20);
            this.textBoxGraduationCredits.TabIndex = 10;
            this.textBoxGraduationCredits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIntervale_KeyPress);
            // 
            // labelGraduationCredits
            // 
            this.labelGraduationCredits.AutoSize = true;
            this.labelGraduationCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelGraduationCredits.Location = new System.Drawing.Point(6, 236);
            this.labelGraduationCredits.Name = "labelGraduationCredits";
            this.labelGraduationCredits.Size = new System.Drawing.Size(127, 17);
            this.labelGraduationCredits.TabIndex = 9;
            this.labelGraduationCredits.Text = "Graduation Credits";
            // 
            // textBoxCostCredits
            // 
            this.textBoxCostCredits.Location = new System.Drawing.Point(142, 191);
            this.textBoxCostCredits.Name = "textBoxCostCredits";
            this.textBoxCostCredits.Size = new System.Drawing.Size(100, 20);
            this.textBoxCostCredits.TabIndex = 8;
            this.textBoxCostCredits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIntervale_KeyPress);
            // 
            // dataGridViewMustTakeClassesConfig
            // 
            this.dataGridViewMustTakeClassesConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMustTakeClassesConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Section,
            this.Class});
            this.dataGridViewMustTakeClassesConfig.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewMustTakeClassesConfig.Name = "dataGridViewMustTakeClassesConfig";
            this.dataGridViewMustTakeClassesConfig.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewMustTakeClassesConfig.TabIndex = 4;
            // 
            // Section
            // 
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            // 
            // Class
            // 
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            // 
            // labelCostPer3Credits
            // 
            this.labelCostPer3Credits.AutoSize = true;
            this.labelCostPer3Credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCostPer3Credits.Location = new System.Drawing.Point(6, 194);
            this.labelCostPer3Credits.Name = "labelCostPer3Credits";
            this.labelCostPer3Credits.Size = new System.Drawing.Size(130, 17);
            this.labelCostPer3Credits.TabIndex = 7;
            this.labelCostPer3Credits.Text = "Cost Per 3Credits $";
            // 
            // buttonDirectorySelect
            // 
            this.buttonDirectorySelect.Location = new System.Drawing.Point(808, 650);
            this.buttonDirectorySelect.Name = "buttonDirectorySelect";
            this.buttonDirectorySelect.Size = new System.Drawing.Size(75, 45);
            this.buttonDirectorySelect.TabIndex = 2;
            this.buttonDirectorySelect.Text = "Directory Selection";
            this.buttonDirectorySelect.UseVisualStyleBackColor = true;
            this.buttonDirectorySelect.Click += new System.EventHandler(this.buttonDirectorySelect_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(727, 650);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 45);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // ConfigurationMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDirectorySelect);
            this.Controls.Add(this.CollegeConfiguration);
            this.Controls.Add(this.groupBoxUserConfiguration);
            this.Controls.Add(this.buttonConfigurationSave);
            this.Name = "ConfigurationMaintenance";
            this.Size = new System.Drawing.Size(978, 716);
            this.groupBoxUserConfiguration.ResumeLayout(false);
            this.groupBoxUserConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasses)).EndInit();
            this.CollegeConfiguration.ResumeLayout(false);
            this.CollegeConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMustTakeClassesConfig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUserConfiguration;
        private System.Windows.Forms.Button buttonConfigurationSave;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxDegree;
        private System.Windows.Forms.Label labelDegree;
        private System.Windows.Forms.TextBox textBoxCollege;
        private System.Windows.Forms.Label labelCollege;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxYearOfGrade;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.DataGridView dataGridViewClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grades;
        private System.Windows.Forms.GroupBox CollegeConfiguration;
        private System.Windows.Forms.DataGridView dataGridViewMustTakeClassesConfig;
        private System.Windows.Forms.TextBox textBoxCostCredits;
        private System.Windows.Forms.Label labelCostPer3Credits;
        private System.Windows.Forms.TextBox textBoxGraduationCredits;
        private System.Windows.Forms.Label labelGraduationCredits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.Button buttonDirectorySelect;
        private System.Windows.Forms.Button buttonReset;
    }
}
