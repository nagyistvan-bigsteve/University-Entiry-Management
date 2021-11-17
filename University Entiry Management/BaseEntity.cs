using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Entiry_Management
{
    public abstract class BaseEntity
    {
        protected Storage _storage;
        private string Name;

        protected BaseEntity(Storage storage, string name)
        {
            _storage = storage;
            Name = name;
        }
        public abstract void save();
    }
}

