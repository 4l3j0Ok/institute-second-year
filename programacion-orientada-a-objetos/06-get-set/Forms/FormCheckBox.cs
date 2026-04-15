using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_get_set
{
    public partial class FormCheckBox : Form
    {
        public FormCheckBox()
        {
            InitializeComponent();
        }

        private void CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Name.Contains("cbOnlyOne") && checkBox.Checked)
            {
                if (cbOnlyOne1.Name == checkBox.Name) { cbOnlyOne1.Checked = true; } else { cbOnlyOne1.Checked = false; }
                if (cbOnlyOne2.Name == checkBox.Name) { cbOnlyOne2.Checked = true; } else { cbOnlyOne2.Checked = false; }
                if (cbOnlyOne3.Name == checkBox.Name) { cbOnlyOne3.Checked = true; } else { cbOnlyOne3.Checked = false; }
                Variables.checkedCbOnlyOne.Clear();
                Variables.checkedCbOnlyOne.Add(
                    int.Parse(
                        checkBox.Name.Split("cbOnlyOne")[1]
                    )
                );
            }
            if (checkBox.Name.Contains("cbMany"))
                if (checkBox.Checked)
                    Variables.checkedCbMany.Add(
                        int.Parse(
                            checkBox.Name.Split("cbMany")[1]
                        )
                    );
                else
                    Variables.checkedCbMany.Remove(int.Parse(
                        checkBox.Name.Split("cbMany")[1]
                        )
                    );
            updateTextBox(tbCbOnlyOneChecked, Variables.checkedCbOnlyOne);
            updateTextBox(tbCbManyChecked, Variables.checkedCbMany);
        }

        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Name.Contains("rbOnlyOne"))
                if (radioButton.Checked)
                    Variables.checkedRbOnlyOne.Add(int.Parse(radioButton.Name.Split("rbOnlyOne")[1]));
                else
                    Variables.checkedRbOnlyOne.Remove(int.Parse(radioButton.Name.Split("rbOnlyOne")[1]));
            if (radioButton.Name.Contains("rbMany"))
                if (radioButton.Checked)
                    Variables.checkedRbMany.Add(int.Parse(radioButton.Name.Split("rbMany")[1]));
                else
                    Variables.checkedRbMany.Remove(int.Parse(radioButton.Name.Split("rbMany")[1]));
            updateTextBox(tbRbOnlyOneChecked, Variables.checkedRbOnlyOne);
            updateTextBox(tbRbManyChecked, Variables.checkedRbMany);
        }

        private void updateTextBox(TextBox textBox, List<int> checkedList)
        {
            textBox.Text = "";
            foreach (int i in checkedList)
            {
                if (textBox.Text.Length > 0)
                    textBox.Text = textBox.Text + $", {i.ToString()}";
                else
                    textBox.Text += $"{i.ToString()}";
            }
        }
    }
}
