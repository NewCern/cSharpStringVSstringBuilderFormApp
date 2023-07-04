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
    public partial class StringBuilderApp : Form
    {
        //reference interfaces to to instantiate classes
        ILoopThroughString IterateString = new IterateString();
        IMutate mutateString = new MutateString();

        public StringBuilderApp()
        {
            InitializeComponent();
        }

        //Iterate through paragraph to get Capital/LowerCase Count
        public void Btn_Get_Count_Click(object sender, EventArgs e)
        {
            IterateString.Iterate(Input_Paragraph.Text);
            IterateString.IncrementCapitalDigit(Lbl_Capital_Count);
            IterateString.IncrementLowerCaseDigit(Lbl_LowerCase_Count);
        }

        //In this method, I seperated each reset action into different methods
        public void Btn_Clear_Click(object sender, EventArgs e)
        {
            IterateString.ResetParagraph(Input_Paragraph);
            IterateString.ResetCapitalDigit(Lbl_Capital_Count);
            IterateString.ResetLowerCaseDigit(Lbl_LowerCase_Count);
        }

        //Filter index text box field for non numbers
        public void KeyPress_Index(object sender, KeyPressEventArgs e)
        {
            mutateString.HandleIndexChange(sender, e);
        }

        //invoke mutate string actions
        public void Btn_Mutate_String_Click(object sender, EventArgs e)
        {
            mutateString.Mutate(Input_Mutate_Paragraph.Text, Input_Insert_String.Text, Input_Index.Text);
            mutateString.UpdateMutatedText(Input_Mutate_Paragraph);
            mutateString.CheckRangeStatus(Input_Index);           
        }

        //I tried a different approach here.  All Reset Methods Were Combined
        //Into one method.
        public void Btn_Clear_Mutate_Click(object sender, EventArgs e)
        {
            mutateString.ResetFields(Input_Mutate_Paragraph, Input_Insert_String, Input_Index);
        }
    }
}
