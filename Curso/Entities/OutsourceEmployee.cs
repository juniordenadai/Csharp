using System;
using System.Collections.Generic;
using System.Text;
using Curso.Entities;

namespace Curso.Entities
{
    class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
       
        public OutsourceEmployee() 
        { 
        }

        public OutsourceEmployee(string name, int hour, double valuePerHour, double additionalCharge) : base(name, hour, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

            
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
        
    }
}
