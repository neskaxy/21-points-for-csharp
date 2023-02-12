using System.Drawing;

namespace _21_points_for_csharp
{
    class Program
    {
        static void Main()
        {
            var start = new Game();
            var rul = new rules();
            Console.WriteLine($"\tПриветствуем вас в нашей игре '21 очко' \nЖелаете ли вы ознакомиться с правилами игры 1 - Да / 2 - Нет");
            string rules = Console.ReadLine();
            rul.Rules(rules);
            Console.WriteLine("И так, представьтесь, как вас зовут?");
            string namePlayer = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\tНачинается игра!\n"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"\tПервый начинает {namePlayer}\n"); Console.ResetColor();
            start.StartGame(namePlayer);
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\tИграем дальше? 1 - Да / 2 - Нет\n"); Console.ResetColor();
            string s = Console.ReadLine();
            while (s == "1")
            {
                start.StartGame(namePlayer);
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\tИграем дальше? 1 - Да / 2 - Нет\n"); Console.ResetColor();
                s = Console.ReadLine();
                if (s == "2")
                {
                    Console.Clear();
                }
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}