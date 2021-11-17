using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Entiry_Management
{
    class CSV : Storage
    {
        public string Save(string text)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("profesor.csv", true))
                {
                    file.WriteLine(text);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error:", ex);
            }
            return "writen on a file";
        }
    }
}

