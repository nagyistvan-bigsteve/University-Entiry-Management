﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Entiry_Management
{
   public class DB : Storage
    {
        public string Save(string text)
        {
            return "saved on db";
        }
    }
}
