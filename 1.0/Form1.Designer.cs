namespace _1._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Search = new TextBox();
            button_decending = new Button();
            Sort = new Button();
            edit_input = new TextBox();
            listBox1 = new ListBox();
            Gen_data = new Button();
            Confirm_Srch = new Button();
            SuspendLayout();
            // 
            // Search
            // 
            Search.Location = new Point(282, 13);
            Search.Name = "Search";
            Search.Size = new Size(231, 23);
            Search.TabIndex = 0;
            Search.TextChanged += Search_TextChanged;
            // 
            // button_decending
            // 
            button_decending.Location = new Point(282, 274);
            button_decending.Name = "button_decending";
            button_decending.Size = new Size(108, 26);
            button_decending.TabIndex = 1;
            button_decending.Text = "Sort Decending";
            button_decending.UseVisualStyleBackColor = true;
            button_decending.Click += button_decending_Click;
            // 
            // Sort
            // 
            Sort.Location = new Point(396, 276);
            Sort.Name = "Sort";
            Sort.Size = new Size(117, 24);
            Sort.TabIndex = 2;
            Sort.Text = "Sort Acending";
            Sort.UseVisualStyleBackColor = true;
            Sort.Click += button2_Click;
            // 
            // edit_input
            // 
            edit_input.Location = new Point(569, 69);
            edit_input.Name = "edit_input";
            edit_input.Size = new Size(219, 23);
            edit_input.TabIndex = 3;
            edit_input.TextChanged += edit_input_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(282, 69);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(231, 199);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Gen_data
            // 
            Gen_data.Location = new Point(282, 46);
            Gen_data.Name = "Gen_data";
            Gen_data.Size = new Size(108, 21);
            Gen_data.TabIndex = 5;
            Gen_data.Text = "Generate Data";
            Gen_data.UseVisualStyleBackColor = true;
            Gen_data.Click += Gen_data_Click;
            // 
            // Confirm_Srch
            // 
            Confirm_Srch.Location = new Point(396, 46);
            Confirm_Srch.Name = "Confirm_Srch";
            Confirm_Srch.Size = new Size(117, 21);
            Confirm_Srch.TabIndex = 6;
            Confirm_Srch.Text = "Confirm Search";
            Confirm_Srch.UseVisualStyleBackColor = true;
            Confirm_Srch.Click += Confirm_Srch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Confirm_Srch);
            Controls.Add(Gen_data);
            Controls.Add(listBox1);
            Controls.Add(edit_input);
            Controls.Add(Sort);
            Controls.Add(button_decending);
            Controls.Add(Search);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Search;
        private Button button_decending;
        private Button Sort;
        private TextBox edit_input;
        private ListBox listBox1;
        private Button Gen_data;
        private Button Confirm_Srch;
    }
}
