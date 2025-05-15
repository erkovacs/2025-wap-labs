using Seminar4.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar4
{
    public partial class StudentForm : Form
    {
        private const string ConnectionString = "Data Source=database.db";
        private List<Student> Students;
        
        public StudentForm()
        {
            Students = new List<Student>();
            InitializeComponent();
        }

        public static int ConvertYearToInt(string year)
        {
            var parts = year.Split(' ');
            return int.Parse(parts[1]);
        }

        public static string ConvertYearToString(int year)
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

        private void SelectStudents()
        {
            var query = "select Id, Name, Surname, Year from Student;";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = (long)reader["Id"];
                        var name = (string)reader["Name"];
                        var surname = (string)reader["Surname"];
                        var year = (long)reader["Year"];

                        Students.Add(new Student()
                        {
                            Id = id,
                            Name = name,
                            Surname = surname,
                            Year = (int)year
                        });
                    }
                }
            }
        }

        private void InsertStudent(Student student) 
        {
            var query = "insert into Student(Name, Surname, Year)" +
                        " values(@name, @surname, @year);  " +
                        "SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                //1. Add the new participant to the database
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@name", student.Name);
                command.Parameters.AddWithValue("@surname", student.Surname);
                command.Parameters.AddWithValue("@year", student.Year);

                student.Id = (long)command.ExecuteScalar();
            }
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

                // Add student to DB
                InsertStudent(student);

                Students.Add(student);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClearForm();
            SelectStudents();
            DisplayStudents();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ClearForm();
            SelectStudents();
            DisplayStudents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvStudents.SelectedItems.Count == 0) return;
            var lvi = lvStudents.SelectedItems[0];
            var student = lvi.Tag as Student;

            Students.Remove(student);
            ClearForm();
            SelectStudents();
            DisplayStudents();
        }

        private void btnSortId_Click(object sender, EventArgs e)
        {
            SelectStudents();
            Students.Sort((a, b) => (int)(a.Id - b.Id));
            DisplayStudents();
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            SelectStudents();
            Students.Sort((a, b) => a.FullName.CompareTo(b.FullName));
            DisplayStudents();
        }

        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            Regex re = new Regex("^[0-9]*$");

            /**
             * var chars = tbId.Text.Split();
             * foreach (var char in chars)
             * {
             *    if (char not in [1, 2, 3, 4, 5, 6, 7, 8, 9)
             *    {
             *      return false
             *    }
             * }
             */

            /**
             * try
             * {
             *      long.Parse(tbId.Text);
             * }
             * catch (Exception e)
             * {
             *      set error
             * }
             */

            //if (string.IsNullOrEmpty(tbId.Text) || !re.IsMatch(tbId.Text))
            //{
            //    e.Cancel = true;
            //    formErrorProvider.SetError(tbId, "Value must be a number!");
            //}
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            var json = JsonSerializer.Serialize(Students);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "students.json";
            if (sfd.ShowDialog() == DialogResult.OK) 
            {
                using (StreamWriter sw = File.CreateText(sfd.FileName)) 
                {
                    sw.WriteLine(json.ToString());
                }
            }
        }

        private void jSONToolStripMenuItem1_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    var json = sr.ReadToEnd();
                    try 
                    {
                        Students = JsonSerializer.Deserialize<List<Student>>(json);
                        DisplayStudents();
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void lvStudents_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (lvStudents.SelectedItems.Count == 0) return;
            var lvi = lvStudents.SelectedItems[0];
            var student = lvi.Tag as Student;

            YearEditingForm dialog = new YearEditingForm(student);
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                SelectStudents();
                DisplayStudents();
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            SelectStudents();
            DisplayStudents();
        }
    }
}
