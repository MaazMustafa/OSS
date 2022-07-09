using System;
using System.Collection.Generic;

namespace HR
{
    public class Employee: Person
    {
        public string Department { get; set; }
        public int BasicSalary { get;set; }

        public Employee(string fname, string lname, string dept, int bsal):base(fname, lname)
        {
            this.Department = dept;
            this.BasicSalary = bsal;
        }
    }
}