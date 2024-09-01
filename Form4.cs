using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Guessing_Game_App
{
    public partial class Form4 : Form
    {
        static Random random = new Random();
        int rand = random.Next(1, 4);

        public Form4()
        {
            MaximizeBox = false;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rock = "rock";
            string comp;
            switch (rand)
            {
                case 1:
                    comp = "rock";
                    break;
                case 2:
                    comp = "paper";
                    break;
                default:
                    comp = "scissors";
                    break;
            }
            MessageBox.Show($"I chose {comp}\n\nYou chose {rock}", "Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (rock == comp)
            {
                DialogResult dr = MessageBox.Show($"DRAW!!!", "Answer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Retry)
                {
                    Hide();
                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                }
            }
            else if (comp == "scissors")
            {
                DialogResult dr = MessageBox.Show($"GG! You won!", "Answer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Retry)
                {
                    Hide();
                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Too bad... You lost!", "Answer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Retry)
                {
                    Hide();
                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string paper = "paper";
            string comp;
            switch (rand)
            {
                case 1:
                    comp = "rock";
                    break;
                case 2:
                    comp = "paper";
                    break;
                default:
                    comp = "scissors";
                    break;
            }
            MessageBox.Show($"I chose {comp}\n\nYou chose {paper}", "Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (paper == comp)
            {
                DialogResult dr = MessageBox.Show("DRAW!!!", "Answer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Retry)
                {
                    Hide();
                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                }
            }
            else if (comp == "rock")
            {
                DialogResult dr = MessageBox.Show("GG! You won!", "Answer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Retry)
                {
                    Hide();
                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Too bad... You lost!", "Answer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Retry)
                {
                    Hide();
                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string scissors = "scissors";
            string comp;
            switch (rand)
            {
                case 1:
                    comp = "rock";
                    break;
                case 2:
                    comp = "paper";
                    break;
                default:
                    comp = "scissors";
                    break;
            }
            MessageBox.Show($"I chose {comp}\n\nYou chose {scissors}", "Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (scissors == comp)
            {
                DialogResult dr = MessageBox.Show("DRAW!!!", "Answer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Retry)
                {
                    Hide();
                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                }
            }
            else if (comp == "paper")
            {
                DialogResult dr = MessageBox.Show("GG! You won!", "Answer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Retry)
                {
                    Hide();
                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Too bad... You lost!", "Answer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Retry)
                {
                    Hide();
                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                }
            }
        }
    }
}
