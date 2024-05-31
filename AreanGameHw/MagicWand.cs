using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameHw
    namespace ArenaGame.Weapons
{
    // Оръжие - Магически жезъл
    public class MagicWand : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public MagicWand(string name)
        {
            Name = name;
            AttackDamage = 35;  // Щети от атака
            BlockingPower = 3;  // Сила на блокиране
        }

        // Специална способност - магическа атака
        public void UseSpecialAbility(Hero target)
        {
            target.TakeDamage(30);  // Нанася 30 щети на целта
            Console.WriteLine($"{target.Name} is hit by a magic attack and takes 30 damage!");
        }
    }
    {
    }
}
