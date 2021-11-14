using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Entiry_Management
{
    class BaseEntity
    {
        private string Name { get; set; }

        public BaseEntity(string name)
        {
            this.Name = name;
        }
    }
}
