using System;
using System.Windows.Forms;

namespace Game1_Pong
{
    public partial class Form2 : Form
    {
        Random rand = new Random();
        public Form2()
        {
            InitializeComponent();
        }
        public int Difficulty { get; set; }
        public bool MusicCheck { get; set; }
        public bool LoopCheck { get; set; }
        public int P1Names { get; set; }

        static string[] p1Names =
        {
            "Lo scemo",
            "Mr.Caghetta",
            "Calamita per schiaffi",
            "Smegma",
            "Rostella",
            "Pedalò",
            "Protozoo",
            "Scoreggia",
            "I Me Contro Te",
            "Le Torri Gemelle",
            "Una scimmia cogliona",
            "Una banana",
            "La lasagna",
            "Un cesso a levitazione magnetica",
            "Una vasca da bagno",
            "Il volantino dell'Eurospin",
            "Il batuffolo di polvere sotto al mobiletto",
            "Il panettiere"
        };
        int p1NamesLength = p1Names.Length;
        public string Nick
        {
            get
            {
                return textBox1.Text;
            }
        }

        private void facile_Click(object sender, EventArgs e)
        {
            Difficulty = 1;
            Close();
        }

        private void medio_Click(object sender, EventArgs e)
        {
            Difficulty = 2;
            Close();
        }

        private void difficile_Click(object sender, EventArgs e)
        {
            Difficulty = 3;
            Close();
        }

        private void estremo_Click(object sender, EventArgs e)
        {
            Difficulty = 4;
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (textBox1.TextLength <= 0)
            {
                facile.Enabled = false;
                medio.Enabled = false;
                difficile.Enabled = false;
                estremo.Enabled = false;
            }
            else
            {
                facile.Enabled = true;
                medio.Enabled = true;
                difficile.Enabled = true;
                estremo.Enabled = true;
            }

            if (checkBox1.Checked)
            {
                MusicCheck = true;
            }
            else
            {
                MusicCheck = false;
            }

            if (checkBox2.Checked)
            {
                LoopCheck = true;
            }
            else
            {
                LoopCheck = false;
            }

            int randRes = rand.Next(0, p1NamesLength);
            textBox1.Text = $"{p1Names[randRes]}";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength <= 0)
            {
                facile.Enabled = false;
                medio.Enabled = false;
                difficile.Enabled = false;
                estremo.Enabled = false;
            }
            else
            {
                facile.Enabled = true;
                medio.Enabled = true;
                difficile.Enabled = true;
                estremo.Enabled = true;
            }

            label2.Text = $"{textBox1.MaxLength - textBox1.TextLength}/{textBox1.MaxLength}\nLimite Caratteri";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MusicCheck = true;
            }
            else
            {
                MusicCheck = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                LoopCheck = true;
            }
            else
            {
                LoopCheck = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
