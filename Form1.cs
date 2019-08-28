using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlipThatCoin
{
    public partial class Form1 : Form
    {
        // Initialize counters
        int headsCount = 0;
        int tailsCount = 0;
        int headsRoundCount = 0;
        int tailsRoundCount = 0;
        Boolean game_over_flag = true;

        public Form1()
        {
            InitializeComponent();
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox2.TextAlign = HorizontalAlignment.Center;
            FirstRun();
        }

        private void FirstRun()
        {
            headsCount = 0;
            tailsCount = 0;
            headsRoundCount = 0;
            tailsRoundCount = 0;
            headsRoundText.Text = "";
            tailsRoundText.Text = "";
            heads_check1.Checked = false;
            heads_check2.Checked = false;
            tails_check1.Checked = false;
            tails_check2.Checked = false;
            headsLabel.Visible = true;
            heads_check1.Visible = true;
            heads_check2.Visible = true;
            tailsLabel.Visible = true;
            tails_check1.Visible = true;
            tails_check2.Visible = true;
            roundTextView.Visible = true;
            headsRoundText.Visible = true;
            tailsRoundText.Visible = true;
            button_flip.Enabled = false;
            button_flip.BackColor = System.Drawing.Color.Transparent;
            button_single.Enabled = true;
            button_best2of3.Enabled = true;
            button_single.BackColor = System.Drawing.Color.DarkGray;
            button_best2of3.BackColor = System.Drawing.Color.DarkGray;
            textBox1.Text = ("Please select a mode.");
        }

        // 
        private void button_single_click(object sender, EventArgs e)
        {
            // Change GUI and enter Ready state
            headsCount = 0;
            tailsCount = 0;
            headsRoundCount = 0;
            tailsRoundCount = 0;
            headsRoundText.AppendText("");
            tailsRoundText.AppendText("");
            headsLabel.Visible = false;
            heads_check1.Visible = false;
            heads_check2.Visible = false;
            tailsLabel.Visible = false;
            tails_check1.Visible = false;
            tails_check2.Visible = false;
            roundTextView.Visible = false;
            headsRoundText.Visible = false;
            tailsRoundText.Visible = false;
            button_single.BackColor = System.Drawing.Color.Green;
            button_best2of3.BackColor = System.Drawing.Color.DarkGray;
            textBox1.Clear();
            textBox2.Text = "";
            pictureBox1.Image = FlipThatCoin.Properties.Resources.unknown;
            pictureBox1.Refresh();
            pictureBox1.Visible = true;
            game_over_flag = false;
            ReadyToFlip();
        }

        private void ReadyToFlip()
        {
            if (game_over_flag == true)
            {
                textBox1.AppendText("");
            }
            else
                if ((button_single.BackColor == System.Drawing.Color.DarkGray) && (button_best2of3.BackColor == System.Drawing.Color.DarkGray))
            {
                    // Enable buttons
                    button_flip.Enabled = true;
                    button_reset.Enabled = true;
            }
            else
            {
                button_flip.Enabled = true;
                button_flip.BackColor = System.Drawing.Color.Goldenrod;
                button_reset.Enabled = true;
                textBox1.AppendText("Ready!");
                textBox1.AppendText(Environment.NewLine);
            }
        }

        private void button_best2of3_click(object sender, EventArgs e)
        {
            // Change GUI and enter Ready state
            headsCount = 0;
            tailsCount = 0;
            headsRoundCount = 0;
            tailsRoundCount = 0;
            headsRoundText.Text = headsRoundCount.ToString();
            tailsRoundText.Text = tailsRoundCount.ToString();
            heads_check1.Checked = false;
            heads_check2.Checked = false;
            tails_check1.Checked = false;
            tails_check2.Checked = false;
            headsLabel.Visible = true;
            heads_check1.Visible = true;
            heads_check2.Visible = true;
            tailsLabel.Visible = true;
            tails_check1.Visible = true;
            tails_check2.Visible = true;
            roundTextView.Visible = true;
            headsRoundText.Visible = true;
            tailsRoundText.Visible = true;
            button_best2of3.BackColor = System.Drawing.Color.Green;
            button_single.BackColor = System.Drawing.Color.DarkGray;
            textBox1.Clear();
            textBox2.Text = "";
            pictureBox1.Image = FlipThatCoin.Properties.Resources.unknown;
            pictureBox1.Refresh();
            pictureBox1.Visible = true;
            game_over_flag = false;
            ReadyToFlip();
        }

        // Flip a coin, display result and change picture
        private void button_flip_click(object sender, EventArgs e)
        {
            if (game_over_flag == false)
            {
                textBox2.Text = "";
                int coin = CoinFlip();
                textBox1.AppendText("...");
                textBox1.AppendText(Environment.NewLine);
                Thread.Sleep(1000); // wait a second
                if (coin == 0)
                {
                    pictureBox1.Image = FlipThatCoin.Properties.Resources.heads;
                    pictureBox1.Refresh();
                    pictureBox1.Visible = true;
                    textBox2.AppendText("It's heads!");
                    LandedOnHeads();
                }
                else
                {
                    pictureBox1.Image = FlipThatCoin.Properties.Resources.tails;
                    pictureBox1.Refresh();
                    pictureBox1.Visible = true;
                    textBox2.AppendText("It's tails!");
                    LandedOnTails();
                }
                if ((button_best2of3.BackColor == System.Drawing.Color.Green) && ((headsCount >= 2) || (tailsCount >= 2)))
                {
                    MatchWinner();
                }

                ReadyToFlip();
            }
        }

        private void MatchWinner()
        {
            if (tailsCount > headsCount)
            {
                tailsRoundCount++;
                tailsRoundText.Text = tailsRoundCount.ToString();
            }
            if (headsCount > tailsCount)
            {
                headsRoundCount++;
                headsRoundText.Text = headsRoundCount.ToString();
            }

            headsCount = 0;
            tailsCount = 0;
            heads_check1.Checked = false;
            heads_check2.Checked = false;
            tails_check1.Checked = false;
            tails_check2.Checked = false;

            if (button_best2of3.BackColor == System.Drawing.Color.Green && (headsRoundCount >= 2 || tailsRoundCount >= 2)
                    && (headsRoundCount != tailsRoundCount))
            {
                //game win:
                Winner();
                GameOver();
            }
        }

        private void Winner()
        {
            if (headsCount > tailsCount)
            {
                textBox2.Clear();
                textBox2.Text = "Heads wins!";
            }
            else
            {
                textBox2.Clear();
                textBox2.Text = "Tails wins!";
            }
        }

        private void GameOver()
        {
            button_flip.Enabled = false;
            button_flip.BackColor = System.Drawing.Color.Transparent;
            textBox1.Clear();
            game_over_flag = true;
            textBox1.Text = "Game Over";
        }

        // Handling heads counter and checkmarks
        private void LandedOnHeads()
        {
            if ((headsCount == 0) && (heads_check1.Checked == false))
            {
                headsCount = 1;
                heads_check1.Checked = true;
            }
            else
            {
                if (headsCount == 1)
                {
                    headsCount = 2;
                    heads_check2.Checked = true;
                }
            }
        }

        // Handling heads counter and checkmarks
        private void LandedOnTails()
        {
            if ((tailsCount == 0) && (tails_check1.Checked == false))
            {
                tailsCount = 1;
                tails_check1.Checked = true;
            }
            else
            {
                if (tailsCount == 1)
                {
                    tailsCount = 2;
                    tails_check2.Checked = true;
                }
            }
        }

        // Get binary random number and bring it back to button_flip_click()
        private int CoinFlip()
        {
            pictureBox1.Image = FlipThatCoin.Properties.Resources.unknown;
            pictureBox1.Refresh();
            pictureBox1.Visible = true;
            // disable button
            button_flip.Enabled = false;
            button_flip.BackColor = System.Drawing.Color.Transparent;
            Random binaryrand = new Random();
            int flip_result = binaryrand.Next(0, 2);
            return flip_result;
        }

        // Set the game to default state:
        // Clear textboxes and counters, remove picture, go back to FirstRun()
        private void button_reset_click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            pictureBox1.Image = FlipThatCoin.Properties.Resources.unknown;
            pictureBox1.Refresh();
            pictureBox1.Visible = true;
            FirstRun();
        }

        private void button_info_click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Form2"] as Form2) != null)
            {
                //Form is already open, do nothing
            }
            else
            {
                // Form is not open, create and show it
                Form2 credits = new Form2();
                credits.ShowDialog();
            }
        }
    }
}
