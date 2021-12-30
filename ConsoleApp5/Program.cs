using System;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Money()
        {
            Money hryvnia = new Money();
            Money hryvnia2 = new Money();
            Money dollar = new Money();
            Money rupee = new Money();

            hryvnia.MoneyValue = 10.6;
            hryvnia2.MoneyValue = 4.5;
            hryvnia.ExchangeRate = 2;
            dollar.ExchangeRate = 14;
            rupee.ExchangeRate = 1.5;

            Console.WriteLine(hryvnia.MoneyValue);
            hryvnia.Minus(hryvnia2.MoneyValue);
            Console.WriteLine(hryvnia.MoneyValue);
            hryvnia.Plus(hryvnia2.MoneyValue);
            Console.WriteLine(hryvnia.MoneyValue);
            hryvnia.Multiply(11.2);
            Console.WriteLine(hryvnia.MoneyValue);
            hryvnia.Convert(rupee.ExchangeRate);
            Console.WriteLine(hryvnia.MoneyValue);
            hryvnia.Convert(dollar.ExchangeRate);
            Console.WriteLine(hryvnia.MoneyValue);
            Console.WriteLine(hryvnia.Penny);
            Console.WriteLine(hryvnia.Bill);
        }

        static void Battleroyal()
        {
            Unit[] units = new Unit[4];
            units[0] = new Warrior();
            units[1] = new Archer();
            units[2] = new Archer();
            units[3] = new Archer();
            int attak = 0;
            int defence = 1;

            while (units.Count(x => x.HP > 0) != 1)
            {
                if (units[attak].HP > 0 && units[defence].HP > 0)
                {
                    units[attak].Attack(units[defence]);
                    attak++;
                    defence++;
                }
                if (units[attak].HP > 0 && units[defence].HP <= 0)
                {
                    defence++;
                }
                if (units[attak].HP <= 0)
                {
                    attak++;
                }

                if (defence == units.Length - 1)
                {
                    defence = 0;
                }
                if (attak == units.Length - 1)
                {
                    attak = 0;
                }

                if (attak == defence)
                {
                    attak = 0;
                    defence = 1;
                }
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            Unit[] units1 = new Unit[3];
            Unit[] units2 = new Unit[3];
            units1[0] = new Warrior();
            units1[1] = new Archer();
            units1[2] = new Warrior();
            units2[0] = new Warrior();
            units2[1] = new Archer();
            units2[2] = new Archer();

            bool teamfight = true;
            int team1 = 0;
            int team2 = 0;
            string winner = "";
            while (teamfight == true)
            {
                if (units1[team1].HP>0 && units2[team2].HP>0)
                {
                    units1[team1].Attack(units2[team2]);
                    units2[team2].Attack(units1[team1]);
                    team1++;
                    team2++;
                }
                if (units1[team1].HP > 0 && units2[team2].HP <= 0)
                {
                    team2++;
                }
                if (units1[team1].HP <= 0)
                {
                    team1++;
                }

                if (team2==units2.Length-1)
                {
                    team2 = 0;
                }
                if (team1== units1.Length - 1)
                {
                    team1 = 0;
                }

                if (units1.Count(x => x.HP > 0) == 0)
                {
                    winner = "units2 Win";
                    teamfight = false;
                }
                if (units2.Count(x => x.HP > 0) == 0)
                {
                    winner = "units1 Win";
                    teamfight = false;
                }
            }

            Console.WriteLine(winner);
        }
    }
}
