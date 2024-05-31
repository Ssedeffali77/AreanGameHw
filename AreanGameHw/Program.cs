
using ArenaGameHw;
using System;
using System;

using System;
using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;
using AreanGameHw.ArenaGame.Heroes;
using AreanGameHw.ArenaGame.Weapons;
using ArenaGameHw.ArenaGame.Heroes;
using ArenaGameHw.ArenaGame.Weapons;

namespace ConsoleArenaGame
{
    class Program
    {
        // Метод за уведомяване при атака
        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }

        static void Main(string[] args)
        {
            // Създаване на герои с нови оръжия
            Hero knight = new Knight("Knight", 10, 20, new Sword("Sword"));
            Hero wizard = new Wizard("Wizard", 5, 15, new MagicWand("Magic Wand"));
            Hero archer = new Archer("Archer", 8, 18, new Bow("Bow"));

            // Създаване на играта и задаване на героите
            GameEngine gameEngine = new GameEngine()
            {
                HeroA = knight,
                HeroB = wizard,
                NotificationsCallBack = ConsoleNotification
            };

            // Започване на битката
            gameEngine.Fight();

            // Показване на победителя
            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner}");

            // Втора битка с нови герои
            GameEngine secondGameEngine = new GameEngine()
            {
                HeroA = wizard,
                HeroB = archer,
                NotificationsCallBack = ConsoleNotification
            };

            // Започване на втората битка
            secondGameEngine.Fight();

            // Показване на победителя от втората битка
            Console.WriteLine();
            Console.WriteLine($"And the winner of the second battle is {secondGameEngine.Winner}");
        }
    }
}
