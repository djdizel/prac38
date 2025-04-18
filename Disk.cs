using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac38
{
    class Disk : IShape
    {
        double radius;
        public string Name => "Круг";
        public Disk(double radius)
        {
            Radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public double Area()
        {
            return Math.PI * Math.Pow(2,Radius);
        }
        public double Perimeter()
        {
            return 2 * Radius * Math.PI;
        }
        public static Disk Enter()
        {
            Console.Clear();
            Console.Write("Введите радиус: ");
            double radius = double.Parse(Console.ReadLine());
            return new Disk(radius);
        }

        public void Print()
        {
            Console.WriteLine("Радиус:" + radius);
        }
    }
}
