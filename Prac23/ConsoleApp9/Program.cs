using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calc1 = new Calculate();
            calc1.num1 = 14.2;
            calc1.num2 = 27.5;
            calc1.Info();
            Console.WriteLine($"{calc1.ToString()}");
            Calculate calc2 = new Calculate(15.4,31.1);
            calc2.Info();
            Console.WriteLine($"{calc2.ToString()}");
            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double num2 = double.Parse(Console.ReadLine());
            Calculate calc3 = new Calculate(num1, num2);
            Console.WriteLine($"{calc3.ToString()}");
        }
    }
}
