using System;

namespace GuessNumber
{
    internal class GuessNumber
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int hiddenNumber = random.Next(1, 101);

            Console.WriteLine("Угадайте загаданное число! Введите число от 1 до 100:");
            int allegedNumber = Convert.ToInt32(Console.ReadLine());

            int attemptsAmount = 1;

            while (hiddenNumber != allegedNumber)
            {
                Console.Write("Вы не угадали! Загаданное число ");

                if (hiddenNumber > allegedNumber)
                {
                    Console.WriteLine("больше.");
                }
                else
                {
                    Console.WriteLine("меньше.");
                }

                attemptsAmount++;

                Console.WriteLine("Повторите попытку:");
                allegedNumber = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Поздравляем! Вы угадали!");
            Console.WriteLine($"Количество попыток: {attemptsAmount}");

            Console.ReadKey();
        }
    }
}