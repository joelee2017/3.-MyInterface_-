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
    public partial class FrmTestInterface : Form
    {
        public FrmTestInterface()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//介面實作
        {
            ClsDog d = new ClsDog();
            d.MakeNoise();

            IToy I;
            I = d;
            I.MakeNoise();

            //==========================

            ClsCat c = new ClsCat();
            c.MakeNoise();

            I = c;
            I.MakeNoise();
        }

        private void button4_Click(object sender, EventArgs e)//在集合之中放入介面變數
        {
            List<IToy> toys = new List<IToy>();
            toys.Add(new ClsDog());
            toys.Add(new ClsCat());

            foreach(IToy I in toys)
            {
                I.MakeNoise();
            }
        }
    }
}
