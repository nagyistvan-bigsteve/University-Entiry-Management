using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Entiry_Management
{
    class Profesor : BaseEntity
    {
        private string _name, _spec;

        public Profesor(Storage storage , string name) : base(storage,name)
        {
        }

        public Profesor SetSpeciality(string spec)
        {
            _spec = spec;
            return this;
        }
        public override void save()
        {
            Console.WriteLine($"===== {_spec+","+_name} =====");
            _storage.Save(_name + "," + _spec);
        }
    }
}
