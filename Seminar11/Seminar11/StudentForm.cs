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

namespace Seminar4
{
    public partial class StudentForm : Form
    {
        private StudentFormViewModel _viewModel;
        private List<Student> Students;
        
        public StudentForm()
        {
            Students = new List<Student>();
            InitializeComponent();
        }

        private static int ConvertYearToInt(string year)
        {
            if (year.Equals("--None--") || year.Equals("0")) return 0;
            var parts = year.Split(' ');
            return int.Parse(parts[1]);
        }

        private static string ConvertYearToString(int year)
        {
            if (year == 0) return "--None--";
            return $"Year {year}";
        }

        private void ClearForm()
        {
            tbId.Clear();
            tbName.Clear();
            tbSurname.Clear();
            tbFullname.Clear();
            cbYear.ResetText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student()
                {
                    Id = _viewModel.Id,
                    Name = _viewModel.Name,
                    Surname = _viewModel.Surname,
                    Year = _viewModel.Year,
                };

                _viewModel.AddStudent(student);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            _viewModel = new StudentFormViewModel();
            dgvStudents.DataSource = _viewModel.Students;

            var idBinding = new Binding("Text", _viewModel, "Id");
            idBinding.Format += (s, args) => args.Value = ((int)args.Value).ToString();
            idBinding.Parse += (s, args) => args.Value = int.Parse((string)args.Value);

            tbId.DataBindings.Add("Text", _viewModel, "Id");
            tbName.DataBindings.Add("Text", _viewModel, "Name");
            tbSurname.DataBindings.Add("Text", _viewModel, "Surname");

            var yearBinding = new Binding("Text", _viewModel, "Year");
            yearBinding.Format += (s, args) => args.Value = ConvertYearToString((int)args.Value);
            yearBinding.Parse += (s, args) => args.Value = ConvertYearToInt((string)args.Value);

            cbYear.DataBindings.Add(yearBinding);
        }

        private void dgvStudents_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var student = dgvStudents.Rows[e.RowIndex].DataBoundItem as Student;
            _viewModel.Id = student.Id;
            _viewModel.Name = student.Name;
            _viewModel.Surname = student.Surname;
            _viewModel.Year = student.Year;
        }
    }
}
