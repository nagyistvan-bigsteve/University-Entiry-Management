using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Entiry_Management
{

 class Student : BaseEntity
        {
            private string _name, _year;

            public Student(Storage storage, string name) : base(storage, name)
            {
            }

            public Student SetSpeciality(string year)
            {
                _year = year;
                return this;
            }
            public override void save()
            {
            Console.WriteLine($"===== {_year + "," + _name} =====");
            _storage.Save(_name + "," + _year);
        }
        }
}

