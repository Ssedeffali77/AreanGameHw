using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreanGameHw
    namespace ArenaGame.Weapons
{
    // Оръжие - Лък
    public class Bow : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Bow(string name)
        {
            Name = name;
            AttackDamage = 25;  // Щети от атака
            BlockingPower = 5;  // Сила на блокиране
        }
    }
    }

