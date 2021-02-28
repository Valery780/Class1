using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Введите ФИО: ");
            name = Console.ReadLine();

            Console.Write("Введите Возраст: ");
            string age = Console.ReadLine();

            Console.Write("Введите Адрес: ");
            string adress = Console.ReadLine();

            Console.Write("Введите Номер телефона: +380 ");
            string phonenumber = Console.ReadLine();

            Console.Write("Введите рост: ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("Введите вес: ");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine($"ФИО: {name}  " +
                $"Возраст: {age} " +
                $"Адрес: {adress} " +
                $"Номер: +380 {phonenumber} " +
                $"Рост: {height}м " +
                $"Вес: {weight}кг");

            Console.ReadKey();
        }
    }
}