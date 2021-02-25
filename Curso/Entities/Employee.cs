using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hour { get; set; }

        public double ValuePerHour { get; set; }


        public Employee()
        {

        }

        public Employee(string name, int hour, double valuePerHour)
        {
            Name = name;
            Hour = hour;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hour * ValuePerHour;
        }

        public override string ToString()
        {
            return Name
                + " - $ "
                + Payment().ToString("F2");
        }
    }
}
