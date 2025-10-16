using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Initialization : ICalculator
    {
        public int num1 {  get; set; }
        public int num2 { get; set; }  
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }
  
}
