using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenWFV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void clearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void writeLastInList()
        {
            listBox6.Items.Add(Program.Artworks[Program.Artworks.Count - 1].GetItemData()[0]);
            listBox1.Items.Add(Program.Artworks[Program.Artworks.Count - 1].GetItemData()[1]);
            listBox2.Items.Add(Program.Artworks[Program.Artworks.Count - 1].GetItemData()[2]);
            listBox3.Items.Add(Program.Artworks[Program.Artworks.Count - 1].GetItemData()[3]);
            listBox4.Items.Add(Program.Artworks[Program.Artworks.Count - 1].GetItemData()[4]);
            if (Program.Artworks[Program.Artworks.Count - 1].GetItemData().Length > 5) { listBox5.Items.Add(Program.Artworks[Program.Artworks.Count - 1].GetItemData()[5]); }
        }
        //add movie
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && textBox5.Text.Length > 0)
            {
                Program.Artworks.Add(new Movie(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text));
                writeLastInList();
                clearTextBoxes();
            }
            else
            {
                MessageBox.Show("Nie wszystkie wymagane pola są wypełnione!", "Błąd!", MessageBoxButtons.OK);
            }
        }
        //add undefined artwork
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 || textBox2.Text.Length > 0 || textBox3.Text.Length > 0 || textBox4.Text.Length > 0)
            {
                Program.Artworks.Add(new Artwork(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text));
                writeLastInList();
                clearTextBoxes();
            }
            else
            {
                MessageBox.Show("Żadno pole nie jest wypełnione!", "Błąd!", MessageBoxButtons.OK);
            }
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Add Song
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0)
            {
                Program.Artworks.Add(new Song(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text));
                writeLastInList();
                clearTextBoxes();
            }
            else
            {
                MessageBox.Show("Nie wszystkie wymagane pola są wypełnione!", "Błąd!", MessageBoxButtons.OK);
            }

        }
    }
}