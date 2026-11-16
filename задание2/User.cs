using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание2
{
    internal class User
    {
        // ЗАДАНИЕ 2 
        //  класс User и его свойства
            public string Name { get; set; }     
            public int Age { get; set; }         
            public string Email { get; set; }    

            // Метод для вывода всей информации о пользователе
            public void ShowInfo()
            {
                Console.WriteLine($"Имя пользователя: {Name}");
                Console.WriteLine($"Возраст: {Age} лет");
                Console.WriteLine($"Электронная почта: {Email}");
            }
        }
    }

