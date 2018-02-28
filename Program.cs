using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polinom_C
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Count=");
            int count = Convert.ToInt32(Console.ReadLine());

            Parcer_str parcer = new Parcer_str(count);
            parcer.Binary_mass();
            parcer.Add_Const_one();
            parcer.Gluing_function();


        }
    }
}
