namespace _019_ClassRactangle
{
    class Rectangle
    {
        private int width, height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public int GetArea()
        {
            return width * height;
        }
        public int GetPerimeter()
        {
            return (width * 2) + (height * 2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 3);
            double area = rect.GetArea();
            double perimeter = rect.GetPerimeter();

            Console.WriteLine("넓이: " + area);
            Console.WriteLine("둘레: "+ perimeter);
        }
    }
}
