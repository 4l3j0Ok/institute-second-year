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
            if (checkBox.Name.Contains("cbOne") && checkBox.Checked)
            {
                // uncheck rest
                cbOne1.Checked = cbOne1.Name == checkBox.Name ? checkBox.Checked : false;
                cbOne2.Checked = cbOne2.Name == checkBox.Name ? checkBox.Checked : false;
                cbOne3.Checked = cbOne3.Name == checkBox.Name ? checkBox.Checked : false;
                Variables.checkedOne.Clear();
                Variables.checkedOne.Add(int.Parse(checkBox.Name.Split("cbOne")[1]));
            }
            if (checkBox.Name.Contains("cbTwo"))
                if (checkBox.Checked)
                    Variables.checkedTwo.Add(int.Parse(checkBox.Name.Split("cbTwo")[1]));
                else
                    Variables.checkedTwo.Remove(int.Parse(checkBox.Name.Split("cbTwo")[1]));
            updateTextBox(tbChecked1, Variables.checkedOne);
            updateTextBox(tbChecked2, Variables.checkedTwo);
        }

        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Name.Contains("rbOne"))
                if (radioButton.Checked)
                    Variables.checkedThree.Add(int.Parse(radioButton.Name.Split("rbOne")[1]));
                else
                    Variables.checkedThree.Remove(int.Parse(radioButton.Name.Split("rbOne")[1]));
            if (radioButton.Name.Contains("rbTwo"))
                if (radioButton.Checked)
                    Variables.checkedFour.Add(int.Parse(radioButton.Name.Split("rbTwo")[1]));
                else
                    Variables.checkedFour.Remove(int.Parse(radioButton.Name.Split("rbTwo")[1]));
            updateTextBox(tbChecked3, Variables.checkedThree);
            updateTextBox(tbChecked4, Variables.checkedFour);
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

        private void FormCheckBox_Load(object sender, EventArgs e)
        {

        }
    }
}
