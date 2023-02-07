using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon_All
{
    internal class Monster : Pokemon2
    {
        public Monster()
        {
            this.name = "Inwza";
            this.HP = 120;
            this.Atk = 35;
            this._image = Properties.Resources.Gastly2;
        }
    }
}
