using GeometricObjects;
using System;
using System.Drawing;
using System.IO;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input.txt");
            Console.WriteLine($"Searching for file at: {filePath}"); // Вывод пути для проверки

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            foreach (var inputLine in lines)
            {
                string[] parts = inputLine.Split(' ');
                string type = parts[0];
                double[] parameters = Array.ConvertAll(parts[1..], double.Parse);

                object obj = Factory.Create(type, parameters);

                switch (obj)
                {
                    case GeometricObjects.Point point:
                        point.Draw();
                        point.Perimeter();
                        point.CalculateArea();
                        break;
                    case Rect rect:
                        rect.Draw();
                        rect.Perimeter();
                        rect.CalculateArea();
                        break;
                    case Line line:
                        line.Draw();
                        line.Perimeter();
                        line.CalculateArea();
                        break;
                    case Circle circle:
                        circle.Draw();
                        circle.Perimeter();
                        circle.CalculateArea();
                        break;
                    case Rhomb rhomb:
                        rhomb.Draw();
                        rhomb.Perimeter();
                        rhomb.CalculateArea();
                        break;
                    case Square square:
                        square.Draw();
                        square.Perimeter();
                        square.CalculateArea();
                        break;
                }
            }
        }
    }
}
