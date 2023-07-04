using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringVSStringBuilderApp
{
    public class IterateString : ILoopThroughString
    {
        public int lowerCase { get; set; }
        public int upperCase { get; set; }

        //split paragraph into an array and removie all spaces
        public string[] CreateArrayRemoveSpaces(string paragraph)
        {
            string[] words = paragraph.Split(' ').Select(x => x.Trim()).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            return words;
        }

        //Convert character to ASCII Number
        public byte[] ConvertToAscii(string firstLetter)
        {
            byte[] ascii = Encoding.ASCII.GetBytes(firstLetter);
            return ascii;
        }

        //If ASCII is within range of a capital, Increment
        public void IncrementCapital(byte[] ascii)
        {
            if (ascii[0] > 64 && ascii[0] < 91) upperCase++;
        }

        //If ASCII is within range of a lowercase Increment
        public void IncrementLowerCase(byte[] ascii)
        {
            if (ascii[0] > 96 && ascii[0] < 123) lowerCase++;
        }
        
        //Update the digit on the Capital label Count
        public void IncrementCapitalDigit(Label capitalDigit) {
            capitalDigit.Text = upperCase.ToString();
        }

        //update the digit on the lowercase label Count
        public void IncrementLowerCaseDigit(Label lowerCaseDigit)
        {
            lowerCaseDigit.Text = lowerCase.ToString();
        }

        //Reset Capital Digit
        public void ResetCapitalDigit(Label capitalDigit)
        {
            capitalDigit.Text = "0";
        }

        //Reset lowercase Digit
        public void ResetLowerCaseDigit(Label lowerCaseDigit)
        {
            lowerCaseDigit.Text = "0";
        }

        //Reset Paragaph TextBox field
        public void  ResetParagraph(TextBox paragraph)
        {
            paragraph.Clear();
        }

        //Main iteration method. Methods implemented above are called 
        //in this method
        public void Iterate(string paragraph)
        {
            upperCase = 0;
            lowerCase = 0;

            if (paragraph == "") return;
            string[] words = CreateArrayRemoveSpaces(paragraph);
            for (int i = 0; i < words.Length; i++)
            {
                string firstLetter = words[i][0].ToString();
                byte[] convertedAscii = ConvertToAscii(firstLetter);
                IncrementCapital(convertedAscii);
                IncrementLowerCase(convertedAscii);
            }
        }
    }
}
