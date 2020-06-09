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
            int max = 10;
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

            //Set enter codes button to enabled
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
            //Exception handling to ensure base2check is an int
            if (int.TryParse(base2check, out int BinaryCheck))
            {
                MessageBox.Show("This is a valid integer");
            }
            //If it is not display a message
            else
            {
                MessageBox.Show("Use integers only!");
                //Change the background image to show a bad result
                this.BackgroundImage = Properties.Resources.Error;

            }
            //Exception handling to ensure base16check is an int
            if (int.TryParse(base16check, out int Hexcheck))
            {
                MessageBox.Show("This is a valid integer");
            }
            else
            {
                MessageBox.Show("Use integers only!");
                //Change the background image to show a bad result
                this.BackgroundImage = Properties.Resources.Error;
            }
            //Try block for exception handling to make sure the program does not break
            try
            {
                Hexcheck = int.Parse(InputBase16.Text);
                BinaryCheck = int.Parse(InputBase2.Text);

                
                //Check if the input is correct by comparing the input with the conversion variable
                if (base2check == InputBase2.Text && base16check == InputBase16.Text)
                {
                    //Display the conversion for base16
                    label_display_base16.Visible = true;
                    //Display the conversion for base2
                    label_display_base2.Visible = true;
                    //Display they have entered the right code
                    StatusMessageBox.Text = "\nBoth codes were entered corrected, Access Granted.";
                    //Show a successful background image
                    this.BackgroundImage = Properties.Resources.Access_granted;
                }
                //If the did not enter the right code we go into here
                else
                {
                    //Display text telling the user they entered the wrong code
                    StatusMessageBox.Text = "\nOne of the codes were entered incorrectly, Access Denied";
                    //Change the background image to show a bad result
                    this.BackgroundImage = Properties.Resources.explosion;
                }
            }
            //If something fails display this message
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                //Change the background image to show a bad result
                this.BackgroundImage = Properties.Resources.Error;

            }
        }
    }
}
