using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringVSStringBuilderApp
{
    public interface IMutate
    {
        string errorMessage { get; set; }
        string initialMessage { get; set; } 
        bool showMessage { get; set; }
        StringBuilder mutatedString { get; set; }
        void Mutate(string paragraph, string newString, string index);
        void HandleIndexChange(object sender, KeyPressEventArgs e);
        void UpdateMutatedText(TextBox paragraph);
        void CheckRangeStatus(TextBox Input_Index);
        void ResetFields(TextBox paragraph, TextBox newString, TextBox index);

    }
}
