using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero.Heroes
{
    public class Hero
    { public int Id { get; set; }
        public string HeroName { get; set; }
        public string RealName { get; set; }

        public override string ToString()
        {
            return $"{HeroName} : {RealName}";
        }

    }
}
