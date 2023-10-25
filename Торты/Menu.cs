using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Торты
{
    internal class Menu
    {
        public static void Menush(int pozicia, string tort, int sum)
        {
            Console.WriteLine("Заказ торта в чайхане у Вазгена");
            Console.WriteLine("Cоздайте свой торт сами!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер торта");
            Console.WriteLine("  Вкус коржей");
            Console.WriteLine("  Кол-во коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Цена: " + sum + "Р");
            Console.WriteLine("Ваш торт: " + tort );
            pozicia = Strelki.Strelkaestzi(pozicia, 3, 9, tort, sum);
            Vnutri(pozicia,tort,sum);
        }
        private static void Vnutri(int pozicia, string tort, int sum)
        {
            Console.Clear();
            Console.WriteLine("Для выхода Escape нажмите");
            Console.WriteLine("Выберите пункт из меню");
            Console.WriteLine("----------------------------------");
            switch (pozicia)
            {
                case 3:
                    pozicia = 3;
                    Console.WriteLine("  Квадрат - 300Р");
                    Console.WriteLine("  Круг - 500Р");
                    Console.WriteLine("  Треугольник - 350Р");
                    pozicia = Strelki.Strelkaestzi(pozicia, 3, 5, tort, sum);
                    if (pozicia == 3)
                    {
                        sum = sum + 300;
                        tort = tort + "Квадрат; ";
                    }
                    else if (pozicia == 4)
                    {
                        sum = sum + 500;
                        tort = tort + "Круг; ";
                    }
                    else if (pozicia == 5)
                    {
                        sum = sum + 350;
                        tort = tort + "Треугольник; ";
                    }
                    Console.Clear();
                    Menush(pozicia, tort, sum);
                    break;
                case 4:
                    pozicia = 3;
                    Console.WriteLine("  Диаметр 15 см - 400Р");
                    Console.WriteLine("  Диаметр 20 см - 550Р");
                    Console.WriteLine("  Диаметр 25 см - 700Р");
                    pozicia = Strelki.Strelkaestzi(pozicia, 3, 5, tort, sum);
                    if (pozicia == 3)
                    {
                        sum = sum + 400;
                        tort = tort + "Диаметр - 15см; ";
                    }
                    else if(pozicia == 4)
                    {
                        sum = sum + 550;
                        tort = tort + "Диаметр 20 см; ";
                    }
                    else if(pozicia == 5)
                    {
                        sum = sum + 700;
                        tort = tort + "Диаметр 25 см; ";
                    }
                    Console.Clear();
                    Menush(pozicia, tort, sum);
                    break;
                case 5:
                    pozicia = 3;
                    Console.WriteLine("  Шоколад - 100Р");
                    Console.WriteLine("  Без вкуса - 20Р");
                    Console.WriteLine("  Клубника - 150Р");
                    pozicia = Strelki.Strelkaestzi(pozicia, 3, 5, tort, sum);
                    if (pozicia == 3)
                    {
                        sum = sum + 100;
                        tort = tort + "Шоколад; ";
                    }
                    else if(pozicia == 4)
                    {
                        sum = sum + 20;
                        tort = tort + "Без вкуса; ";
                    }
                    else if(pozicia == 5)
                    {
                        sum = sum + 150;
                        tort = tort + "Клубника; ";
                    }
                    Console.Clear();
                    Menush(pozicia, tort, sum);
                    break;
                case 6:
                    pozicia = 3;
                    Console.WriteLine("  1 корж - 100Р");
                    Console.WriteLine("  2 коржа - 200Р");
                    Console.WriteLine("  3 коржа - 400Р");
                    pozicia = Strelki.Strelkaestzi(pozicia, 3, 5, tort, sum);
                    if (pozicia == 3)
                    {
                        sum = sum + 100;
                        tort = tort + "1 корж; ";
                    }
                    else if(pozicia == 4)
                    {
                        sum = sum + 200;
                        tort = tort + "2 коржа; ";
                    }
                    else if(pozicia == 5)
                    {
                        sum = sum + 400;
                        tort = tort + "3 коржа; ";
                    }
                    Console.Clear();
                    Menush(pozicia, tort, sum);
                    break;
                case 7:
                    pozicia = 3;
                    Console.WriteLine("  Шоколад - 150Р");
                    Console.WriteLine("  Ваниль - 150Р");
                    Console.WriteLine("  Клубника - 150Р");
                    pozicia = Strelki.Strelkaestzi(pozicia, 3, 5, tort, sum);
                    if (pozicia == 3)
                    {
                        sum = sum + 150;
                        tort = tort + "Шоколад; ";
                    }
                    else if(pozicia == 4)
                    {
                        sum = sum + 150;
                        tort = tort + "Ваниль; ";
                    }
                    else if(pozicia == 5)
                    {
                        sum = sum + 150;
                        tort = tort + "Клубника; ";
                    }
                    Console.Clear();
                    Menush(pozicia, tort, sum);
                    break;
                case 8:
                    pozicia = 3;
                    Console.WriteLine("  Нет декора - 0Р");
                    Console.WriteLine("  Присыпка - 50Р");
                    Console.WriteLine("  Сьедобная бумага - 150Р");
                    pozicia = Strelki.Strelkaestzi(pozicia, 3, 5, tort, sum);
                    if (pozicia == 3)
                    {
                        sum = sum + 0;
                        tort = tort + "Нету декора; ";
                    }
                    else if(pozicia == 4)
                    {
                        sum = sum + 50;
                        tort = tort + "Присыпка; ";
                    }
                    else if(pozicia == 5)
                    {
                        sum = sum + 150;
                        tort = tort + "Сьедобная бумага; ";
                    }
                    Console.Clear();
                    Menush(pozicia, tort, sum);
                    break;
                case 9:
                    string sumoch = sum.ToString();
                    Console.Clear();
                    File.AppendAllText("C:\\Users\\admin\\Desktop\\История заказов.txt", sumoch + "- Цена вашего торта\n");
                    File.AppendAllText("C:\\Users\\admin\\Desktop\\История заказов.txt", tort + "- Конфигурация вашего торта\n");
                    File.AppendAllText("C:\\Users\\admin\\Desktop\\История заказов.txt", "Дата заказа: " + DateTime.Now);
                    Console.WriteLine("Нажмите Escape чтобы сделать новый заказ");
                    sum = 0;
                    tort = "";
                    pozicia = Strelki.Strelkaestzi(pozicia, 3, 5, tort, sum);
                    break;



            }
        }
    }
}
