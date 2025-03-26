namespace Seminar4
{
    partial class StudentForm
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lvStudents = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(138, 46);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(341, 22);
            this.tbId.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(138, 89);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(341, 22);
            this.tbName.TabIndex = 1;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(138, 135);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(341, 22);
            this.tbSurname.TabIndex = 2;
            // 
            // tbFullname
            // 
            this.tbFullname.Location = new System.Drawing.Point(138, 184);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.ReadOnly = true;
            this.tbFullname.Size = new System.Drawing.Size(341, 22);
            this.tbFullname.TabIndex = 3;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "Year 1",
            "Year 2",
            "Year 3"});
            this.cbYear.Location = new System.Drawing.Point(138, 235);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(341, 24);
            this.cbYear.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Full name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Year";
            // 
            // lvStudents
            // 
            this.lvStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colFullname,
            this.colYear});
            this.lvStudents.HideSelection = false;
            this.lvStudents.Location = new System.Drawing.Point(51, 301);
            this.lvStudents.Name = "lvStudents";
            this.lvStudents.Size = new System.Drawing.Size(736, 203);
            this.lvStudents.TabIndex = 10;
            this.lvStudents.UseCompatibleStateImageBehavior = false;
            this.lvStudents.View = System.Windows.Forms.View.Details;
            this.lvStudents.DoubleClick += new System.EventHandler(this.lvStudents_DoubleClick);
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 144;
            // 
            // colFullname
            // 
            this.colFullname.Text = "Full name";
            this.colFullname.Width = 193;
            // 
            // colYear
            // 
            this.colYear.Text = "Year";
            this.colYear.Width = 389;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(650, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(650, 76);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 529);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvStudents);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.tbFullname);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Name = "StudentForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvStudents;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colFullname;
        private System.Windows.Forms.ColumnHeader colYear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
    }
}

