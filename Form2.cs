using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlipThatCoin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "Flip That Coin!";
        }

        private void Go_To_My_Website(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.evandevizio.com");
        }
    }
}
