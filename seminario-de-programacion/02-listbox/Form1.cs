using System.Configuration;

namespace _02_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbUserInput.Focus();
        }

        private void tbUserInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbUserInput.Text))
                {
                    MessageBox.Show("No se puede agregar un elemento vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbUserInput.Focus();
                    return;
                }
                if (tbUserInput.Text[tbUserInput.Text.Length - 1] == ' ')
                {
                    MessageBox.Show("El texto no puede contener espacios al final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbUserInput.Focus();
                    return;
                }
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show($"¿Deseas agregar '{tbUserInput.Text}' a la lista?", "Confirmación", buttons, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
                addUserInputToListBox(tbUserInput.Text);
                clearInput();
            }
        }

        private void addUserInputToListBox(string text)
        {
            lbMain.Items.Add(text);
        }

        private void clearInput()
        {
            tbUserInput.Clear();
            tbUserInput.Focus();
        }
        private void clearListBox(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("¿Deseas limpiar la lista?", "Confirmación", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            lbMain.Items.Clear();
            clearInput();
        }

        private void lbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = lbMain.SelectedItem.ToString();
            tbInfo.Text = $@"Cantidad de caracteres en la frase: {getLength(text)}
Cantidad de espacios vacíos en la frase: {getSpaces(text).ToString()}
Primera palabra de la frase: {getFirstWord(text)}
Última palabra de la frase: {getLastWord(text)}";
            
        }

        private int getSpaces(string text)
        {
            int spaces = 0;
            foreach (char c in text)
            {
                if (c == ' ')
                {
                    spaces++;
                }
            }
            return spaces;
        }
        
        private string getFirstWord(string text)
        {
            return text.Split(' ')[0];
        }
        private string getLastWord(string text)
        {
            return text.Split(' ')[text.Split(' ').Length - 1];
        }
        private int getLength(string text)
        {
            return text.Length;
        }
    }
}
