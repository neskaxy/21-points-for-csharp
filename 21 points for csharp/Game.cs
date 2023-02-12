using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_points_for_csharp
{
    public class Game
    {
        public void StartGame(string namePlayer)
        {
            int scorePlayer = 0;
            int enemyPlayer = 0;
            string[] namesScord = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Валет", "Дама", "Король", "Туз" };
            int[] score = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 11 };
            string[] enemyPlayerNames = { "Игорь", "Семён", "Андрей", "Виктор", "Никита", "Владислав", "Роман", "Арсений", "Глеб", "Марк", "Петр", "Даниил", "Давид", "Илья", "Александр" };
            int indexName = new Random().Next(enemyPlayerNames.Length);
            Console.WriteLine($"{namePlayer}, будете ли вы тянуть карту? 1 - Да / 2 - Нет");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    while (choice == "1")
                    {
                        if (scorePlayer > 21)
                        {
                            Console.WriteLine($"Вы проиграли! У вас {scorePlayer} очков(ка)");
                            break;
                        }
                        else if (scorePlayer == 21) { Console.WriteLine("Вы выиграли, у вас 21 очко!"); break; }
                        int karta = new Random().Next(namesScord.Length);
                        for (int i = 0; i <= score[karta]; i++)
                        {
                            if (i == score[karta])
                            {
                                if (score[karta] == 13)
                                {
                                    if (enemyPlayer + score[karta] > 21)
                                    {
                                        scorePlayer -= 10;
                                    }
                                }
                                scorePlayer += score[karta];
                            }
                        }
                        Console.WriteLine($"Вы вытянули карту {namesScord[karta]}. У вас {scorePlayer} очков(ка)");
                        Console.WriteLine("Будуте ли вы тянуть карту? 1 - Да / 2 - Нет");
                        choice = Console.ReadLine();
                        if (choice == "2" && scorePlayer <= 21)
                        {
                            goto case "2";
                        }
                        else if (choice == "2" && scorePlayer >= 21)
                        {
                            Console.WriteLine($"Вы проиграли! У вас {scorePlayer} очков(ка)");
                        }
                    }
                    break;
                case "2":
                    while (choice == "2")
                    {
                        if (enemyPlayer > 21)
                        {
                            Console.WriteLine($"{enemyPlayerNames[indexName]} проиграл! У вас {enemyPlayer} очков(ка)");
                            break;
                        }
                        else if (enemyPlayer == 21) { Console.WriteLine($"{enemyPlayerNames[indexName]} выиграл, у вас 21 очко!"); break; }
                        int enemyKarta = new Random().Next(namesScord.Length);
                        Console.WriteLine($"{enemyPlayerNames[indexName]}, тяните карту!");
                        for (int i = 0; i <= score[enemyKarta]; i++)
                        {
                            if (i == score[enemyKarta])
                            {
                                if (score[enemyKarta] == 13)
                                {
                                    if (enemyPlayer + score[enemyKarta] > 21)
                                    {
                                        enemyPlayer -= 10;
                                    }
                                }
                                enemyPlayer += score[enemyKarta];
                            }
                        }
                        Console.WriteLine($"{enemyPlayerNames[indexName]}, вы вытянули карту {namesScord[enemyKarta]}. {enemyPlayerNames[indexName]}, ваши очки состовляют {enemyPlayer}");
                        if (scorePlayer <= 10)
                        {
                            if (scorePlayer <= enemyPlayer && enemyPlayer < 21)
                            {
                                Console.WriteLine($"{namePlayer}, будете ли вы добавлять? 1 - Да, 2 - Нет");
                                string s = Console.ReadLine();
                                while (s == "1")
                                {
                                    int karta = new Random().Next(namesScord.Length); ;
                                    if (s == "1")
                                    {
                                        for (int i = 0; i <= score[karta]; i++)
                                        {
                                            if (i == score[karta])
                                            {
                                                if (score[karta] == 13)
                                                {
                                                    if (enemyPlayer + score[karta] > 21)
                                                    {
                                                        scorePlayer -= 10;
                                                    }
                                                }
                                                scorePlayer += score[karta];
                                            }
                                        }
                                        Console.WriteLine($"Вы вытянули карту {namesScord[karta]}. У вас {scorePlayer} очков(ка)");
                                        if (scorePlayer == enemyPlayer && scorePlayer == 21 && enemyPlayer == 21)
                                        {
                                            break;
                                        }
                                        if (scorePlayer > enemyPlayer && scorePlayer >= 21)
                                        {
                                            break;
                                        }
                                        else if (enemyPlayer > scorePlayer && enemyPlayer >= 21)
                                        {
                                            break;
                                        }
                                        else if (enemyPlayer < scorePlayer && scorePlayer >= 21)
                                        {
                                            break;
                                        }
                                        else if (scorePlayer < enemyPlayer && enemyPlayer >= 21)
                                        {
                                            break;
                                        }
                                        if (scorePlayer > 21)
                                        {
                                            break;
                                        }
                                        if (enemyPlayer > 21)
                                        {
                                            break;
                                        }
                                        Console.WriteLine($"{namePlayer}, будете ли вы добавлять? 1 - Да, 2 - Нет");
                                        s = Console.ReadLine();

                                    }
                                    if (s == "2")
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        if (enemyPlayer <= 5)
                        {
                            if (scorePlayer <= enemyPlayer && enemyPlayer < 21)
                            {
                                Console.WriteLine($"{namePlayer}, будете ли вы добавлять? 1 - Да, 2 - Нет");
                                string s = Console.ReadLine();
                                while (s == "1")
                                {
                                    int karta = new Random().Next(namesScord.Length); ;
                                    if (s == "1")
                                    {
                                        for (int i = 0; i <= score[karta]; i++)
                                        {
                                            if (i == score[karta])
                                            {
                                                if (score[karta] == 13)
                                                {
                                                    if (enemyPlayer + score[karta] > 21)
                                                    {
                                                        scorePlayer -= 10;
                                                    }
                                                }
                                                scorePlayer += score[karta];
                                            }
                                        }
                                        Console.WriteLine($"Вы вытянули карту {namesScord[karta]}. У вас {scorePlayer} очков(ка)");
                                        if (scorePlayer == enemyPlayer && scorePlayer == 21 && enemyPlayer == 21)
                                        {
                                            break;
                                        }
                                        if (scorePlayer > enemyPlayer && scorePlayer >= 21)
                                        {
                                            break;
                                        }
                                        else if (enemyPlayer > scorePlayer && enemyPlayer >= 21)
                                        {
                                            break;
                                        }
                                        else if (enemyPlayer < scorePlayer && scorePlayer >= 21)
                                        {
                                            break;
                                        }
                                        else if (scorePlayer < enemyPlayer && enemyPlayer >= 21)
                                        {
                                            break;
                                        }
                                        if (scorePlayer > 21)
                                        {
                                            break;
                                        }
                                        if (enemyPlayer > 21)
                                        {
                                            break;
                                        }
                                        Console.WriteLine($"{namePlayer}, будете ли вы добавлять? 1 - Да, 2 - Нет");
                                        s = Console.ReadLine();

                                    }
                                    if (s == "2")
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        if (enemyPlayer <= 16)
                        {
                            if (scorePlayer <= enemyPlayer && enemyPlayer < 21)
                            {
                                Console.WriteLine($"{namePlayer}, будете ли вы добавлять? 1 - Да, 2 - Нет");
                                string s = Console.ReadLine();
                                while (s == "1")
                                {
                                    int karta = new Random().Next(namesScord.Length); ;
                                    if (s == "1")
                                    {
                                        for (int i = 0; i <= score[karta]; i++)
                                        {
                                            if (i == score[karta])
                                            {
                                                if (score[karta] == 13)
                                                {
                                                    if (enemyPlayer + score[karta] > 21)
                                                    {
                                                        scorePlayer -= 10;
                                                    }
                                                }
                                                scorePlayer += score[karta];
                                            }
                                        }
                                        Console.WriteLine($"Вы вытянули карту {namesScord[karta]}. У вас {scorePlayer} очков(ка)");
                                        if (scorePlayer == enemyPlayer && scorePlayer == 21 && enemyPlayer == 21)
                                        {
                                            break;
                                        }
                                        if (scorePlayer > enemyPlayer && scorePlayer >= 21)
                                        {
                                            break;
                                        }
                                        else if (enemyPlayer > scorePlayer && enemyPlayer >= 21)
                                        {
                                            break;
                                        }
                                        else if (enemyPlayer < scorePlayer && scorePlayer >= 21)
                                        {
                                            break;
                                        }
                                        else if (scorePlayer < enemyPlayer && enemyPlayer >= 21)
                                        {
                                            break;
                                        }
                                        if (scorePlayer > 21)
                                        {
                                            break;
                                        }
                                        if (enemyPlayer > 21)
                                        {
                                            break;
                                        }
                                        Console.WriteLine($"{namePlayer}, будете ли вы добавлять? 1 - Да, 2 - Нет");
                                        s = Console.ReadLine();

                                    }
                                    if (s == "2")
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        if (enemyPlayer >= 19)
                        {
                            if (scorePlayer <= enemyPlayer && enemyPlayer < 21)
                            {
                                Console.WriteLine($"{namePlayer}, будете ли вы добавлять? 1 - Да, 2 - Нет");
                                string s = Console.ReadLine();
                                while (s == "1")
                                {
                                    int karta = new Random().Next(namesScord.Length); ;
                                    if (s == "1")
                                    {
                                        for (int i = 0; i <= score[karta]; i++)
                                        {
                                            if (i == score[karta])
                                            {
                                                if (score[karta] == 13)
                                                {
                                                    if (enemyPlayer + score[karta] > 21)
                                                    {
                                                        scorePlayer -= 10;
                                                    }
                                                }
                                                scorePlayer += score[karta];
                                            }
                                        }
                                        Console.WriteLine($"Вы вытянули карту {namesScord[karta]}. У вас {scorePlayer} очков(ка)");
                                        if (scorePlayer == enemyPlayer && scorePlayer == 21 && enemyPlayer == 21)
                                        {
                                            break;
                                        }
                                        if (scorePlayer > enemyPlayer && scorePlayer >= 21)
                                        {
                                            break;
                                        }
                                        else if (enemyPlayer > scorePlayer && enemyPlayer >= 21)
                                        {
                                            break;
                                        }
                                        else if (enemyPlayer < scorePlayer && scorePlayer >= 21)
                                        {
                                            break;
                                        }
                                        else if (scorePlayer < enemyPlayer && enemyPlayer >= 21)
                                        {
                                            break;
                                        }
                                        if (scorePlayer > 21)
                                        {
                                            break;
                                        }
                                        if (enemyPlayer > 21)
                                        {
                                            break;
                                        }
                                        Console.WriteLine($"{namePlayer}, будете ли вы добавлять? 1 - Да, 2 - Нет");
                                        s = Console.ReadLine();

                                    }
                                    if (s == "2")
                                    {
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    }
                    if (scorePlayer == enemyPlayer && scorePlayer <= 21 && enemyPlayer <= 21)
                    {
                        Console.WriteLine("Ничья!");
                    }
                    if (scorePlayer > enemyPlayer && scorePlayer <= 21)
                    {
                        Console.WriteLine($"Победил {namePlayer}. Его очки составили {scorePlayer}, а у {enemyPlayerNames[indexName]} составило {enemyPlayer} очков(ка)");
                    }
                    else if (enemyPlayer > scorePlayer && enemyPlayer <= 21)
                    {
                        Console.WriteLine($"Победил {enemyPlayerNames[indexName]}. Его очки составили {enemyPlayer}, а у {namePlayer} составило {scorePlayer} очков(ка)");
                    }
                    else if (enemyPlayer < scorePlayer && scorePlayer <= 21)
                    {
                        Console.WriteLine($"Победил {namePlayer}. Его очки составили {scorePlayer}, а у {enemyPlayerNames[indexName]} составило {enemyPlayer} очков(ка)");
                    }
                    else if (scorePlayer < enemyPlayer && enemyPlayer <= 21)
                    {
                        Console.WriteLine($"Победил {enemyPlayerNames[indexName]}. Его очки составили {enemyPlayer}, а у {namePlayer} составило {scorePlayer} очков(ка)");
                    }
                    if (scorePlayer > 21)
                    {
                        Console.WriteLine($"Победил {enemyPlayerNames[indexName]}. Его очки составили {enemyPlayer}, а у {namePlayer} составило {scorePlayer} очков(ка)");
                    }
                    if (enemyPlayer > 21)
                    {
                        Console.WriteLine($"Победил {namePlayer}. Его очки составили {scorePlayer}, а у {enemyPlayerNames[indexName]} составило {enemyPlayer} очков(ка)");
                    }
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Возможно вы ошиблись, повторите попытку снова!"); Console.ResetColor();
                    break;
            }
        }
    }
}
