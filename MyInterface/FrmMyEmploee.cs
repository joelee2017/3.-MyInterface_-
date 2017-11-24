using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyInterface
{
    public partial class FrmMyEmploee : Form
    {
        public FrmMyEmploee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = { 2, 4, 11, 222, 44 };
            Array.Sort(nums);


            List<ClsEmployee> empList = new List<ClsEmployee>();
            empList.Add(new ClsEmployee { EmpName = "aaa", HireDate = DateTime.Now.AddDays(-7), JobTitle = JobTitle.Engineer, Salary = 70000 });
            empList.Add(new ClsEmployee { EmpName = "abb", HireDate = DateTime.Now.AddDays(-3), JobTitle = JobTitle.Engineer, Salary = 50000 });
            empList.Add(new ClsEmployee { EmpName = "acc", HireDate = DateTime.Now.AddDays(-1), JobTitle = JobTitle.Engineer, Salary = 50000 });
            empList.Sort();
            
            this.dataGridView1.DataSource = empList;

            this.listBox1.DataSource = empList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsEmployee a = new ClsEmployee { EmpName = "aaa", HireDate = DateTime.Now.AddDays(-7), JobTitle = JobTitle.Engineer, Salary = 70000 };
            ClsEmployee b = new ClsEmployee { EmpName = "bbb", HireDate = DateTime.Now.AddDays(-5), JobTitle = JobTitle.Engineer, Salary = 60000 };

            int result = a.CompareTo(b);
            if(result < 0)
                MessageBox.Show("a salary < b salary"); 
            else if (result > 0)
                MessageBox.Show("a salary > b salary");
            else
                MessageBox.Show("a salary == b salary");

        }
    }
}
