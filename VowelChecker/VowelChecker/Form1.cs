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

            foreach(char c in UserEntry)
            {
               if (Vowels.Contains(c))
                {
                    VowelCount++;
                }
            }

            return VowelCount;
        }
    }
}
