using System.Diagnostics;

namespace Tyuiu.KopylskikhVM.Sprint0.Task4.V0.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static int Division(in int a, in int b)
        {
            return a / b;
        }
    }
}
