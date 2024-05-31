using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameHw
    namespace ArenaGame.Weapons
{
    // Оръжие - Щит
    public class Shield : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Shield(string name)
        {
            Name = name;
            AttackDamage = 10;  // Щети от атака
            BlockingPower = 20;  // Сила на блокиране
        }
    }
}

    

