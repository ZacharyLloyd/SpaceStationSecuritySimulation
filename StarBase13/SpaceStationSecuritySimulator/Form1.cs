using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceStationSecuritySimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string base16check;
        public string base2check;

        //When this button is clicked it executes this code
        private void Button1_Click(object sender, EventArgs e)
        {
            //Int for minimum int in random number generator
            int min = 0;
            //Int for max int in random number generator
            int max = 1000;
            //Give me a random number
            int randomNumberBase10 = RandomNumber(min, max);

            //convert to base 2
            string base2 = Convert.ToString(value: randomNumberBase10, toBase: 2);
            //convert to base 16
            string base16 = Convert.ToString(value: randomNumberBase10, toBase: 16);

            //Display the proper characters in the label
            label_display_base10.Text = randomNumberBase10.ToString();
            label_display_base16.Text = base16;
            label_display_base2.Text = base2;

            EnterCodes.Enabled = true;

            base16check = base16;
            base2check = base2;
        }
        //Generate a random number
        public int RandomNumber(int min, int max)
        {
            //Pick a random number
            Random random = new Random();
            //Return a number
            return random.Next(min, max);
        }

        private void EnterCodes_Click(object sender, EventArgs e)
        {
            label_display_base16.Visible = true;
            label_display_base2.Visible = true;
            if(base2check == InputBase2.Text && base16check == InputBase16.Text)
            {
                StatusMessageBox.Text = "\nBoth codes were entered corrected, Access Granted.";
                this.BackgroundImage = Properties.Resources.Access_granted;
            }
            else
            {
                StatusMessageBox.Text = "\nOne of the codes were entered incorrectly, Access Denied";
                this.BackgroundImage = Properties.Resources.explosion;
            }
        }
    }
}
