// Сушинський Ігор
// Лабораторна робота № 1.1
// Розгалуження, задане формулою: функція однієї змінної.
// Варіант 3

namespace LAB1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine()); // вхідний параметр

            double orig = 2 / x + Math.Abs(x); // початковий вираз

            // умови
            double condition1 = orig + 1 + 4 * Math.Pow(x, 2);
            double condition2 = orig + Math.Pow(Math.Pow(Math.E, x) + Math.Abs(x), 2);
            double condition3 = orig + 5 * Math.Sin(Math.Pow(x, 2) + 1);

            // спосіб 1: розгалуження в скороченій формі
            if (x < 0)
                Console.WriteLine($"Перша умова (Скорочена форма): {condition1}");
            if (x >= 0 && x <= 2)
                Console.WriteLine($"Друга умова (Скорочена форма): {condition2}");
            if (x > 2)
                Console.WriteLine($"Третя умова (Скорочена форма): {condition3}");

            // спосіб 2: розгалуження в повній формі
            if (x < 0)
                Console.WriteLine($"Перша умова (Повна форма): {condition1}");
            else
                if (x > 2)
                Console.WriteLine($"Третя умова (Повна форма): {condition3}");
            else
                Console.WriteLine($"Друга умова (Повна форма): {condition2}");
        }
    }
}