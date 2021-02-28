using System;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название продукта: ");
            string name = Console.ReadLine();

            Console.Write("Введите количество: ");
            float amount = float.Parse(Console.ReadLine());

            Console.Write("Введите единицу измерения(кг, л, шт и тд.): ");
            string unit = Console.ReadLine();

            Console.Write("Введите цену продукта: ");
            float cost = float.Parse(Console.ReadLine());


            Console.WriteLine($"Название продукта: {name.ToUpper()}" +
                $" Количество продукта: {amount}" +
                $" Единица измерения: {unit.ToLower()}" +
                $" Цена продукта: {cost}");




        }
    }
}
