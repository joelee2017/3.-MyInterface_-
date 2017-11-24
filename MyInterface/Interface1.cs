using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MyInterface
{
    interface IToy
    {
        void MakeNoise();//只有定義沒有實作
        //.............
    }

    class ClsDog : Object,IToy
    {
        public void MakeNoise()
        {
            Debug.WriteLine("Bark");
        }
    }

    class ClsCat : Object,IToy
    {
        public void MakeNoise()
        {
            Debug.WriteLine("meow");
        }
    }
}
