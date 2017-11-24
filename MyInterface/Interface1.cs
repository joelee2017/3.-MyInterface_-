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

    interface I1
    {
        void Test1();
    }

    interface I2
    {
        void Test2();
    }

    class Class : I1, I2, IDisposable
    {
        public void Dispose()
        {
            
        }

        public void Test1()
        {
            
        }

        public void Test2()
        {
            
        }
    }

}
