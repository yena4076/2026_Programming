using System.Drawing;

namespace _023_RectangleProperty
{
    class Rectangle
    {
        // int width, height; // 필드
        public int Width { get; set; } // 속성(대문자) public
        public int Height { get; set; }
        public int GetArea()
        {
            return Width * Height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Width = 10;
            r.Height = 10;
            Console.WriteLine("면적: " + r.GetArea());
        }
    }
}
