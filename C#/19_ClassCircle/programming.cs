namespace _021_ClassCircle
{
    internal class Program
    {
        class Circle
        {
            private double radius;
            private string color;
            public Circle(double r, string c)
            {
                this.radius = r;
                this.color = c;
            }

            public double GetArea()
            {
                return radius * radius * 3.14;
            }
            public void PrintInfo()
            {
                Console.WriteLine($"반지름: {radius}, 색깔: {color}");
            }
        }
        static void Main(string[] args)
        {
            Circle c = new Circle(10, "빨간색");
            Console.WriteLine("면적: " + c.GetArea());
            c.PrintInfo();
        }
    }
}
