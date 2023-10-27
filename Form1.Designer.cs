namespace Create_Basic_Class
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
            textBox1 = new TextBox();
            Add = new Button();
            Remove = new Button();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Autocreated code goes here. Please fill out the fields then hit \"Create\".";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(563, 180);
            textBox1.TabIndex = 0;
            // 
            // Add
            // 
            Add.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Add.Location = new Point(511, 198);
            Add.Margin = new Padding(0);
            Add.Name = "Add";
            Add.Padding = new Padding(0, 3, 0, 0);
            Add.Size = new Size(29, 29);
            Add.TabIndex = 2;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Remove
            // 
            Remove.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Remove.Location = new Point(546, 198);
            Remove.Name = "Remove";
            Remove.Size = new Size(29, 29);
            Remove.TabIndex = 4;
            Remove.Text = "-";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(581, 13);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(119, 214);
            listBox1.TabIndex = 5;
            listBox1.SelectedValueChanged += listBox1_SelectedValueChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(12, 198);
            textBox2.Margin = new Padding(3, 3, 3, 6);
            textBox2.MaximumSize = new Size(0, 29);
            textBox2.MinimumSize = new Size(0, 29);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Variable Name";
            textBox2.Size = new Size(363, 29);
            textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 20;
            comboBox1.Items.AddRange(new object[] { "String", "int", "double", "float", "char" });
            comboBox1.Location = new Point(381, 198);
            comboBox1.Margin = new Padding(3, 3, 3, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(124, 28);
            comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Unispace", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(381, 233);
            button1.Name = "button1";
            button1.Size = new Size(159, 29);
            button1.TabIndex = 8;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(12, 233);
            textBox3.MaximumSize = new Size(0, 29);
            textBox3.MinimumSize = new Size(0, 29);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Class Name";
            textBox3.Size = new Size(363, 29);
            textBox3.TabIndex = 9;
            // 
            // button2
            // 
            button2.Font = new Font("Unispace", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(581, 233);
            button2.Name = "button2";
            button2.Size = new Size(118, 29);
            button2.TabIndex = 10;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(546, 232);
            button3.Name = "button3";
            button3.Size = new Size(29, 29);
            button3.TabIndex = 11;
            button3.Text = "📋";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 269);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(listBox1);
            Controls.Add(Remove);
            Controls.Add(Add);
            Controls.Add(textBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Basic Class";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Add;
        private Button Remove;
        private ListBox listBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
    }
}