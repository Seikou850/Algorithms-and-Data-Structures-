using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_C_Assessed_Exercise_1
{
    public partial class Form1 : Form
    {
        private GenericList<Book> LBook;
        public Form1()
        {
            LBook = new GenericList<Book>();
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int txtIsbn;
            if (!int.TryParse(txtISBN.Text, out txtIsbn))
            {
                MessageBox.Show("Please enter a valid number for ISBN.");
                return;
            }


            Book newbook = new Book(txtTitle.Text + " || ", txtAuthor.Text + " || ", txtIsbn);

            if (!string.IsNullOrEmpty(txtTitle.Text) && !string.IsNullOrEmpty(txtAuthor.Text) && !string.IsNullOrEmpty(txtISBN.Text)) 
            { 
                LBook.AddItem(newbook);
            }

            LabelCount.Text = "Total book: " + LBook.numberOfbooks();
            DisplayLabel.Text = LBook.DisplayList() + "\n";

            txtTitle.Text = null;
            txtAuthor.Text = null;
            txtISBN.Text = null;
    }

    private void btnRemove_Click(object sender, EventArgs e)
        {
            int txtIsbn;
            if (!int.TryParse(txtISBN.Text, out txtIsbn))
            {
                MessageBox.Show("Please enter a valid number for ISBN.");
                return;
            }

            Book newbook = new Book(txtTitle.Text, txtAuthor.Text, txtIsbn);

            if (!string.IsNullOrEmpty(txtTitle.Text) && !string.IsNullOrEmpty(txtAuthor.Text) && !string.IsNullOrEmpty(txtISBN.Text))
            {
                LBook.RemoveItem(newbook);
            }

            LabelCount.Text = "Total book: " + LBook.numberOfbooks();
            DisplayLabel.Text = LBook.DisplayList();

            txtTitle.Text = null;
            txtAuthor.Text = null;
            txtISBN.Text = null;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            LBook.Display();
            Sorted.Text = LBook.Display();
        }

    }
    
}
