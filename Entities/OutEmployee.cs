using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
 

namespace Business.Entities
{
     class OutEmployee: Employee
    {
        public double AdditionalCharge { get; set; }


        public OutEmployee()
        {

        }

       public OutEmployee(string name, int hours, double salary, double additionalCharge)
            : base(name, hours, salary)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
                 
            return base.Payment() + 1.1 *AdditionalCharge;
        }
    }
}
