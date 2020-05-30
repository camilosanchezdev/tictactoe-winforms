using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image xbutton = Properties.Resources.x_button;
        Image obutton = Properties.Resources.o_button;

        List<System.Windows.Forms.PictureBox> blanks = new List<System.Windows.Forms.PictureBox>();
        public void AddBox()
        {
            blanks.Add(pictureBox1);
            blanks.Add(pictureBox2);
            blanks.Add(pictureBox3);
            blanks.Add(pictureBox4);
            blanks.Add(pictureBox5);
            blanks.Add(pictureBox6);
            blanks.Add(pictureBox7);
            blanks.Add(pictureBox8);
            blanks.Add(pictureBox9);
        }
        Random rnd = new Random();
        int clicks = 5;
        int playerScore = 0;
        int pcScore = 0;
        bool win = false;
        public void pcChoice()
        {
            
            int numeroRandom = rnd.Next(0, 9);
            while ((blanks[numeroRandom].Image == obutton || blanks[numeroRandom].Image == xbutton) && clicks > 0)
            {
                numeroRandom = rnd.Next(0, 9);
            }
            if (clicks != 0)
            {
                blanks[numeroRandom].Image = obutton;
                blanks[numeroRandom].Enabled = false;
                // check row PC

                for (int i = 0; i < blanks.Count; i += 3)
                {
                    if (blanks[i].Image == obutton && blanks[i + 1].Image == obutton && blanks[i + 2].Image == obutton)
                    {
                        label8.Text = "PC Wins";
                        ButtonsActive(false);
                        pcScore++;
                        win = true;
                        clicks = 0;
                        return;
                    }
                }
                //  check column PC
                for (int i = 0; i < 3; i++)
                {
                    if (blanks[i].Image == obutton && blanks[i + 3].Image == obutton && blanks[i + 6].Image == obutton)
                    {
                        label8.Text = "PC Wins";
                        ButtonsActive(false);
                        pcScore++;
                        win = true;
                        clicks = 0;
                        return;
                    }
                }
                // check diagonal PC
                if (blanks[0].Image == obutton && blanks[4].Image == obutton && blanks[8].Image == obutton)
                {
                    label8.Text = "PC Wins";
                    ButtonsActive(false);
                    pcScore++;
                    win = true;
                    clicks = 0;
                    return;
                }
                if (blanks[2].Image == obutton && blanks[4].Image == obutton && blanks[6].Image == obutton)
                {
                    label8.Text = "PC Wins";
                    ButtonsActive(false);
                    pcScore++;
                    win = true;
                    clicks = 0;
                    return;
                }
            }
        }
        public void Check()
        {
            AddBox();
            // check row player
            for (int i = 0; i < blanks.Count; i += 3)
            {
                if (blanks[i].Image == xbutton && blanks[i + 1].Image == xbutton && blanks[i + 2].Image == xbutton)
                {
                    label8.Text = "Player Wins";
                    ButtonsActive(false);
                    playerScore++;
                    win = true;
                    clicks = 0;
                    return;
                }
            }
            // check column player
            for (int i = 0; i < 3; i ++)
            {
                if (blanks[i].Image == xbutton && blanks[i + 3].Image == xbutton && blanks[i + 6].Image == xbutton)
                {
                    label8.Text = "Player Wins";
                    ButtonsActive(false);
                    playerScore++;
                    win = true;
                    clicks = 0;
                    return; 
                }
            }
            // check diagonal player
            if (blanks[0].Image == xbutton && blanks[4].Image == xbutton && blanks[8].Image == xbutton)
            {
                label8.Text = "Player Wins";
                ButtonsActive(false);
                playerScore++;
                win = true;
                clicks = 0;
                return;
            }
            if (blanks[2].Image == xbutton && blanks[4].Image == xbutton && blanks[6].Image == xbutton)
            {
                label8.Text = "Player Wins";
                ButtonsActive(false);
                playerScore++;
                win = true;
                clicks = 0;
                return;
            }
            if (clicks == 0)
            {
                label8.Text = "Tie";
                ButtonsActive(false);
            }
        }
        public void Score()
        {
            if (win)
            {
                label5.Text = playerScore.ToString("00");
                label6.Text = pcScore.ToString("00");
            }
        }
        public void ButtonsActive(bool x)
        {
            pictureBox1.Enabled = x;
            pictureBox2.Enabled = x;
            pictureBox3.Enabled = x;
            pictureBox4.Enabled = x;
            pictureBox5.Enabled = x;
            pictureBox6.Enabled = x;
            pictureBox7.Enabled = x;
            pictureBox8.Enabled = x;
            pictureBox9.Enabled = x;
        }
        public void Functions()
        {
            Check();
            pcChoice();
            Score();
        }
        // Spaces
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = xbutton;
            pictureBox1.Enabled = false;
            clicks--;
            Functions();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = xbutton;
            pictureBox3.Enabled = false;
            clicks--;
            Functions();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = xbutton;
            pictureBox4.Enabled = false;
            clicks--;
            Functions();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = xbutton;
            pictureBox5.Enabled = false;
            clicks--;
            Functions();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = xbutton;
            pictureBox2.Enabled = false;
            clicks--;
            Functions();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = xbutton;
            pictureBox6.Enabled = false;
            clicks--;
            Functions();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = xbutton;
            pictureBox7.Enabled = false;
            clicks--;
            Functions();
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = xbutton;
            pictureBox8.Enabled = false;
            clicks--;
            Functions();
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = xbutton;
            pictureBox9.Enabled = false;
            clicks--;
            Functions();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Reset
            ButtonsActive(true);
            foreach (var item in blanks)
            {
                item.Image = null;
            }
            clicks = 5;
            label8.Text = "";
        }
    }
}
