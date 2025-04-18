using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac38
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();

            while (true)
            {
                Console.WriteLine("1.Добавить круг");
                Console.WriteLine("2.Добавить треугольник");
                Console.WriteLine("3.Вычислить площадь/периметр");
                Console.WriteLine("4.Выход");
                Console.Write("Введите число: ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Неверный ввод. Введите число от 1 до 7.");
                    continue;
                }
                switch (choice)
                {
                    case 1: shapes.Add(Disk.Enter());break;
                    case 2: shapes.Add(Triangle.Enter()); break;
                    case 3: Calculate();break;
                    case 4:
                        Console.WriteLine("Выход из программы...");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Введите число от 1 до 7.");
                        break;
                }
            }
            void ShowList()
            {
                if (shapes.Count == 0)
                {
                    Console.WriteLine("Список фигур пуст");
                    return;
                }
                for (int i = 0; i < shapes.Count; i++)
                {
                    Console.WriteLine($"{i} {shapes[i].Name}");
                }
            }
            void Calculate()
            {
                if (shapes.Count == 0)
                {
                    Console.WriteLine("Список фигур пуст");
                    return;
                }
                ShowList();
                Console.Write("Выберите номер фигуры: ");
                if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= shapes.Count)
                {
                    Console.WriteLine("Неверный номер фигуры");
                    return;
                }
                Console.WriteLine($"Площадь: {shapes[index].Area():F2}");
                Console.WriteLine($"Периметр: {shapes[index].Perimeter():F2}");
            }
        }
        
    }
}
