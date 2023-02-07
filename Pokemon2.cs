using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Pokemon2
    {
        protected  string  name;
        protected  int HP;
        protected int Atk;
        protected Bitmap _image;
        public Bitmap getImage()
        {
            return _image;
        }
        public string getName() { return this.name; }
        public int getHP() { return this.HP;}
        public int getAt() { return this.Atk; }
        public void setHP(int hp)
        {
            HP = hp;
        }


    }
}
