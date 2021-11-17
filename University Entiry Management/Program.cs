using System;

namespace University_Entiry_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            var stud = new Profesor(new CSV(), "Peter")
                .SetSpeciality("Informatika");

            stud.save();
        }

    }
}
