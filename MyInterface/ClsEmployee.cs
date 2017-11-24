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

    class ClsEmployee:IComparable<ClsEmployee>//IComparable<>通用定義比較方法<>用到它的類別，沒放的話下面會變成OBJECT
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

            if (this.Salary < other.Salary) // a < B 往下排
                return -1;
            else if (this.Salary > other.Salary) // a > B 往上排
                return 1;
            else
                return 0; // a = b  同排
        }
    }

    
}
