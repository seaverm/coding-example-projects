using System.Collections;
using System.Diagnostics;


//This app will translate an English word or an entire sentense into Pig Latin.

namespace PigLatinWriter
{
    public partial class Form1 : Form
    {
        string input = ""; //For storing the input word or sentense.
        string output = ""; //For storing the pig latin translated version of the input object.
        ArrayList vowels = new ArrayList() { "A", "E", "I", "O", "U" }; //Used to store vowels for comparison purposes.
        public Form1()
        {
            InitializeComponent();
            txtBox_Input.Text = "Enter English text here.";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Executes the SentenseToPigLatin method once the button is pressed.
        private void btn_Translate_Click(object sender, EventArgs e)
        {
            output = SentenseToPigLatin(txtBox_Input.Text);
            txtBox_Output.Text = output;

        }

        private void txtBox_Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        //Method used for translating a single word into Pig Latin.
        private string WordToPigLatin(string inputWord)
        {

            string outputWord = "";
            inputWord = inputWord.ToUpper();

            //If the beginning of the word contains a vowel, just add YAY to the end of the string.
            if (vowels.Contains(Convert.ToString(inputWord[0])))
            {
                outputWord = inputWord + "YAY";
            }

            //This loop will search the input string for a vowel
            else if (!vowels.Contains(Convert.ToString(inputWord[0])))
            {
                for (int i = 0; i < inputWord.Length; i++)
                {

                    if (vowels.Contains(Convert.ToString(inputWord[i])))
                    {
                        outputWord = inputWord.Remove(0, i) + inputWord.Substring(0, i) + "AY";
                        break;
                    }
                    
                }
            }
            return outputWord;
        }

        //Using the WordToPigLatin method, this method will translate an entire sentense into pig latin.
        private string SentenseToPigLatin(string inputSentense)
        {
            string outputSentense = ""; //variable for storing the output sentense.
            Boolean hasPunctuation = false; //true if the input sentense has punctuation, false if it doesn't.
            string punctuation = ""; //for storing punctuation at the end of the sentense to add it in later
            char[] commaToRemove = { ',', ';', ':' }; //this stores the , and ; and : we want to track.
            string comma = "";
            inputSentense = inputSentense.Trim(); //Removes all empty spaces from the beginning and end of the sentense.
            

            //Checks to see if the input sentense contains puncuation or a period. If it does, it'll store that punctuation into the 
            //punctuation variable then remove that punctuation from the sentense so the method can properly do a pig latin translation
            //without the puncation getting in the way.
            if (inputSentense.Contains(".") || inputSentense.Contains("?") || inputSentense.Contains("!"))
            {
                punctuation = punctuation + inputSentense[inputSentense.Length-1];
                inputSentense = inputSentense.Remove(inputSentense.Length-1);
                hasPunctuation = true;
            }

            

            string[] sentense = inputSentense.Split(' '); //creates a string array containing all the words in the input sentense. 

            // Concatenates the output sentense with all the newly translated words and adds spaces whereever needed.
            // Then, if applicable, adds the punctuation at the end of the sentense. 
            for (int i = 0; i < sentense.Length; i++)
            {
                //If the word in the sentense has a , or ; or : then remove it then add it back in after 
                //the word has been turned into pig latin.
                if (sentense[i].Contains(",") || sentense[i].Contains(";") || sentense[i].Contains(":"))
                {
                    comma = "";

                    if (sentense[i].Contains(","))
                        comma = ",";
                    else if (sentense[i].Contains(";"))
                        comma = ";";
                    else if (sentense[i].Contains(":"))
                        comma = ":";
                    sentense[i] = sentense[i].TrimEnd(commaToRemove);
                    outputSentense = outputSentense + WordToPigLatin(sentense[i]) + comma;
                }

                else if (!sentense[i].Contains(",") || !sentense[i].Contains(";") || !sentense[i].Contains(":"))
                    outputSentense = outputSentense + WordToPigLatin(sentense[i]);

                
                if (i != sentense.Length - 1)
                    outputSentense = outputSentense + " ";
                else if (i == sentense.Length - 1 && hasPunctuation)
                    outputSentense = outputSentense + punctuation;

            }
            return outputSentense;
        }
    }
}