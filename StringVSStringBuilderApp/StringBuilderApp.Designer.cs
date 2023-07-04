namespace StringVSStringBuilderApp
{
    partial class StringBuilderApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Input_Paragraph = new System.Windows.Forms.TextBox();
            this.Btn_Get_Count = new System.Windows.Forms.Button();
            this.Lbl_Capital = new System.Windows.Forms.Label();
            this.Lbl_LowerCase = new System.Windows.Forms.Label();
            this.Lbl_Capital_Count = new System.Windows.Forms.Label();
            this.Lbl_LowerCase_Count = new System.Windows.Forms.Label();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Input_Mutate_Paragraph = new System.Windows.Forms.TextBox();
            this.Input_Insert_String = new System.Windows.Forms.TextBox();
            this.Input_Index = new System.Windows.Forms.TextBox();
            this.Btn_Mutate_String = new System.Windows.Forms.Button();
            this.Btn_Clear_Mutate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_Console = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input_Paragraph
            // 
            this.Input_Paragraph.Location = new System.Drawing.Point(57, 62);
            this.Input_Paragraph.Multiline = true;
            this.Input_Paragraph.Name = "Input_Paragraph";
            this.Input_Paragraph.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Input_Paragraph.Size = new System.Drawing.Size(316, 120);
            this.Input_Paragraph.TabIndex = 0;
            this.Input_Paragraph.Text = "TYPE OR PASTE TEXT HERE";
            // 
            // Btn_Get_Count
            // 
            this.Btn_Get_Count.Location = new System.Drawing.Point(95, 188);
            this.Btn_Get_Count.Name = "Btn_Get_Count";
            this.Btn_Get_Count.Size = new System.Drawing.Size(121, 49);
            this.Btn_Get_Count.TabIndex = 1;
            this.Btn_Get_Count.Text = "Get Count";
            this.Btn_Get_Count.UseVisualStyleBackColor = true;
            this.Btn_Get_Count.Click += new System.EventHandler(this.Btn_Get_Count_Click);
            // 
            // Lbl_Capital
            // 
            this.Lbl_Capital.AutoSize = true;
            this.Lbl_Capital.Location = new System.Drawing.Point(399, 65);
            this.Lbl_Capital.Name = "Lbl_Capital";
            this.Lbl_Capital.Size = new System.Drawing.Size(139, 20);
            this.Lbl_Capital.TabIndex = 2;
            this.Lbl_Capital.Text = "Begin With Capital";
            // 
            // Lbl_LowerCase
            // 
            this.Lbl_LowerCase.AutoSize = true;
            this.Lbl_LowerCase.Location = new System.Drawing.Point(570, 65);
            this.Lbl_LowerCase.Name = "Lbl_LowerCase";
            this.Lbl_LowerCase.Size = new System.Drawing.Size(170, 20);
            this.Lbl_LowerCase.TabIndex = 3;
            this.Lbl_LowerCase.Text = "Begin With LowerCase";
            // 
            // Lbl_Capital_Count
            // 
            this.Lbl_Capital_Count.AutoSize = true;
            this.Lbl_Capital_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Lbl_Capital_Count.Location = new System.Drawing.Point(433, 95);
            this.Lbl_Capital_Count.Name = "Lbl_Capital_Count";
            this.Lbl_Capital_Count.Size = new System.Drawing.Size(53, 58);
            this.Lbl_Capital_Count.TabIndex = 4;
            this.Lbl_Capital_Count.Text = "0";
            // 
            // Lbl_LowerCase_Count
            // 
            this.Lbl_LowerCase_Count.AutoSize = true;
            this.Lbl_LowerCase_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Lbl_LowerCase_Count.Location = new System.Drawing.Point(621, 95);
            this.Lbl_LowerCase_Count.Name = "Lbl_LowerCase_Count";
            this.Lbl_LowerCase_Count.Size = new System.Drawing.Size(53, 58);
            this.Lbl_LowerCase_Count.TabIndex = 5;
            this.Lbl_LowerCase_Count.Text = "0";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(222, 188);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(105, 49);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Find Capital and Lowercase Characters Using \"String[ ] Array\"!";
            // 
            // Input_Mutate_Paragraph
            // 
            this.Input_Mutate_Paragraph.Location = new System.Drawing.Point(57, 324);
            this.Input_Mutate_Paragraph.Multiline = true;
            this.Input_Mutate_Paragraph.Name = "Input_Mutate_Paragraph";
            this.Input_Mutate_Paragraph.Size = new System.Drawing.Size(316, 120);
            this.Input_Mutate_Paragraph.TabIndex = 8;
            this.Input_Mutate_Paragraph.Text = "TYPE OR PASTE TEXT HERE";
            // 
            // Input_Insert_String
            // 
            this.Input_Insert_String.Location = new System.Drawing.Point(595, 324);
            this.Input_Insert_String.Name = "Input_Insert_String";
            this.Input_Insert_String.Size = new System.Drawing.Size(145, 26);
            this.Input_Insert_String.TabIndex = 9;
            // 
            // Input_Index
            // 
            this.Input_Index.Location = new System.Drawing.Point(595, 359);
            this.Input_Index.Name = "Input_Index";
            this.Input_Index.Size = new System.Drawing.Size(145, 26);
            this.Input_Index.TabIndex = 10;
            this.Input_Index.Text = "0";
            this.Input_Index.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Index);
            // 
            // Btn_Mutate_String
            // 
            this.Btn_Mutate_String.Location = new System.Drawing.Point(95, 450);
            this.Btn_Mutate_String.Name = "Btn_Mutate_String";
            this.Btn_Mutate_String.Size = new System.Drawing.Size(136, 49);
            this.Btn_Mutate_String.TabIndex = 11;
            this.Btn_Mutate_String.Text = "Mutate String";
            this.Btn_Mutate_String.UseVisualStyleBackColor = true;
            this.Btn_Mutate_String.Click += new System.EventHandler(this.Btn_Mutate_String_Click);
            // 
            // Btn_Clear_Mutate
            // 
            this.Btn_Clear_Mutate.Location = new System.Drawing.Point(237, 450);
            this.Btn_Clear_Mutate.Name = "Btn_Clear_Mutate";
            this.Btn_Clear_Mutate.Size = new System.Drawing.Size(105, 49);
            this.Btn_Clear_Mutate.TabIndex = 12;
            this.Btn_Clear_Mutate.Text = "Clear";
            this.Btn_Clear_Mutate.UseVisualStyleBackColor = true;
            this.Btn_Clear_Mutate.Click += new System.EventHandler(this.Btn_Clear_Mutate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(72, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mutate String Using \"StringBuilder INSERT\" Method!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter a String to INSERT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Enter Index Location:";
            // 
            // Lbl_Console
            // 
            this.Lbl_Console.AutoSize = true;
            this.Lbl_Console.Location = new System.Drawing.Point(439, 450);
            this.Lbl_Console.Name = "Lbl_Console";
            this.Lbl_Console.Size = new System.Drawing.Size(67, 20);
            this.Lbl_Console.TabIndex = 16;
            this.Lbl_Console.Text = "Console";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 549);
            this.Controls.Add(this.Lbl_Console);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Clear_Mutate);
            this.Controls.Add(this.Btn_Mutate_String);
            this.Controls.Add(this.Input_Index);
            this.Controls.Add(this.Input_Insert_String);
            this.Controls.Add(this.Input_Mutate_Paragraph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Lbl_LowerCase_Count);
            this.Controls.Add(this.Lbl_Capital_Count);
            this.Controls.Add(this.Lbl_LowerCase);
            this.Controls.Add(this.Lbl_Capital);
            this.Controls.Add(this.Btn_Get_Count);
            this.Controls.Add(this.Input_Paragraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_Paragraph;
        private System.Windows.Forms.Button Btn_Get_Count;
        private System.Windows.Forms.Label Lbl_Capital;
        private System.Windows.Forms.Label Lbl_LowerCase;
        private System.Windows.Forms.Label Lbl_Capital_Count;
        private System.Windows.Forms.Label Lbl_LowerCase_Count;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Input_Mutate_Paragraph;
        private System.Windows.Forms.TextBox Input_Insert_String;
        public System.Windows.Forms.TextBox Input_Index;
        private System.Windows.Forms.Button Btn_Mutate_String;
        private System.Windows.Forms.Button Btn_Clear_Mutate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label Lbl_Console;
    }
}

