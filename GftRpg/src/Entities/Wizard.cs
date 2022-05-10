using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GftRpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return $"{this.Name} Lançou um ataque Magico";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return $"{this.Name} Lançou ataque Magico super efetivo" +
                    $" com bonus {Bonus} de magia.";
            }
            else
            {
                return $"{this.Name} Lançou ataque Magico pouco efetivo" +
                    $" com bonus {Bonus} de magia.";
            }
        }
    }
}

