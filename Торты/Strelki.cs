using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Торты
{
    internal class Strelki
    {
        public static int Strelkaestzi(int pozicia, int min, int max, string tort, int sum)
        {

            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey();
                Console.SetCursorPosition(0, pozicia);
                Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pozicia--;
                    if (pozicia == min-1)
                    {
                        pozicia = max;
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    pozicia++;
                    if (pozicia == max+1)
                    {
                        pozicia = min;
                    }
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Menu.Menush(pozicia, tort, sum);
                }
                Console.SetCursorPosition(0, pozicia);
                Console.WriteLine("->");
            } while (key.Key != ConsoleKey.Enter);
            return pozicia;
        }
    }
}
