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
    public partial class Form3 : Form
    {
        static Random random = new Random();
        int rand1 = random.Next(0, 21);
        public Form3()
        {
            MaximizeBox = false;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            randomNumberText.Text = rand1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rand2 = random.Next(0, 21);
            MessageBox.Show($"Second Number: {rand2}", "Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (rand2 > rand1)
            {
                DialogResult dr1 = MessageBox.Show("GG! You won!", "Answer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (dr1 == DialogResult.Retry)
                {
                    Hide();
                    Form3 f3 = new Form3();
                    f3.ShowDialog();
                }
            }
            else
            {
                DialogResult dr1 = MessageBox.Show("Too bad... You lost!", "Answer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (dr1 == DialogResult.Retry)
                {
                    Hide();
                    Form3 f3 = new Form3();
                    f3.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rand2 = random.Next(0, 21);
            DialogResult dr = MessageBox.Show($"Second Number: {rand2}", "Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (rand2 < rand1)
            {
                DialogResult dr1 = MessageBox.Show("GG! You won!", "Answer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (dr1 == DialogResult.Retry)
                {
                    Hide();
                    Form3 f3 = new Form3();
                    f3.ShowDialog();
                }
            }
            else
            {
                DialogResult dr1 = MessageBox.Show("Too bad... You lost!", "Answer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (dr1 == DialogResult.Retry)
                {
                    Hide();
                    Form3 f3 = new Form3();
                    f3.ShowDialog();
                }
            }
        }
    }
}
