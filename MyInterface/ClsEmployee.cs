using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyInterface
{

    enum JobTitle
    {
        Manager,
        Engineer,
        Tester
    }

    class ClsEmployee
    {
        public string EmpName { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get;set; }
        public JobTitle JobTitle { get; set; }


        public override string ToString()
        {
            return
                this.EmpName.ToString()+ "  " + this.Salary.ToString();

        }

        public int CompareTo (ClsEmployee other)
        {
            // this VS. other

            if (this.Salary < other.Salary)
                return -1;
            else if (this.Salary > other.Salary)
                return 1;
            else
                return 0;
        }
    }

    
}
