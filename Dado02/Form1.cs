using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dado02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int valor1 = rnd1.Next(1, 7);
            textBox1.Text = Convert.ToString(valor1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rod = Convert.ToInt16(textBox5.Text);
            if (rod > 3)
            {
                MessageBox.Show("Fim de jogo");

                if (Convert.ToInt16(textBox3.Text) == Convert.ToInt16(textBox4.Text))
                {

                    MessageBox.Show("jogoempatado");
                    Application.Exit();
                }
            }

            else
            {
                Random rnd2 = new Random();
                int valor2 = rnd2.Next(1, 7);
                textBox2.Text = Convert.ToString(valor2);


                rod += 1;
                textBox5.Text = Convert.ToString(rod);
                if (Convert.ToInt16(textBox1.Text) > Convert.ToInt16(textBox2.Text))
                {
                    MessageBox.Show("Player 1 ganhou");
                    int p1 = Convert.ToInt16(textBox3.Text);
                    p1 += 1;
                    textBox3.Text = Convert.ToString(p1);
                }
                else if (Convert.ToInt16(textBox1.Text) < Convert.ToInt16(textBox2.Text))
                {
                    MessageBox.Show("Player 2 ganhou");
                    int p2 = Convert.ToInt16(textBox4.Text);
                    p2 += 1;
                    textBox4.Text = Convert.ToString(p2);
                }
                else { MessageBox.Show("JOGO EMPATADO"); }
                int pp1 = Convert.ToInt16(textBox3.Text);
                int pp2 = Convert.ToInt16(textBox4.Text);
                if (pp1 == 2)
                {
                    MessageBox.Show("Player 1 Vencedor");
                    Application.Exit();
                }
                else if (pp2 == 2)
                {
                    MessageBox.Show("Player 2 vencedor");
                    Application.Exit();
                }




            }

        }
    }
}
