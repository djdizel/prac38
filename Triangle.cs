using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prac38
{
    class Triangle : IShape
    {
        double side1, side2, side3;
        public string Name => "Треугольник";

        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }
        public double Side3 { get => side3; set => side3 = value; }

        public Triangle(double side1, double side2, double side3) 
        {
            if ((side1<side2+side3)&&(side2<side1+side3)&&(side3<side1+side2))
            {
                Side1 = side1;
                Side2 = side2;
                Side3 = side3;
            }
            else
            {
                Console.WriteLine("Треугольника не существует");
            }
        }
        public double Perimeter()
        {

        return Side1 + Side2 + Side3; 
        }

        public double Area()
        {
            double p = (Side1+Side2+Side3)/2;
            return Math.Sqrt((p)*(p-Side1)*(p-Side2)*(p-Side3));
        }

        public static Triangle Enter()
        {
            Console.Clear();
            Console.Write("Введите первую сторону: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую сторону: ");
            double side2 = double.Parse(Console.ReadLine());
            Console.Write("Введите третью сторону: ");
            double side3 = double.Parse(Console.ReadLine());
            return new Triangle(side1, side2, side3);
        }

        public void Print()
        {
            Console.WriteLine(" Первая сторона:" + Side1 + " Вторая сторона:" + Side2 + " Третья сторона" + Side3);
        }
    }
}
