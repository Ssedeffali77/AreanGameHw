using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreanGameHw
{
    namespace ArenaGame.Heroes
    {
        public class Wizard : Hero
        {
            public Wizard(string name, double armor, double strength, IWeapon weapon) :
                base(name, armor, strength, weapon)
            {
            }

            public override double Attack()
            {
                double damage = base.Attack();
                if (Weapon is MagicWand magicWand)
                {
                    magicWand.UseSpecialAbility(this);  // Използва специалната способност на Магическия Жезъл
                }
                return damage;
            }
        }
    }

    {
    }
}
