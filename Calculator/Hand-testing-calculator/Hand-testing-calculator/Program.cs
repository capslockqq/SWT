using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hand_testing_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Test = new Calculator();
            System.Console.WriteLine(Test.Add(3.0, 5.0));
            System.Console.WriteLine(Test.Subtract(3.0, 5.0));
            System.Console.WriteLine(Test.Multiply(3.0, 5.0));
            System.Console.WriteLine(Test.Power(3.0, 5.0));
        }
    }
}
