using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2_disenio_en_base_a_codigo_pre_hecho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar un Alumno", "Error");
            }
            else
            {
                int i;
                Boolean actual = true;
                for (i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.Items[i].Equals(textBox1.Text))
                    {
                        actual = false;
                        MessageBox.Show("Alummo ya existe");
                        i = listBox1.Items.Count;
                    }
                }
                if (actual == true)
                {
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Text = "";
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lista1 = { "Lucas", "Matias", "Martin", "Pablo" };
            string[] lista2 = { "Turismo", "Hoteleria", "Electricidad" };
            listBox2.Items.AddRange(lista1);
            listBox4.DataSource = lista2;
            listBox4.ClearSelected();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
                MessageBox.Show("Debe seleccionar un Item");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            listBox4.SelectionMode = SelectionMode.None;
            listBox4.SelectionMode = SelectionMode.One;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            listBox4.SelectionMode = SelectionMode.None;
            listBox4.SelectionMode = SelectionMode.MultiSimple;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("APROVECHEN EL CÓDIGO!!");
        }
    }
}