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
        private List<Student> Students;
        
        public StudentForm()
        {
            Students = new List<Student>();
            InitializeComponent();
        }

        private static int ConvertYearToInt(string year)
        {
            var parts = year.Split(' ');
            return int.Parse(parts[1]);
        }

        private static string ConvertYearToString(int year)
        {
            return $"Year {year}";
        }

        private void DisplayStudents()
        {
            lvStudents.Items.Clear();

            foreach (var student in Students)
            {
                var lvi = new ListViewItem(student.Id.ToString());
                lvi.SubItems.Add(student.FullName);
                lvi.SubItems.Add(ConvertYearToString(student.Year));
                lvi.Tag = student;
                lvStudents.Items.Add(lvi);
            }
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
            var id = tbId.Text;
            var name = tbName.Text;
            var surname = tbSurname.Text;
            var year = cbYear.Text;

            try
            {
                var longId = long.Parse(id);
                var intYear = ConvertYearToInt(year);

                var student = new Student()
                {
                    Id = longId,
                    Name = name,
                    Surname = surname,
                    Year = intYear
                };

                Students.Add(student);
                ClearForm();
                DisplayStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvStudents_DoubleClick(object sender, EventArgs e)
        {
            if (lvStudents.SelectedItems.Count == 0) return;
            var lvi = lvStudents.SelectedItems[0];
            var student = lvi.Tag as Student;
            tbId.Text = student.Id.ToString();
            tbName.Text = student.Name;
            tbSurname.Text = student.Surname;
            tbFullname.Text = student.FullName;
            cbYear.Text = ConvertYearToString(student.Year);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvStudents.SelectedItems.Count == 0) return;
            var lvi = lvStudents.SelectedItems[0];
            var student = lvi.Tag as Student;

            try
            {
                student.Id = long.Parse(tbId.Text);
                student.Name = tbName.Text;
                student.Surname = tbSurname.Text;
                var intYear = ConvertYearToInt(cbYear.Text);
                student.Year = intYear;

                ClearForm();
                DisplayStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
