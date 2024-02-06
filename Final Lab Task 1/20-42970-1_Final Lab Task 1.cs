using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabTask1
{
    interface BasicCalculatorInterface
    {
        int sum(int x, int y);
        int sub(int x, int y);
        int multiplication(int x, int y);
        int division(int x, int y);
    }
    interface ScientificCalculatorInterface
    {
        int XtoY(int x, int y);
        float Sin(float x);
        float Cos(float x);
        float Tan(float x);
        float Log(float x);
        float LogBase10(float x);
        float Sqrt(float x);
    }
    internal class Calculator : BasicCalculatorInterface, ScientificCalculatorInterface
    {
        public int division(int x, int y)
        {
            int div = x / y;
            return div;
        }

        public int multiplication(int x, int y)
        {
            int mul = x * y;
            return mul;
        }

        public int sub(int x, int y)
        {
            int sub = x - y;
            return sub;
        }

        public int sum(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        public int XtoY(int x, int y)
        {
            int xtoy = (int)Math.Pow(x,y);
            return xtoy;
        }
        public float Tan(float x)
        {
            float tan = (float)Math.Tan(x);
            return tan;
        }
        public float Cos(float x)
        {
            float cos = (float)Math.Cos(x);
            return cos;
        }
        public float Sin(float x)
        {
            float sin = (float)Math.Sin(x);
            return sin;
        }
        public float LogBase10(float x)
        {
            float logbase10 = (float)Math.Log10(x);
            return logbase10;
        }
        public float Log(float x)
        {
            float log = (float)Math.Log(x);
            return log;
        }
        public float Sqrt(float x)
        {
            float sqrt = (float)Math.Sqrt(x);
            return sqrt;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Sum: " + calculator.sum(8,4));
            Console.WriteLine("Sub: " + calculator.sub(8, 4));
            Console.WriteLine("Multiplication: " + calculator.multiplication(8, 4));
            Console.WriteLine("Division: " + calculator.division(8, 4));
            Console.WriteLine("Power: " + calculator.XtoY(8, 2));
            Console.WriteLine("Sine value: " + calculator.Sin(90));
            Console.WriteLine("Consine value: " + calculator.Cos(00));
            Console.WriteLine("Tan value: " + calculator.Tan(45));
            Console.WriteLine("Log value: " + calculator.Log(2));
            Console.WriteLine("LogBase10 value: " + calculator.LogBase10(2));
            Console.WriteLine("Sqrt value: " + calculator.Sqrt(4));
        }
    }
}
