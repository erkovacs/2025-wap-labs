using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar4.Entities
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName {
            get => $"{Name} {Surname}";
        }
        public int Year { get; set; }
    }
}
