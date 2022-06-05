using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            //initialize variables
            int longestWord = 0;
            int numVowels = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            String word = "";
            OpenFileDialog ofd = new OpenFileDialog();

            //Filter all files other than those with .txt extension
            ofd.Filter = "txt files (*.txt) | *.txt";

            // if OK is selected on the open field dialog box
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //the file path text box is assigned to the file path
                inputFilePath.Text = ofd.FileName;
                outputFilePath.Text = ofd.FileName + "output";
                //the data contained in the file is populated into the Rich text box
                fileData.Text = System.IO.File.ReadAllText(ofd.FileName).ToLower();
                //the words in the file are assigned to the indexes in the array and uses spaces as a delimiter
                string[] ar = fileData.Text.Split(' ');
                //the text box firstWordBox is populated with the data at index 0 in the array
                firstWordBox.Text = ar[0];
                //the text box lastWordBox is populated with the data at index -1 (last index) in the array
                lastWordBox.Text = ar[ar.Length - 1];
                //for each loop iterates through the array and assigns each index to variable str for each iteration
                foreach (String str in ar)
                {
                    //if the word stored in the variable str has a length greater than what is currently contained, populate longestWord with new word 
                    if (str.Length > longestWord)
                    {
                        longestWord = str.Length;
                        longestWordBox.Text = str;
                    }
                }
                //iterate through the array
                for (int i = 0; i < ar.Length; i++)
                {
                    //declare variables for numVowels comparison
                    var arTwo = ar[i];
                    var count = 0;

                    //for each loop iterates through the array and assigns each index to variable str for each iteration
                    foreach (var vowel in vowels)
                    {
                        //if the word stored in the variable str has a length greater than what is currently contained, populate longestWord with new word 
                        if (arTwo.Contains(vowel)) 
                            count++;
                    }
                    //iterate through the array and print word with most vowels to mostVowelsBox
                    if (numVowels < count)
                    {
                        numVowels = i;
                        word = arTwo;
                        mostVowelsBox.Text = word;
                    }
                }
                

                {

                }
            }
            System.IO.File.WriteAllText(ofd.FileName + "output.txt", "First Word: " + firstWordBox.Text + "\nLast Word: " + lastWordBox.Text + "\nLongest Word: " + longestWordBox.Text + "\nMost Vowels: " + mostVowelsBox.Text);

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //if Exit button is clicked, close the application
            Application.Exit();
        }
    }
}
