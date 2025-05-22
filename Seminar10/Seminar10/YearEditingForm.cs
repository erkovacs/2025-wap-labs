using Seminar4.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar4 {
    public partial class YearEditingForm : Form {
        private Student _student;
        public YearEditingForm() {
            InitializeComponent();
        }

        public YearEditingForm(Student student) : this() 
        {
            _student = student;
            PopulateForm();
        }

        private void PopulateForm() 
        {
            if (_student != null) 
            {
                tbFullname.Text = _student.FullName;
                tbName.Text = _student.Name;
                tbSurname.Text = _student.Surname;
                cbYear.Text = StudentForm.ConvertYearToString(_student.Year);
            }
        }

        private void btnOk_Click(object sender, EventArgs e) 
        {
            _student.Name = tbName.Text;
            _student.Surname = tbSurname.Text;
            _student.Year = StudentForm.ConvertYearToInt(cbYear.Text);
        }
    }
}
