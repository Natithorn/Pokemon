using Pokemon.Pokemon_All;
using System.Runtime.CompilerServices;

namespace Pokemon
{
    public partial class Form1 : Form
    {
        List<Pokemon2> Pokemane = new List<Pokemon2>();
        Pokemon2 SelPokemon;
        Pokemon2 Monster;
        public Form1()
        {
            InitializeComponent();
            ClearGame();
        }



        //‚ª‡°¡ËÕπ
        private void EvoButton1_Click(object sender, EventArgs e)
        {

            if (Pokemane[0].getHP() <= 0)
            {
                MessageBox.Show("He is Dead !!");
            }
            else
            {
                SelPokemon = Pokemane[0];
                this.pictureBox1.Image = SelPokemon.getImage();
                this.textBoxName1.Text = SelPokemon.getName();
                this.textBoxHP1.Text = SelPokemon.getHP().ToString();
                this.textBoxAt1.Text = SelPokemon.getAt().ToString();
            }
        }
        private void EvoButton2_Click(object sender, EventArgs e)
        {
            if (Pokemane[1].getHP() <= 0)
            {
                MessageBox.Show("He is Dead !!");
            }
            else
            {
                SelPokemon = Pokemane[1];
                this.pictureBox1.Image = SelPokemon.getImage();
                this.textBoxName1.Text = SelPokemon.getName();
                this.textBoxHP1.Text = SelPokemon.getHP().ToString();
                this.textBoxAt1.Text = SelPokemon.getAt().ToString();
            }

        }

        private void SelPokemon3_Click(object sender, EventArgs e)
        {

            if (Pokemane[2].getHP() <= 0)
            {
                MessageBox.Show("He is Dead !!");
            }
            else
            {
                SelPokemon = Pokemane[2];
                this.pictureBox1.Image = SelPokemon.getImage();
                this.textBoxName1.Text = SelPokemon.getName();
                this.textBoxHP1.Text = SelPokemon.getHP().ToString();
                this.textBoxAt1.Text = SelPokemon.getAt().ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Pokemane[3].getHP() <= 0)
            {
                MessageBox.Show("He is Dead !!");
            }
            else
            {
                SelPokemon = Pokemane[3];
                this.pictureBox1.Image = SelPokemon.getImage();
                this.textBoxName1.Text = SelPokemon.getName();
                this.textBoxHP1.Text = SelPokemon.getHP().ToString();
                this.textBoxAt1.Text = SelPokemon.getAt().ToString();
            }
        }
        //‚ª‡°¡ËÕπ
















        //‚™«ÏMonster
        private void button1_Click(object sender, EventArgs e)
            ///Monster///
        { 
                Monster = Pokemane[4];
                this.pictureBox2.Image = Monster.getImage();
                this.textBoxName4.Text = Monster.getName();
                this.textBoxHP2.Text = Monster.getHP().ToString();
                this.textBoxAt2.Text = Monster.getAt().ToString();
        }



        //ªÿË¡‚®¡µ’
        private void Atbutton1_Click(object sender, EventArgs e)
        {
            int PokemonHP = SelPokemon.getHP();
            int PokemonAttack = SelPokemon.getAt();
            int MonsterHP = Monster.getHP();
            int MonsterAttack = Monster.getAt();
            if (SelPokemon != null && Monster != null)
            {
                if (MonsterHP > 0)
                {
                    if(PokemonHP < 0)
                    {
                        MessageBox.Show("Pokemon¢Õß§ÿ≥µ“¬·≈È« °√ÿ‡ª≈’Ë¬πµ—«„À¡Ë");
                    }
                    else
                    {
                        Monster.setHP(MonsterHP - PokemonAttack);
                        SelPokemon.setHP(PokemonHP - MonsterAttack);
                        textBoxHP1.Text = SelPokemon.getHP().ToString();
                        textBoxHP2.Text = Monster.getHP().ToString();
                    }
                }
                if (PokemonHP < 0)
                {
                    textBoxHP1.Text = "0";
                    MessageBox.Show("Pokemon¢Õß§ÿ≥µ“¬·≈È« °√ÿ‡ª≈’Ë¬πµ—«„À¡Ë");
                }
                if (Monster.getHP() < 0)
                {
                    textBoxHP2.Text = "0";
                    MessageBox.Show("Enemy Defect");
                    ClearGame();
                    return;
                }
            }
            else
            {
                MessageBox.Show("°√ÿ≥“‡≈◊Õ°Pokemon„ÀÈ§√∫§√—∫");
            }
           
        }

        void ClearGame()
        {
            Pokemane.Clear();
            Pokemane.Add(new Arbok());
            Pokemane.Add(new Diglett());
            Pokemane.Add(new Gengar());
            Pokemane.Add(new Stufful());
            Pokemane.Add(new Monster());
            textBoxAt1.Text = "";
            textBoxAt2.Text = "";
            textBoxHP1.Text = "";
            textBoxHP2.Text = "";
            textBoxName1.Text = "";
            textBoxName4.Text = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }
    }
}