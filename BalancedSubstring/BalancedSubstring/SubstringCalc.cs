using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Matthew Seaver
//Takes a string input composed of upper case and lower case letters and the smallest allowable substring that has at least
//one iteration of every capital and lower case letter.
namespace BalancedSubstring
{
    public class SubstringCalc
    {



        public static string CalculateBalancedSubstring(string input)
        {
            //Calls a method that checks to see if there's a balanced substring.
            if (HasBalancedSubstring(input) == false)
                return "There is no balanced substring";
            //If a balanced substring does exist calculate it.
            else
                return BalancedSubstring(input);
        }


        //This method returns the balanced substring
        static string BalancedSubstring(string letters)
        {
            string substring = letters; //Stores the currently smallest substring.
            string currentSubstring = "";//Stores the current substring that may or may not be the smallest
            string allUniqueletters1 = ""; //Stores each unique letter in the string for tracking purposes. 
            List<string> upperCase = new List<string>(); //For storing upper case characters.
            List<string> lowerCase = new List<string>(); //For storing lower case characters.
            List<string> allUniqueLetters = new List<string>(); //Stores each unique letter for tracking purposes.
            List<string> currentUniqueLettersChecked = new List<string>(); //Also stores unique letters for tracking purposes.
            int startOfSubstring = 0;
            int endOfSubstring = 0;

            for (int i = 0; i < letters.Length; i++)
            {
                //Create a list of unique letters for tracking purposes.
                if (!allUniqueLetters.Contains(Convert.ToString(letters[i])))
                    allUniqueLetters.Add(Convert.ToString(letters[i]));
            }

            //Continue the loop until we have searched the entire string for a balanced substring.
            while (endOfSubstring <= letters.Length) 
            {
                foreach (string letter in allUniqueLetters)
                    currentUniqueLettersChecked.Add(letter);

                //Cycle through the string until a substring is found that has all the unique characters. Then break out of the loop.
                for (int j = startOfSubstring; j < letters.Length; j++)
                {
                    if (currentUniqueLettersChecked.Contains(Convert.ToString(letters[j])))
                    {
                        currentUniqueLettersChecked.Remove(Convert.ToString(letters[j]));
                    }

                    endOfSubstring++;
                    currentSubstring = currentSubstring + letters[j];
                    if (currentUniqueLettersChecked.Count == 0)
                        break;
                }


                while (SubStringIntegrity(currentSubstring, allUniqueLetters) && currentSubstring.Length != 0)
                {
                    //If the current substring iteration is smaller than the previous then replace the old substring with the smaller one. 
                    if (currentSubstring.Length < substring.Length && SubStringIntegrity(currentSubstring, allUniqueLetters))
                        substring = currentSubstring;
                    currentSubstring = currentSubstring.Remove(0, 1);

                    startOfSubstring++;
                }



                foreach (string letters1 in allUniqueLetters)
                    allUniqueletters1 = allUniqueletters1 + letters1;

            }
            
            return substring;
        }


        //This method checks to see if the current substring is valid and contains all the required unique letters
        static bool SubStringIntegrity(string letters, List<string> uniqueLetters)
        {

            List<string> tracker = new List<string>(); ;


            foreach (string letter in uniqueLetters)
                tracker.Add(letter);
                
            string phrase = letters;
            
            for (int i = 0; i < phrase.Length; i ++)
            {
                if (tracker.Contains(Convert.ToString(phrase[i])))
                {
                    tracker.Remove(Convert.ToString(phrase[i]));
                }
                if (tracker.Count == 0)
                    return true;
            }
            

           
                return false;
        }

        //This method checks to see if a balanced substring exists.
        static bool HasBalancedSubstring(string letters)
        {
            
            Char upperCase;
            Char lowerCase;

            
            for (int i = 0; i < letters.Length; i++)
            {
                //If there is a number in the String, return false.
                if (Char.IsNumber(letters[i]))
                    return false;

                //If the current Char is upper case, and a lower case version does not exist, return false.
                else if (Char.IsUpper(letters[i]))
                {
                    if (!letters.Contains(Char.ToLower(letters[i])))
                        return false;
                            
                }

                //If the current Char is lower case and the string does not contain an upper case version, return false.
                else if (Char.IsLower(letters[i]))
                {
                    if (!letters.Contains(Char.ToUpper(letters[i])))
                        return false;
                }


            }
            

            return true;

        }
    }

    

}
