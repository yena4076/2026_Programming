using System.ComponentModel;

namespace _022_ClassCalculator
{
    class Calculator
    {
        public static double Add(double x, double y) { return x + y; }
        public static double Subtract(double x, double y) { return x - y; }
        public static double Multiple(double x, double y) { return x * y; }
        public static double Divide(double x, double y)
        {
            if (y == 0) { Console.WriteLine("0으로 나눌 수 없습니다."); return 0; }
            else return x / y; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 3.5;
            double num2 = 6.7;

            // static 메소드는 객체를 만들지 않고, 클래스 이름으로 사용
            double sum = Calculator.Add(num1, num2);
            double diff = Calculator.Subtract(num1, num2);
            double prod = Calculator.Multiple(num1, num2);
            double quot = Calculator.Divide(num1, num2);

            Console.WriteLine("덧셈: " + sum);
            Console.WriteLine("뺄셈: " + diff);
            Console.WriteLine("곱셈: " + prod);
            Console.WriteLine("나눗셈: {0:F2}", quot);
        }
    }
}
