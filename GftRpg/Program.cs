using System;
using GftRpg.src.Entities;
namespace GftRpg
{
    class Program
    {
        public static void Main(string[] args)
        {
            Knight hero = new Knight("Coringa Indiano", 30, "Joker Crazy");
            Wizard wizard = new Wizard("Jussara", 30, "White Wizard");

            Random PowerBonus = new Random();

            Console.WriteLine(hero.Attack());
            Console.WriteLine(wizard.Attack(Bonus: PowerBonus.Next(1, 11)));
            Console.ReadKey();

        }
    }
}

