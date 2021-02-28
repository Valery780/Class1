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
            double height = 1.7;
            double weight = 53.2;
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