using System;

namespace задание2
{
    internal class calucalator
    {
        //ЗАДАНИЕ 1 
        public static int Add(int a, int b)
        {
            return a + b;
        }
        private static double Dev(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль невозможно!");
                return 0;
            }
            return a / b;
        }
      
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЯ 1");
            Console.Write("Введите первое целое число для сложения: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе целое число для сложения: ");
            int b = Convert.ToInt32(Console.ReadLine());

            // Вызываем метод Add 
            int sumAdd = Add(a, b);
            Console.WriteLine($"Результат сложения: {sumAdd}");

            // Считываем данные для деления
            Console.Write("\nВведите первое число для деления (можно дробное): ");
            double c = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

            Console.Write("Введите второе число для деления (можно дробное): ");
            double d = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

            // Вызываем метод Dev 
            double DevResult = Dev(c, d);
            Console.WriteLine($"Результат деления: {DevResult}");


            Console.WriteLine("\nЗАДАНИЯ 2");

            // Создаем объект класса User
            User myUser = new User();

            // Заполняем его 
            myUser.Name = "Василина";
            myUser.Age = 18;
            myUser.Email = "vasilina@gmail.com";
            myUser.ShowInfo();

            Console.ReadLine();
        }
    }
}