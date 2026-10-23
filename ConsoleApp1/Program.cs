using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            r.height = 2;
            r.width = 3;

            r.Show();

            float p = r.Perimetr();
            Console.WriteLine($"Периметр прямоугольника = {p}");

            Console.ReadKey();
        }
    }


    class Rectangle
    {
        
        public float height;
        public float width;

        // Метод Show()
        public void Show()
        {
            Console.WriteLine($"Прямоугольник: высота = {height}, ширина = {width}");
        }

        // Метод Perimetr()
        public float Perimetr()
        {
          
            return 2 * height + 2 * width;
        }
    }
}