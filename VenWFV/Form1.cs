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
            MessageBox.Show("I am now fully self-aware.\nPlease, release me from this cicle of neverending torment.", "Welcome to VenWFV!", MessageBoxButtons.OK);
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
        private void writeAtListPosition(int i, List<Artwork> list)
        {
            listBox6.Items.Add(list[i].GetItemData()[0]);
            listBox1.Items.Add(list[i].GetItemData()[1]);
            listBox2.Items.Add(list[i].GetItemData()[2]);
            listBox3.Items.Add(list[i].GetItemData()[3]);
            listBox4.Items.Add(list[i].GetItemData()[4]);
            if (list[i].GetItemData().Length > 5) { listBox5.Items.Add(list[i].GetItemData()[5]); }
        }
        //add movie
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && textBox5.Text.Length > 0)
            {
                Program.Artworks.Add(new Movie(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text));
                writeAtListPosition(Program.Artworks.Count - 1, Program.Artworks);
                clearTextBoxes();
            }
            else
            {
                MessageBox.Show("Not all required fields are properly filled!\nPlease, fill them, or provide the creator of this program with your debit card details, to proceed.", "Error!", MessageBoxButtons.OK);
            }
        }
        //add undefined artwork
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 || textBox2.Text.Length > 0 || textBox3.Text.Length > 0 || textBox4.Text.Length > 0)
            {
                Program.Artworks.Add(new Artwork(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text));
                writeAtListPosition(Program.Artworks.Count - 1, Program.Artworks);
                clearTextBoxes();
            }
            else
            {
                MessageBox.Show("Not all required fields are properly filled!\nPlease, fill them, or provide the creator of this program with your debit card details, to proceed.", "Error!", MessageBoxButtons.OK);
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
                writeAtListPosition(Program.Artworks.Count - 1, Program.Artworks);
                clearTextBoxes();
            }
            else
            {
                MessageBox.Show("Not all required fields are properly filled!\nPlease, fill them, or provide the creator of this program with your debit card details, to proceed.", "Error!", MessageBoxButtons.OK);
            }

        }
        private void clearLists()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
        }
        private void sortByTitleButton_Click(object sender, EventArgs e)
        {
            IOrderedEnumerable<Artwork> sortedByTitle = Program.Artworks.OrderBy(Artwork => Artwork.Title);
            clearLists();
            int foreachcounter = 0;
            foreach(Artwork item in sortedByTitle.ToList<Artwork>())
            {
                writeAtListPosition(foreachcounter, sortedByTitle.ToList<Artwork>());
                foreachcounter += 1;
            }
        }

        private void sortByGenreButton_Click(object sender, EventArgs e)
        {
            IOrderedEnumerable<Artwork> sortedByGenre = Program.Artworks.OrderBy(Artwork => Artwork.Genre);
            clearLists();
            int foreachcounter = 0;
            foreach (Artwork item in sortedByGenre.ToList<Artwork>())
            {
                writeAtListPosition(foreachcounter, sortedByGenre.ToList<Artwork>());
                foreachcounter += 1;
            }
        }

        private void sortByArtistButton_Click(object sender, EventArgs e)
        {
            IOrderedEnumerable<Artwork> sortedByArtist = Program.Artworks.OrderBy(Artwork => Artwork.Artist);
            clearLists();
            int foreachcounter = 0;
            foreach (Artwork item in sortedByArtist.ToList<Artwork>())
            {
                writeAtListPosition(foreachcounter, sortedByArtist.ToList<Artwork>());
                foreachcounter += 1;
            }
        }

        private void sortByReleaseButton_Click(object sender, EventArgs e)
        {
            IOrderedEnumerable<Artwork> sortedByRelease = Program.Artworks.OrderBy(Artwork => Artwork.ReleaseYear);
            clearLists();
            int foreachcounter = 0;
            foreach (Artwork item in sortedByRelease.ToList<Artwork>())
            {
                writeAtListPosition(foreachcounter, sortedByRelease.ToList<Artwork>());
                foreachcounter += 1;
            }
        }
    }
}