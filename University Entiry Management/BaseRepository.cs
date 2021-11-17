using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Entiry_Management
{
  abstract class BaseRepository
    {
        private Storage storage;
        public BaseRepository(Storage storage)
        {
            this.storage = storage;
        }

        public void save2(BaseEntity entity);
    }
}
