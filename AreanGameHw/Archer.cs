using AreanGameHw.ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameHw
{
        namespace ArenaGame.Heroes
    {
        public class Archer : Hero
        {
            public Archer(string name, double armor, double strength, IWeapon weapon) :
                base(name, armor, strength, weapon)
            {
            }

            public override double Attack()
            {
                double damage = base.Attack();
                if (Weapon is Bow bow)
                {
                    bow.UseSpecialAbility();  // Използва специалната способност на Лъка
                }
                return damage;
            }
        }
    }

    {
    }
}
