/*
 * Marco Seman
 * Professor: John Baugh
 * April 26, 2016
 * C# Programming
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

namespace CapstoneProject
{
    public partial class EditWordForm : Form
    {
        public EditWordForm()
        {
            InitializeComponent();
        }

        private void dictionaryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dictionaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dictionaryDataSet);

        }

        private void EditWordForm_Load(object sender, EventArgs e)
        {
            this.dictionaryTableAdapter.Fill(this.dictionaryDataSet.Dictionary);
        }

        private void btnEditWord_Click(object sender, EventArgs e)
        {
            this.dictionaryTableAdapter.UpdateQuery(txtWordToEdit.Text, txtFilename.Text, txtDescription.Text);
            this.Close();
        }


    }
}
