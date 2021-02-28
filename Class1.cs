using System;

public class Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Македонская Валерия Ивановна";
            int age = 17;
            string adress = "проспект Шевченка, 1, Одесса";
            string phonenumber = "+380 98 042 86 94"
            double height = 1.7;
            double weight = 53.2;
            Console.WriteLine($"ФИО: {name} " +
                $"Возраст: {age} " +
                $"Адрес: {adress} " +
                $"Номер: {phonenumber} " +
                $"Рост: {height}м " +
                $"Вес: {weight}кг");

            Console.ReadKey();
        }
    }
}