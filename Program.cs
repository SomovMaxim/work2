using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3workSomov
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x, y, z, Result;
            Console.WriteLine("Введите x:");
            x = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите y:");
            y = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите z:");
            z = bool.Parse(Console.ReadLine());
            Result = !(!x && y) || (x && !z);
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
