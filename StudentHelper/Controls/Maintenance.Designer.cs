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
            this.textBoxGraduationGrade = new System.Windows.Forms.TextBox();
            this.labelGraduationGrade = new System.Windows.Forms.Label();
            this.textBoxRemainingCost = new System.Windows.Forms.TextBox();
            this.labelRemainingCost = new System.Windows.Forms.Label();
            this.labelMustTakeClasses = new System.Windows.Forms.Label();
            this.dataGridViewMustTakeDisplay = new System.Windows.Forms.DataGridView();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxRemainingCredit = new System.Windows.Forms.TextBox();
            this.labelRemainingCredit = new System.Windows.Forms.Label();
            this.buttonSaveCSV = new System.Windows.Forms.Button();
            this.labelUserNameDisplay = new System.Windows.Forms.Label();
            this.labelUserNameDisplayTwo = new System.Windows.Forms.Label();
            this.labelCollegeDisplay = new System.Windows.Forms.Label();
            this.labelDegreeDisplay = new System.Windows.Forms.Label();
            this.labelYearOfGradeDisplay = new System.Windows.Forms.Label();
            this.labelNumberOfClassesDisplay = new System.Windows.Forms.Label();
            this.labelAverageGradeDisplay = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.comboBoxUserList = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelUserInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxResultBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMustTakeDisplay)).BeginInit();
            this.tableLayoutPanelUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxResultBox
            // 
            this.groupBoxResultBox.Controls.Add(this.textBoxGraduationGrade);
            this.groupBoxResultBox.Controls.Add(this.labelGraduationGrade);
            this.groupBoxResultBox.Controls.Add(this.textBoxRemainingCost);
            this.groupBoxResultBox.Controls.Add(this.labelRemainingCost);
            this.groupBoxResultBox.Controls.Add(this.labelMustTakeClasses);
            this.groupBoxResultBox.Controls.Add(this.dataGridViewMustTakeDisplay);
            this.groupBoxResultBox.Controls.Add(this.textBoxRemainingCredit);
            this.groupBoxResultBox.Controls.Add(this.labelRemainingCredit);
            this.groupBoxResultBox.Controls.Add(this.buttonSaveCSV);
            this.groupBoxResultBox.Location = new System.Drawing.Point(3, 3);
            this.groupBoxResultBox.Name = "groupBoxResultBox";
            this.groupBoxResultBox.Size = new System.Drawing.Size(419, 710);
            this.groupBoxResultBox.TabIndex = 0;
            this.groupBoxResultBox.TabStop = false;
            this.groupBoxResultBox.Text = "ResultBox";
            // 
            // textBoxGraduationGrade
            // 
            this.textBoxGraduationGrade.Enabled = false;
            this.textBoxGraduationGrade.Location = new System.Drawing.Point(155, 408);
            this.textBoxGraduationGrade.Name = "textBoxGraduationGrade";
            this.textBoxGraduationGrade.Size = new System.Drawing.Size(100, 20);
            this.textBoxGraduationGrade.TabIndex = 8;
            // 
            // labelGraduationGrade
            // 
            this.labelGraduationGrade.AutoSize = true;
            this.labelGraduationGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelGraduationGrade.Location = new System.Drawing.Point(19, 411);
            this.labelGraduationGrade.Name = "labelGraduationGrade";
            this.labelGraduationGrade.Size = new System.Drawing.Size(130, 17);
            this.labelGraduationGrade.TabIndex = 7;
            this.labelGraduationGrade.Text = "Grad Grade Expect";
            // 
            // textBoxRemainingCost
            // 
            this.textBoxRemainingCost.Enabled = false;
            this.textBoxRemainingCost.Location = new System.Drawing.Point(155, 345);
            this.textBoxRemainingCost.Name = "textBoxRemainingCost";
            this.textBoxRemainingCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxRemainingCost.TabIndex = 6;
            // 
            // labelRemainingCost
            // 
            this.labelRemainingCost.AutoSize = true;
            this.labelRemainingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelRemainingCost.Location = new System.Drawing.Point(19, 348);
            this.labelRemainingCost.Name = "labelRemainingCost";
            this.labelRemainingCost.Size = new System.Drawing.Size(139, 17);
            this.labelRemainingCost.TabIndex = 5;
            this.labelRemainingCost.Text = "Remaining Cost      $";
            // 
            // labelMustTakeClasses
            // 
            this.labelMustTakeClasses.AutoSize = true;
            this.labelMustTakeClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMustTakeClasses.ForeColor = System.Drawing.Color.DarkRed;
            this.labelMustTakeClasses.Location = new System.Drawing.Point(22, 119);
            this.labelMustTakeClasses.Name = "labelMustTakeClasses";
            this.labelMustTakeClasses.Size = new System.Drawing.Size(127, 17);
            this.labelMustTakeClasses.TabIndex = 4;
            this.labelMustTakeClasses.Text = "Must Take Classes";
            // 
            // dataGridViewMustTakeDisplay
            // 
            this.dataGridViewMustTakeDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMustTakeDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Section,
            this.Class});
            this.dataGridViewMustTakeDisplay.Location = new System.Drawing.Point(22, 152);
            this.dataGridViewMustTakeDisplay.Name = "dataGridViewMustTakeDisplay";
            this.dataGridViewMustTakeDisplay.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewMustTakeDisplay.TabIndex = 3;
            // 
            // Section
            // 
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            // 
            // Class
            // 
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            // 
            // textBoxRemainingCredit
            // 
            this.textBoxRemainingCredit.Enabled = false;
            this.textBoxRemainingCredit.Location = new System.Drawing.Point(155, 73);
            this.textBoxRemainingCredit.Name = "textBoxRemainingCredit";
            this.textBoxRemainingCredit.Size = new System.Drawing.Size(100, 20);
            this.textBoxRemainingCredit.TabIndex = 2;
            // 
            // labelRemainingCredit
            // 
            this.labelRemainingCredit.AutoSize = true;
            this.labelRemainingCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelRemainingCredit.Location = new System.Drawing.Point(19, 76);
            this.labelRemainingCredit.Name = "labelRemainingCredit";
            this.labelRemainingCredit.Size = new System.Drawing.Size(116, 17);
            this.labelRemainingCredit.TabIndex = 1;
            this.labelRemainingCredit.Text = "Remaining Credit";
            // 
            // buttonSaveCSV
            // 
            this.buttonSaveCSV.Location = new System.Drawing.Point(291, 641);
            this.buttonSaveCSV.Name = "buttonSaveCSV";
            this.buttonSaveCSV.Size = new System.Drawing.Size(111, 54);
            this.buttonSaveCSV.TabIndex = 0;
            this.buttonSaveCSV.Text = "Save CSV";
            this.buttonSaveCSV.UseVisualStyleBackColor = true;
            this.buttonSaveCSV.Click += new System.EventHandler(this.buttonSaveCSV_Click);
            // 
            // labelUserNameDisplay
            // 
            this.labelUserNameDisplay.AutoSize = true;
            this.labelUserNameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelUserNameDisplay.Location = new System.Drawing.Point(797, 32);
            this.labelUserNameDisplay.Name = "labelUserNameDisplay";
            this.labelUserNameDisplay.Size = new System.Drawing.Size(145, 20);
            this.labelUserNameDisplay.TabIndex = 1;
            this.labelUserNameDisplay.Text = "UserNameDisplay";
            // 
            // labelUserNameDisplayTwo
            // 
            this.labelUserNameDisplayTwo.AutoSize = true;
            this.labelUserNameDisplayTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelUserNameDisplayTwo.Location = new System.Drawing.Point(183, 0);
            this.labelUserNameDisplayTwo.Name = "labelUserNameDisplayTwo";
            this.labelUserNameDisplayTwo.Size = new System.Drawing.Size(121, 17);
            this.labelUserNameDisplayTwo.TabIndex = 2;
            this.labelUserNameDisplayTwo.Text = "UserNameDisplay";
            // 
            // labelCollegeDisplay
            // 
            this.labelCollegeDisplay.AutoSize = true;
            this.labelCollegeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCollegeDisplay.Location = new System.Drawing.Point(183, 31);
            this.labelCollegeDisplay.Name = "labelCollegeDisplay";
            this.labelCollegeDisplay.Size = new System.Drawing.Size(101, 17);
            this.labelCollegeDisplay.TabIndex = 3;
            this.labelCollegeDisplay.Text = "CollegeDisplay";
            // 
            // labelDegreeDisplay
            // 
            this.labelDegreeDisplay.AutoSize = true;
            this.labelDegreeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDegreeDisplay.Location = new System.Drawing.Point(183, 63);
            this.labelDegreeDisplay.Name = "labelDegreeDisplay";
            this.labelDegreeDisplay.Size = new System.Drawing.Size(101, 17);
            this.labelDegreeDisplay.TabIndex = 4;
            this.labelDegreeDisplay.Text = "DegreeDisplay";
            // 
            // labelYearOfGradeDisplay
            // 
            this.labelYearOfGradeDisplay.AutoSize = true;
            this.labelYearOfGradeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelYearOfGradeDisplay.Location = new System.Drawing.Point(183, 97);
            this.labelYearOfGradeDisplay.Name = "labelYearOfGradeDisplay";
            this.labelYearOfGradeDisplay.Size = new System.Drawing.Size(139, 17);
            this.labelYearOfGradeDisplay.TabIndex = 5;
            this.labelYearOfGradeDisplay.Text = "YearOfGradeDisplay";
            // 
            // labelNumberOfClassesDisplay
            // 
            this.labelNumberOfClassesDisplay.AutoSize = true;
            this.labelNumberOfClassesDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelNumberOfClassesDisplay.Location = new System.Drawing.Point(183, 134);
            this.labelNumberOfClassesDisplay.Name = "labelNumberOfClassesDisplay";
            this.labelNumberOfClassesDisplay.Size = new System.Drawing.Size(168, 17);
            this.labelNumberOfClassesDisplay.TabIndex = 6;
            this.labelNumberOfClassesDisplay.Text = "NumberOfClassesDisplay";
            // 
            // labelAverageGradeDisplay
            // 
            this.labelAverageGradeDisplay.AutoSize = true;
            this.labelAverageGradeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelAverageGradeDisplay.Location = new System.Drawing.Point(183, 171);
            this.labelAverageGradeDisplay.Name = "labelAverageGradeDisplay";
            this.labelAverageGradeDisplay.Size = new System.Drawing.Size(147, 17);
            this.labelAverageGradeDisplay.TabIndex = 7;
            this.labelAverageGradeDisplay.Text = "AverageGradeDisplay";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(880, 644);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(84, 54);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // comboBoxUserList
            // 
            this.comboBoxUserList.FormattingEnabled = true;
            this.comboBoxUserList.Location = new System.Drawing.Point(723, 644);
            this.comboBoxUserList.Name = "comboBoxUserList";
            this.comboBoxUserList.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUserList.TabIndex = 9;
            // 
            // tableLayoutPanelUserInfo
            // 
            this.tableLayoutPanelUserInfo.ColumnCount = 2;
            this.tableLayoutPanelUserInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUserInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUserInfo.Controls.Add(this.labelUserNameDisplayTwo, 1, 0);
            this.tableLayoutPanelUserInfo.Controls.Add(this.labelCollegeDisplay, 1, 1);
            this.tableLayoutPanelUserInfo.Controls.Add(this.labelDegreeDisplay, 1, 2);
            this.tableLayoutPanelUserInfo.Controls.Add(this.labelAverageGradeDisplay, 1, 5);
            this.tableLayoutPanelUserInfo.Controls.Add(this.labelYearOfGradeDisplay, 1, 3);
            this.tableLayoutPanelUserInfo.Controls.Add(this.labelNumberOfClassesDisplay, 1, 4);
            this.tableLayoutPanelUserInfo.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelUserInfo.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelUserInfo.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanelUserInfo.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanelUserInfo.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanelUserInfo.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanelUserInfo.Location = new System.Drawing.Point(581, 79);
            this.tableLayoutPanelUserInfo.Name = "tableLayoutPanelUserInfo";
            this.tableLayoutPanelUserInfo.RowCount = 6;
            this.tableLayoutPanelUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.51456F));
            this.tableLayoutPanelUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.48544F));
            this.tableLayoutPanelUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanelUserInfo.Size = new System.Drawing.Size(361, 208);
            this.tableLayoutPanelUserInfo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "College";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Degree";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "YearOfGrade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number Of Classes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Average Grade";
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.tableLayoutPanelUserInfo);
            this.Controls.Add(this.comboBoxUserList);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelUserNameDisplay);
            this.Controls.Add(this.groupBoxResultBox);
            this.Name = "Maintenance";
            this.Size = new System.Drawing.Size(978, 716);
            this.groupBoxResultBox.ResumeLayout(false);
            this.groupBoxResultBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMustTakeDisplay)).EndInit();
            this.tableLayoutPanelUserInfo.ResumeLayout(false);
            this.tableLayoutPanelUserInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResultBox;
        private System.Windows.Forms.Button buttonSaveCSV;
        private System.Windows.Forms.Label labelUserNameDisplay;
        private System.Windows.Forms.Label labelUserNameDisplayTwo;
        private System.Windows.Forms.Label labelCollegeDisplay;
        private System.Windows.Forms.Label labelDegreeDisplay;
        private System.Windows.Forms.Label labelYearOfGradeDisplay;
        private System.Windows.Forms.Label labelNumberOfClassesDisplay;
        private System.Windows.Forms.Label labelAverageGradeDisplay;
        private System.Windows.Forms.TextBox textBoxRemainingCredit;
        private System.Windows.Forms.Label labelRemainingCredit;
        private System.Windows.Forms.Label labelMustTakeClasses;
        private System.Windows.Forms.DataGridView dataGridViewMustTakeDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.TextBox textBoxRemainingCost;
        private System.Windows.Forms.Label labelRemainingCost;
        private System.Windows.Forms.TextBox textBoxGraduationGrade;
        private System.Windows.Forms.Label labelGraduationGrade;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ComboBox comboBoxUserList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUserInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
