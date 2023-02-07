using Pokemon.Pokemon_All;
using System.Runtime.CompilerServices;

namespace Pokemon
{
    public partial class Form1 : Form
    {
        List<Pokemon2> Pokemane;
        Pokemon2 SelPokemon;
        public Form1()
        {
            InitializeComponent();
            Pokemane = new List<Pokemon2>();
            Pokemane.Add(new Stufful());
            Pokemane.Add(new Diglett());
            Pokemane.Add(new Arbok());
            Pokemane.Add(new Gengar());
            Pokemane.Add(new Monster());

        }
        private void EvoButton1_Click(object sender, EventArgs e)
        {

            if (Pokemane[0].getHP() <= 0)
            {
                MessageBox.Show("He is Dead !!");
            }
            else
                SelPokemon = Pokemane[0];
                this.pictureBox1.Image = SelPokemon.getImage();
                this.textBoxName1.Text = SelPokemon.getName();
                this.textBoxHP1.Text = SelPokemon.getHP().ToString();
                this.textBoxAt1.Text = SelPokemon.getAt().ToString();
        }
        private void EvoButton2_Click(object sender, EventArgs e)
        {
            if (Pokemane[1].getHP() <= 0)
            {
                MessageBox.Show("He is Dead !!");
            }
            else
                SelPokemon = Pokemane[1];
                this.pictureBox1.Image = SelPokemon.getImage();
                this.textBoxName1.Text = SelPokemon.getName();
                this.textBoxHP1.Text = SelPokemon.getHP().ToString();
                this.textBoxAt1.Text = SelPokemon.getAt().ToString();

        }

        private void SelPokemon3_Click(object sender, EventArgs e)
        {

            if (Pokemane[2].getHP() <= 0)
            {
                MessageBox.Show("He is Dead !!");
            }
            else
                SelPokemon = Pokemane[2];
                this.pictureBox1.Image = SelPokemon.getImage();
                this.textBoxName1.Text = SelPokemon.getName();
                this.textBoxHP1.Text = SelPokemon.getHP().ToString();
                this.textBoxAt1.Text = SelPokemon.getAt().ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Pokemane[3].getHP() <= 0)
            {
                MessageBox.Show("He is Dead !!");
            }
            else
                SelPokemon = Pokemane[3];
                this.pictureBox1.Image = SelPokemon.getImage();
                this.textBoxName1.Text = SelPokemon.getName();
                this.textBoxHP1.Text = SelPokemon.getHP().ToString();
                this.textBoxAt1.Text = SelPokemon.getAt().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
            ///Monster///
        { 
                SelPokemon = Pokemane[4];
                this.pictureBox2.Image = SelPokemon.getImage();
                this.textBoxName4.Text = SelPokemon.getName();
                this.textBoxHP2.Text = SelPokemon.getHP().ToString();
                this.textBoxAt2.Text = SelPokemon.getAt().ToString();
        }

        private void Atbutton1_Click(object sender, EventArgs e)
        {
            if (SelPokemon.getHP() > 0)
            {
                int Damage = (SelPokemon.getAt() - SelPokemon.getHP());
                textBoxHP2.Text = Damage.ToString();   
            }
            else
            {
                textBoxHP2.Text = "0";
                MessageBox.Show("Enemy Defect");
            }

           
        }
    }
}