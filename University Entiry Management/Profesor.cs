using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Entiry_Management
{
    class Profesor
    {
        private string Name { get; set; }
        private string Spec { get; set; }

        private Profesor(string name, string spec)
        {
            this.Name = name;
            BaseEntity Name = new BaseEntity(this.Name);
            this.Spec = spec;
        }
    }
}
