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
    public partial class Form5 : Form
    {
        static Random random = new Random();
        int rand = random.Next(1, 6);

        public Form5()
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
            int input = Convert.ToInt32(guessedNum.Text);
            if (input > 0 && input <= 5)
            {
                MessageBox.Show($"I have {rand} fingers\n\nYou entered {input} fingers", "Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (input == rand)
                {
                    DialogResult dr = MessageBox.Show("GG! You won!", "Answer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.Retry)
                    {
                        Hide();
                        Form5 f5 = new Form5();
                        f5.ShowDialog();
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Too bad... You lost!", "Answer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.Retry)
                    {
                        Hide();
                        Form5 f5 = new Form5();
                        f5.ShowDialog();
                    }
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Number out of range", "Answer", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Retry)
                {
                    Hide();
                    Form5 f5 = new Form5();
                    f5.ShowDialog();
                }
            }
        }
    }
}
