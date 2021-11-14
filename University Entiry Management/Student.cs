using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Entiry_Management
{
    class Student
    {
        private string Name { get; set; }
        private int Year { get; set; }

        private Student(string name, int year)
        {
            this.Name = name;
            this.Year = year;
        }

    }
}
