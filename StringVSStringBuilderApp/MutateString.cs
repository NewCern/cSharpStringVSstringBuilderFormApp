using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringVSStringBuilderApp
{
    public class MutateString : IMutate
    {
        public string errorMessage { get; set; } = "Out Of Range!";
        public string initialMessage { get; set; } = "TYPE OR PASTE TEXT HERE";
        public bool showMessage { get; set; } = false;
        public StringBuilder mutatedString { get; set; }

        //Update Index Digits and Filter out Non Numberical Chars
        public void HandleIndexChange(object sender, KeyPressEventArgs e)
        {
            const char backspace = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != backspace;
        }

        //Rerender paragraph to show reflect changes
        public void UpdateMutatedText(TextBox paragraph)
        {
            paragraph.Text = mutatedString.ToString();
        }

        //check if index entered in within range
        public void CheckRangeStatus(TextBox Input_Index)
        {
            if (showMessage) Input_Index.Text = errorMessage;
        }

        //reset all fields
        public void ResetFields(TextBox paragraph, TextBox newString, TextBox index)
        {
            paragraph.Text = "";
            mutatedString = new StringBuilder("");
            newString.Text = "";
            index.Text = "0";
        }

        //Main mutate method
        public void Mutate(string paragraph, string newString, string index)
        {
            if (index.Length == 0 || index == errorMessage)
            {
                mutatedString = new StringBuilder(initialMessage);
                return;
            }
            int indexInt = int.Parse(index);
            mutatedString = new StringBuilder(paragraph);
            if (indexInt > paragraph.Length - 1)
            {
                showMessage = true;
                return;
            }
            else { showMessage = false; }
            mutatedString.Insert(indexInt, newString);
        }
    }
}
