using Pokemon.pokemons;
using System.Windows.Forms;
namespace Pokemon
{
    public partial class Form1 : Form
    {
        List<Pokemons> pokemon;
        Pokemons selectedPokemon;
        Pokemons monster;
        public Form1()
        {
            InitializeComponent();
            pokemon = new List<Pokemons>();
            pokemon.Add(new Dratini());
            pokemon.Add(new Dragonair());
            pokemon.Add(new Dragonite());
            pokemon.Add(new Charmeleon());
           // pokemon.Add(new Charmander());

            this.monster = new Charmander();
            this.pictureBox2.Image = this.monster.getImage();
            this.NamePK2.Text = this.monster.getName();
            this.HPPK2.Text = this.monster.getHP().ToString();

        }
        //Dratini
        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemon[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.NamePK.Text = selectedPokemon.getName();
            this.HPPK.Text = selectedPokemon.getHP().ToString();
            
            
        }
        //Dragonair
        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemon[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.NamePK.Text = selectedPokemon.getName();
            this.HPPK.Text = selectedPokemon.getHP().ToString();

        }
        //Dragonite
        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemon[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.NamePK.Text = selectedPokemon.getName();
            this.HPPK.Text = selectedPokemon.getHP().ToString();

        }
        // Charmeleon
        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemon[3];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.NamePK.Text = selectedPokemon.getName();
            this.HPPK.Text = selectedPokemon.getHP().ToString();
        }
        // Player Attack
        private void button5_Click(object sender, EventArgs e)
        {
            int atk= Math.Abs(this.monster.getDefense() - this.selectedPokemon.getAttack());
            this.monster.takeDamage(atk);
            this.HPPK2.Text = monster.getHP().ToString();
            if (monster.getHP() <= 0)
            {
                MessageBox.Show("YOU WIN");
                Application.Exit();
            }
        }
        // HP My Pokemons + 50
        private void button7_Click(object sender, EventArgs e)
        {
            this.HPPK.Text = this.selectedPokemon.getHealth().ToString();
            button7.Enabled = false;
        }
        // def my Pokemons + 50
        private void button8_Click(object sender, EventArgs e)
        {
            this.selectedPokemon.getDef();
            button8.Enabled = false;
        }
        // HP monster + 50
        private void button9_Click(object sender, EventArgs e)
        {
            this.HPPK2.Text = this.monster.getHealth().ToString();
            button9.Enabled = false;
        }
        // def monster + 50
        private void button10_Click(object sender, EventArgs e)
        {
            this.monster.getDef();
            button10.Enabled = false;
        }
        // Monster Attack
        private void button6_Click(object sender, EventArgs e)
        {           
            int atk = Math.Abs(this.selectedPokemon.getDefense() - this.monster.getAttack());
            this.selectedPokemon.takeDamage(atk);
            this.HPPK.Text = selectedPokemon.getHP().ToString();            
            if(pokemon[0].getHP() <= 0)
            {
                button1.Enabled = false;
            }
            else if (pokemon[1].getHP() <= 0)
            {
                button2.Enabled = false;
            }
             else if (pokemon[2].getHP() <= 0)
            {
                button3.Enabled = false;
            }
             else if (pokemon[3].getHP() <= 0)
            {
                button4.Enabled = false;
            }
        }
    }
}