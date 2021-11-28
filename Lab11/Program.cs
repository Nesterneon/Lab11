using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab11_bibl_;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation equation=new Equation();
            equation.K = 8;
            equation.b = 6;
            equation.Root();
            Console.ReadKey();
        }
    }
}
