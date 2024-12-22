using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.MyClasses;
using MyLib;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float speed = (float)2.4;
            string type=string.Empty;

            Processor processor = new Processor();
            processor.setType("ARMx64");
            processor.setSpeed(speed);
            
            string str = "Processor Details:\nType :{0}\nSpeed:{1}";
            str=string.Format(str, type, speed);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}



