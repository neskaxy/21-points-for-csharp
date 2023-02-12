using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_points_for_csharp
{
    public class rules
    {
        public void Rules(string s)
        {
            switch (s)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("\tПравила данной игры довольно таки просты:"); Console.ResetColor();
                    Console.WriteLine("Стоимость карт в очках: туз — 11 очков (при переборе, по договорённости, туз может засчитываться за 1,\nпо аналогии с игрой блэкджек), король — 4 очка, дама — 3 очка, валет — 2 очка, остальные — по номиналу.");
                    Console.WriteLine("Если у вас больше 21 очка, то вы проиграли\nЕсли же у вас больше чем у соперника, а очки не достигают больше 21,то вы выиграли");
                    Console.WriteLine("Если же наоборот, у вас меньше чем у соперника, и его очки не достигают больше 21, то вы проиграли\n");
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\tДумаю, вы уже ознакомились с правилами, так что приступим к игре!"); Console.ResetColor();
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Хорошо! Приступим к игре"); Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Возможно вы ошиблись, повторите попытку снова!"); Console.ResetColor();
                    break;
            }
        }
    }
}

