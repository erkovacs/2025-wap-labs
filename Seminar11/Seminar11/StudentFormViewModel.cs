using Seminar4.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Seminar4
{
    internal class StudentFormViewModel : INotifyPropertyChanged
    {
        private long _id;
        public long Id 
        {
            get { return _id; } 
            set {
                if (_id != value)
                    _id = value;
                OnPropertyChanged();
            } 
        }

        private string _name;
        public string Name 
        {
            get { return _name; }
            set
            {
                if (_name != value)
                    _name = value;
                OnPropertyChanged();
            }
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (_surname != value)
                    _surname = value;
                OnPropertyChanged();
            }
        }

        public string FullName
        {
            get => $"{Name} {Surname}";
        }

        private int _year;
        public int Year
        {
            get { return _year; }
            set
            {
                if (_year != value)
                    _year = value;
                OnPropertyChanged();
            }
        }

        public BindingList<Student> Students;

        public StudentFormViewModel() 
        {
            Students = new BindingList<Student>();
        }

        public void AddStudent (Student student)
        {
            Students.Add(student);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
