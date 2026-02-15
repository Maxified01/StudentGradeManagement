namespace StudentGradeManagementSystem
{
    partial class Mainform
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnHighLow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(20, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Student Name :";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(39, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(246, 54);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Students";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(406, 26);
            this.txtName.TabIndex = 2;
            // 
            // lstStudents
            // 
            this.lstStudents.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 26;
            this.lstStudents.Location = new System.Drawing.Point(690, 270);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(441, 342);
            this.lstStudents.TabIndex = 3;
            // 
            // lblGrade
            // 
            this.lblGrade.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lblGrade.Location = new System.Drawing.Point(20, 86);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(150, 25);
            this.lblGrade.TabIndex = 4;
            this.lblGrade.Text = "Grade :";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(103, 85);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(406, 26);
            this.txtGrade.TabIndex = 5;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDisplay.Location = new System.Drawing.Point(335, 272);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(239, 54);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "Display Students";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAverage.Location = new System.Drawing.Point(242, 408);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(211, 52);
            this.btnAverage.TabIndex = 7;
            this.btnAverage.Text = "Calculate Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(12, 408);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(196, 52);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search Student";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnHighLow
            // 
            this.btnHighLow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnHighLow.Location = new System.Drawing.Point(481, 408);
            this.btnHighLow.Name = "btnHighLow";
            this.btnHighLow.Size = new System.Drawing.Size(203, 52);
            this.btnHighLow.TabIndex = 9;
            this.btnHighLow.Text = "Highest & Lowest";
            this.btnHighLow.UseVisualStyleBackColor = true;
            this.btnHighLow.Click += new System.EventHandler(this.btnHighLow_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 611);
            this.Controls.Add(this.btnHighLow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblName);
            this.Name = "Mainform";
            this.Text = "Student Grade Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnHighLow;
        private System.Windows.Forms.TextBox txtName;
    }
}