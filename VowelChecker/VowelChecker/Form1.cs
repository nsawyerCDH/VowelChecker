using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VowelChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CountVowelsButton_Click(object sender, EventArgs e)
        {
            int VowelsCounted = CountVowels(this.UserStringTextbox.Text);

            MessageBox.Show(VowelsCounted + " Vowels were found in the String!");
        }

        // Declare a public Array to store our Vowels
        public char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };

        public int CountVowels(string UserEntry)
        {
            int VowelCount = 0;

            // Loop over each character in the UserEntry string
            foreach(char c in UserEntry)
            {
                // Check if the Vowels Array contains the current char "c"
               if (Vowels.Contains(char.ToLower(c)))
                {
                    // If vowel found, increment the VowelCount
                    VowelCount++;
                }
            }

            // Return the total Vowels Counted
            return VowelCount;
        }

        private void IncludeYCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.IncludeYCheckBox.Checked)
            {
                // Update the Vowels Array to include 'Y'
                Vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            }
            else
            {
                // Update the Vowels Array to Remove 'Y'
                Vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            }
        }
    }
}
