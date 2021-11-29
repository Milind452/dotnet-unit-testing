using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_testing_sample
{
    class Calculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int subtract(int a, int b)
        {
            return a - b;
        }

        public int multiply(int a, int b)
        {
            return a * b;
        }

        public int divide(int a, int b)
        {
            try
            {
                return a / b;
            } 
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            return 0;
        }
    }
}
