using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GftRpg.src.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int Level;
        public string HeroType;
        public Hero()
        {

        }
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        // override é sobreescrita
        public override string ToString()
        {
            return $"{this.Name} {this.Level} {this.HeroType}";
        }
        public virtual string Attack()
        {
            return $"{this.Name} Atacou com uma espada";
        }
    }
}