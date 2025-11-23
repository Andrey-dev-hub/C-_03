using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
     class Employee
    {
        public String Name { get; set; }

        public int Hours { get; set; }

        public double Value_Hour { get; set; }
        public double Salary { get; set; }
        



        public Employee()
        {
            
        }

        public Employee(String name,double value_hour, double salary)
        {
           Name = name;
           Salary = salary;
            Value_Hour = value_hour;
           
        }

        public virtual double Payment()
        {
                       return Salary * Hours;
        }

        
    }
}
