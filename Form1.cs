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
            Pokemane.Add(new Bewear());
            Pokemane.Add(new Diglett());
            Pokemane.Add(new Dugtrio());
            Pokemane.Add(new Ekans());
            Pokemane.Add(new Arbok());
            Pokemane.Add(new Gastly());
            Pokemane.Add(new Haunter());
            Pokemane.Add(new Gengar());

        }
        private void EvoButton1_Click(object sender, EventArgs e)
        {
            SelPokemon = Pokemane[0];
            this.pictureBox1.Image = SelPokemon.getImage();
            this.textBoxName1.Text = SelPokemon.getName();
            this.textBoxHP1.Text = SelPokemon.getHP().ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SelPokemon = Pokemane[1];
            this.pictureBox1.Image = SelPokemon.getImage();
            this.textBoxName1.Text = SelPokemon.getName();
            this.textBoxHP1.Text = SelPokemon.getHP().ToString();

        }
        private void EvoButton2_Click(object sender, EventArgs e)
        {
            SelPokemon = Pokemane[2];
            this.pictureBox2.Image = SelPokemon.getImage();
            this.textBoxName2.Text = SelPokemon.getName();
            this.textBoxHP2.Text = SelPokemon.getHP().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelPokemon = Pokemane[3];
            this.pictureBox2.Image = SelPokemon.getImage();
            this.textBoxName2.Text = SelPokemon.getName();
            this.textBoxHP2.Text = SelPokemon.getHP().ToString();
        }

        private void EvoButton3_Click(object sender, EventArgs e)
        {
            SelPokemon = Pokemane[4];
            this.pictureBox3.Image = SelPokemon.getImage();
            this.textBoxName3.Text = SelPokemon.getName();
            this.textBoxHP3.Text = SelPokemon.getHP().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelPokemon = Pokemane[5];
            this.pictureBox3.Image = SelPokemon.getImage();
            this.textBoxName3.Text = SelPokemon.getName();
            this.textBoxHP3.Text = SelPokemon.getHP().ToString();
        }

        private void EvoButton4_Click(object sender, EventArgs e)
        {
            SelPokemon = Pokemane[6];
            this.pictureBox4.Image = SelPokemon.getImage();
            this.textBoxName4.Text = SelPokemon.getName();
            this.textBoxHP4.Text = SelPokemon.getHP().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelPokemon = Pokemane[7];
            this.pictureBox4.Image = SelPokemon.getImage();
            this.textBoxName4.Text = SelPokemon.getName();
            this.textBoxHP4.Text = SelPokemon.getHP().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SelPokemon = Pokemane[8];
            this.pictureBox4.Image = SelPokemon.getImage();
            this.textBoxName4.Text = SelPokemon.getName();
            this.textBoxHP4.Text = SelPokemon.getHP().ToString();
        }
    }
}