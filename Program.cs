using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretPassword = "qwerty";
            string input;
            int attempts = 0;

            do
            {
                Console.Write("Введите пароль: ");
                input = Console.ReadLine();

                if (input == secretPassword)
                {
                    Console.WriteLine("Доступ разрешен");
                    Console.WriteLine("Секретное сообщение: \"5 заповедь буддизма\"");
                    break;
                }
                else
                {
                    attempts++;
                    Console.WriteLine($"Неверный пароль. Осталось попыток: {3 - attempts}.");
                }
            } while (attempts < 3);

            if (attempts == 3)
            {
                Console.WriteLine("Вы превысили лимит попыток ввода пароля. Доступ запрещен.");
            }
            Console.ReadLine();
        }
    }
}