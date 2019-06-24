/*
 * Marco Seman
 * Object-Oriented Programming(C#)
 * March 11, 2016
 * Professor John Baugh
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addToListbtn_Click(object sender, EventArgs e)
        {
            /*
             * In this method, Each time something is added to the text box, it adds it to the list.
             * The foodOrdertxt clears the text box once the button has been clicked. 
             */

            ListingBox.Items.Add(foodOrdertxt.Text);
            foodOrdertxt.Clear();
        } // end of addToListbtn_Click method

        private void loadOrderbtn_Click(object sender, EventArgs e)
        {
            /*
             *  I insert a shortcut for OpenFile Dialog so that the appliation doesn't have to repeatedly 
             *  insert the word OpenFileDialog a thousand times.
             *  The Filter allows the application to search either a order file, text file, or all files.
             *  the Title is the title that shows up in the windows explorer that pops up once you click load.
             *  The FileName gets the file.
             *  The ListingBox clear is declared after the fileName because once you click the load button,
             *  the listing box clears.
             */ 

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Order File(*.order)|*.order|Text Files(*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.Title = "SELECT A FILE NOW!!!!!";
            ofd.FileName = "";


            ListingBox.Items.Clear();

            DialogResult result = ofd.ShowDialog();

            /*
             *  In this control statement, I set the file name as a string
             *  the string text allows the application to read inside of the file.
             *  Without the System.IO.File statement the application will print out the file name, not what is inside the file.
             *  The foreach statement makes sure that the application breaks a line, instead of having them all in one line.
             */

            if (result == DialogResult.OK)
            {
                string file = ofd.FileName;
                string[] text = System.IO.File.ReadAllLines(file);
                foreach (string line in text)
                {
                    ListingBox.Items.Add(line);

                }
                ListingBox.Items.Add("");
            }
            
        } // end of loadOrderbtn_Click statement

        private void saveOrderbtn_Click(object sender, EventArgs e)
        {
          
            SaveFileDialog sfd = new SaveFileDialog();

            /*
             *  The Filter allows you to either save under the default order file, text box, or save under "all files".
             *  In the control statement, the steamwriter saves each line in the listbox.
             */

            sfd.Filter = "Order File(*.order)|*.order|Text Files(*.txt)|*.txt|All Files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                using (var sw = new StreamWriter(sfd.FileName, false))
                    foreach (var item in ListingBox.Items)

                        sw.Write(item.ToString() + Environment.NewLine);

                MessageBox.Show("YOU SAVED THE FILE!!!");
            }

        } // end of saveOrderbtn_Click statement
    }
}
