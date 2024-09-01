using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_App
{
    public partial class Form4 : Form
    {
        private char Player = 'X';

        private bool gameEnd = false;

        private PictureBox[,] pictureBoxes;

        public Form4()
        {
            InitializeComponent();
            InitializePictureBoxes();
        }

        private void InitializePictureBoxes()
        {
            pictureBoxes = new PictureBox[,]
            {
                { pictureBox2, pictureBox3, pictureBox4 },
                { pictureBox5, pictureBox6, pictureBox7 },
                { pictureBox8, pictureBox9, pictureBox10 }
            };

            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Tag = string.Empty;
                pictureBox.Click += PictureBox_Click;
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender;
            if (clickedPictureBox.Image == null)
            {
                clickedPictureBox.Image = (Player == 'X') ? Properties.Resources.X_image : Properties.Resources.O_image;
                clickedPictureBox.Tag = Player.ToString();

                if (HasWon(Player))
                {
                    gameEnd = true;
                    MessageBox.Show($"GG! You Won! ╰(*°▽°*)╯", "Congrats ^_^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (IsBoardFull())
                {
                    gameEnd = true;
                    MessageBox.Show($"DRAW!?! (⊙ˍ⊙)", "Seriously? :/", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Player = (Player == 'X') ? 'O' : 'X';
                    if (Player == 'O')
                    {
                        ComputerMove();
                        Player = 'X';
                    }
                }
            }
        }

        private void ComputerMove()
        {
            if (gameEnd) return;

            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if (pictureBox.Image == null)
                {
                    pictureBox.Image = Properties.Resources.O_image;
                    pictureBox.Tag = "O";
                    break;
                }
            }

            if (HasWon('O'))
            {
                gameEnd = true;
                MessageBox.Show($"Too bad. I Won! (～￣▽￣)～", "Hehe boi! ( •̀ ω •́ )✧", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (IsBoardFull())
            {
                gameEnd = true;
                MessageBox.Show($"DRAW!?! (⊙ˍ⊙)", "Seriously? :/", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool HasWon(char player)
        {
            //rows
            for (int i = 0; i < 3; i++)
            {
                if (pictureBoxes[i, 0].Tag.ToString() == player.ToString() &&
                    pictureBoxes[i, 1].Tag.ToString() == player.ToString() &&
                    pictureBoxes[i, 2].Tag.ToString() == player.ToString())
                { return true; }
            }

            //colums
            for (int i = 0; i < 3; i++)
            {
                if (pictureBoxes[0, i].Tag.ToString() == player.ToString() &&
                    pictureBoxes[1, i].Tag.ToString() == player.ToString() &&
                    pictureBoxes[2, i].Tag.ToString() == player.ToString())
                { return true; }
            }

            //diagonals
            if (pictureBoxes[0, 0].Tag.ToString() == player.ToString() &&
                pictureBoxes[1, 1].Tag.ToString() == player.ToString() &&
                pictureBoxes[2, 2].Tag.ToString() == player.ToString())
            { return true; }

            if (pictureBoxes[0, 2].Tag.ToString() == player.ToString() &&
                pictureBoxes[1, 1].Tag.ToString() == player.ToString() &&
                pictureBoxes[2, 0].Tag.ToString() == player.ToString())
            { return true; }

            return false;
        }

        private bool IsBoardFull()
        {
            foreach (PictureBox pictureBox in tableLayoutPanel1.Controls)
            {
                if (pictureBox.Image == null)
                    return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
