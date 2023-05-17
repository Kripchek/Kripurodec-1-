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
            Console.WriteLine("Введите ваше имя");
            string e = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            string f = Console.ReadLine();
            Console.WriteLine("Введите ваше Отчество");
            string g = Console.ReadLine();
            Console.WriteLine("Вы ввели: "+ e + " " + f + " " + g);
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
            Console.WriteLine("Здоровье игрока: " + p);
            Console.WriteLine("Урон игрока: " + pdmg);
            Console.WriteLine("Защита игрока: " + pdef);
            Console.WriteLine("Здоровье монстра: " + m);
            Console.WriteLine("Урон монстра: " + mdmg);
            Console.WriteLine("Защита монстра: " + mdef);

            Console.WriteLine("Итоги битвы:");
            Console.WriteLine("Здоровье оставшееся у Игрока: " + Php);
            Console.WriteLine("Здоровье оставшееся у Монстра " + Mhp);
            Console.WriteLine("Урон нанесеный Игроком: " + toMdmg);
            Console.WriteLine("Урон нанесеный Монстром: " + toPdmg);

            Console.ReadKey();
        }
    }
}
