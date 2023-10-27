using System.Text;

namespace Create_Basic_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please input a variable first.");
                return;
            }

            if (comboBox1.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please pick a data type first.");
                return;
            }

            if (Contained(textBox2.Text))
            {
                MessageBox.Show("That variable already exists.");
                return;
            }

            listBox1.Items.Add(textBox2.Text + " - " + comboBox1.Text);
            textBox2.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (textBox2.Text is null)
            {
                MessageBox.Show("Please input a variable first.");
                return;
            }

            if (Contained(textBox2.Text))
            {
                RemoveContained(textBox2.Text);
                listBox1.Items.Remove(textBox2.Text + " - " + comboBox1.Text);
                textBox2.Text = string.Empty;
                comboBox1.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("That variable does not exist.");
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is null)
            {
                textBox2.Text = "";
            }
            else
            {
                string[] data = listBox1.SelectedItem.ToString().Split('-');

                if (data.Length == 2)
                {
                    textBox2.Text = data[0].Trim();
                    comboBox1.Text = data[1].Trim();
                }
            }
        }

        //UTILS
        private Task RefreshBox(string Text)
        {
            textBox2.Text += Text;
            return Task.CompletedTask;
        }

        private Task RemoveContained(string text)
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                if (string.Equals((string?)listBox1.Items[i], text, StringComparison.OrdinalIgnoreCase))
                {
                    listBox1.Items.RemoveAt(i);
                }
            }

            return Task.CompletedTask;
        }

        private bool Contained(string text)
        {
            foreach (string variable in listBox1.Items)
            {
                if (variable.Equals(text + " - " + comboBox1.Text, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private string toCamelCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            string[] words = input.Split(' ', '-', '_', '.', ':');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToLower(words[i][0]) + (words[i].Length > 1 ? words[i].Substring(1) : string.Empty);
                }
            }

            return string.Join("", words);
        }

        //CREATE
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count <= 0 && textBox3.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please fill up all required fields.");
                return;
            }
            else if (listBox1.Items.Count <= 0)
            {
                MessageBox.Show("Variable list can't be empty.");
                return;
            }
            else if (textBox3.Text.Equals(string.Empty))
            {
                MessageBox.Show("Provide class name.");
                return;
            }

            StringBuilder code = new StringBuilder();
            List<Byte> list = new List<Byte>();
            string title = textBox3.Text;

            //VARIABLES
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                string[] data = listBox1.Items[i].ToString().Split('-');

                if (data.Length == 2)
                {
                    Byte b = new Byte(data[0].Trim(), data[1].Trim());
                    list.Add(b);
                }
            }

            foreach (Byte b in list)
            {
                code.AppendLine("\tprivate " + b.getType() + " " + toCamelCase(b.getName()) + ";");
            }

            //CONSTRUCTORS
            code.AppendLine("");

            code.AppendLine("\tpublic " + title + " () {");
            foreach (Byte b in list)
            {
                if (b.getType().Equals("int", StringComparison.OrdinalIgnoreCase) || b.getType().Equals("double", StringComparison.OrdinalIgnoreCase) || b.getType().Equals("float", StringComparison.OrdinalIgnoreCase))
                {
                    code.AppendLine("\t\t" + toCamelCase(b.getName()) + " = " + "0" + ";");
                }
                else if (b.getType().Equals("char", StringComparison.OrdinalIgnoreCase))
                {
                    code.AppendLine("\t\t" + toCamelCase(b.getName()) + " = " + "\'\'" + ";");
                }
                else
                {
                    code.AppendLine("\t\t" + toCamelCase(b.getName()) + " = " + "\"\"" + ";");
                }
            }
            code.AppendLine("\t}");

            code.AppendLine("");

            code.Append("\tpublic " + title + " (");
            for (int i = 0; i <= list.Count - 1; i++)
            {
                if (i == list.Count - 1)
                {
                    code.Append(list[i].getType() + " " + toCamelCase(list[i].getName()) + ") {");
                }
                else
                {
                    code.Append(list[i].getType() + " " + toCamelCase(list[i].getName()) + ", ");
                }
            }

            code.AppendLine(" ");

            foreach (Byte b in list)
            {
                code.AppendLine("\t\tthis." + toCamelCase(b.getName()) + " = " + toCamelCase(b.getName()) + ";");
            }

            code.AppendLine("\t}");
            code.AppendLine(" ");

            //GET
            foreach (Byte b in list)
            {
                code.AppendLine("\tpublic " + b.getType() + " get" + toCamelCase(b.getName()) + "() {");
                code.AppendLine("\t\treturn " + toCamelCase(b.getName()) + ";");
                code.AppendLine("\t}");
            }

            //SET
            foreach (Byte b in list)
            {
                code.AppendLine("\tpublic void set" + toCamelCase(b.getName()) + "(" + b.getType() + " " + toCamelCase(b.getName()) + ") {");
                code.AppendLine("\t\tthis." + toCamelCase(b.getName()) + " = " + toCamelCase(b.getName()) + ";");
                code.AppendLine("\t}");
            }

            code.AppendLine(" ");

            //PRINT
            textBox1.Text = code.ToString();
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;

            while (listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(string.Empty))
            {
                MessageBox.Show("There is no code to copy to clipboard");
                return;
            }

            try
            {
                Clipboard.SetText(textBox1.Text);
                MessageBox.Show("Code copied to clipboard.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't copy to clipboard.\n" + ex.ToString());
            }
        }
    }
}