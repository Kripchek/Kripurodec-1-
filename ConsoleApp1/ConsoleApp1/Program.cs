using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = " WoRlD";
            Console.WriteLine(a + b);
            int c = 18;
            int d = 3;
            Console.WriteLine(c + d);
            Console.WriteLine(c * d);
            Console.WriteLine(c / d);
            Console.WriteLine(c - d);
          
            float p = 40;
            float pdmg = 16;
            float pdef = 12;
            float m = 25;
            float mdmg = 18;
            float mdef = 5;
            float toPdmg = mdmg / pdef;
            float toMdmg = pdmg / mdef;
            float Php = p - toPdmg;
            float Mhp = m - toMdmg;
          

            float Playerhp = 40;
            float Monsterhp = 25;
                Console.WriteLine("суммарный урон по игроку");
            float sumPDmg = toPdmg;
            Console.WriteLine(sumPDmg);
                Console.WriteLine("суммарный урон по монстру");
            float sumMDmg = toMdmg;
            Console.WriteLine(sumMDmg);
            
            Console.WriteLine("Начало боя");
            while (Playerhp > 0 && Monsterhp > 0)
            {
                Console.WriteLine("==================================");
                Console.WriteLine("Выберите навык который хотие использовать:1 - Fireball; 2 - Shadow Dance; 3 - First Strike;" +
                " 4 - Reverse Polarity; 5 - Charge of Darkness");
                int mode = int.Parse(Console.ReadLine());
                switch (mode)
                {
                    case 1:
                        Console.WriteLine("вы выбрали fireball");
                        break;
                    case 2:
                        Console.WriteLine("вы выбрали shadow dance");
                        break;
                    case 3:
                        Console.WriteLine("вы выбрали first strike");
                        break;
                    case 4:
                        Console.WriteLine("вы выбрали reverse polarity");
                        break;
                    case 5:
                        Console.WriteLine("вы выбрали charge of darkness");
                        break;
                }
                Console.WriteLine("Здоровье игрока");
                    Playerhp -= toPdmg;
                Console.WriteLine(Playerhp);

                Console.WriteLine("Здоровье Монстров");
                    Monsterhp -= toMdmg;
                    Console.WriteLine(Monsterhp);
                Console.WriteLine("суммарный урон по монстру");
                    sumMDmg +=  toMdmg;
                Console.WriteLine(sumMDmg);
                Console.WriteLine("суммарный урон по игроку");
                    sumPDmg +=  toPdmg;
                Console.WriteLine(sumPDmg);
                Console.WriteLine("==================================");
            }
            Console.WriteLine("Итоги битвы:");
            Console.WriteLine("Здоровье оставшееся у Игрока: " + Playerhp);
            Console.WriteLine("Здоровье оставшееся у Монстра " + Monsterhp);
            Console.WriteLine("Урон нанесеный Игроком: " + sumMDmg);
            Console.WriteLine("Урон нанесеный Монстром: " + sumPDmg);
            Console.ReadKey();
        }
    }
}
