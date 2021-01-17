using System;
namespace Interfaces
{
 
   interface IFigureInfo
    {
        double area();
        double perimeter();
    }

    class Circle : IFigureInfo
    {
        double Length; // радиус круга
        public Circle(double len)
        { Length = len; }
        public double area()
        {
            return Math.PI * Length * Length;
        }
        public double perimeter()
        {
            return 2 * Math.PI * Length;
        }
    }

    class Square : IFigureInfo
    {
        double Length; // сторона квадрата
        public Square(double len)
        {
            Length = len;
        }
        public double area()
        {
            return Length * Length;
        }
        public double perimeter()
        {
            return 4 * Length;
        }
    }

    class Triangle : IFigureInfo
    {
        double Length; // сторона треугольника
        public Triangle(double len)
        { Length = len; }
        public double area()
        {
            return Length * Length * Math.Sqrt(3) / 4;
        }
        public double perimeter()
        {
            return 3 * Length;
        }
    }

    class Program
    {
        static public void InfoFigure(string fig, double s, double p)
        {
            Console.WriteLine("{0} площадь = {1:##.###}, периметр = {2:##.###}", fig, s, p);
        }
        static void Main(string[] args)
        {

            /*string test = "Oxana is the best";
            char[] myTest = test.ToCharArray();
            Array.Reverse(myTest);
            Console.Write(myTest);
            */

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            /*

            Console.Write("Характерный размер фигуры = ");
            double len = Convert.ToDouble(Console.ReadLine());

            Circle c = new Circle(len);
            InfoFigure("Круг: ", c.area(), c.perimeter());

            Square q = new Square(len);
            InfoFigure("Квадрат: ", q.area(), q.perimeter());

            Triangle t = new Triangle(len);
            InfoFigure("Треугольник: ", t.area(), t.perimeter());
            */

            Console.ReadKey();
        }
    }
}