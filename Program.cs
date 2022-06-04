using System;

namespace HW_M_3._10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Здравствуйте! \nСколько у Вас на руках карт?");
            int n = int.Parse(Console.ReadLine());
            for (int i=1; i<=n; i++)
                {
                Console.WriteLine($"Введите вашу {i}-ю карту:");
                string card = Console.ReadLine();
                    switch (card)
                    {
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        sum += 10;
                        break;
                    default:
                        sum += int.Parse(card);
                        break;
                    }
                }
            Console.WriteLine($"Сумма Ваших карт равна: {sum}");
            Console.ReadKey();
        }
    }
}
