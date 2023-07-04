using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringVSStringBuilderApp
{
    public interface ILoopThroughString
    {
        int lowerCase { get; set; }
        int upperCase { get; set; }
        void Iterate(string paragraph);
        void IncrementCapitalDigit(Label capitalDigit);
        void IncrementLowerCaseDigit(Label lowerCaseDigit);
        void ResetCapitalDigit(Label capitalDigit);
        void ResetLowerCaseDigit(Label lowerCaseDigit);
        void ResetParagraph(TextBox paragraph);

    }
}
