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
    public partial class mainForm : Form
    {
        List<WordInfo> wordList;

        public mainForm()
        {
            InitializeComponent();
            wordList = new List<WordInfo>();
            // Load current items in database into wordList also...
            // using SELECT statement right here

        }
        




        private void dictionaryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dictionaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dictionaryDataSet);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.dictionaryTableAdapter.Fill(this.dictionaryDataSet.Dictionary);
        }




        // button handler
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender == btnAddWord)
            {
                AddWord();
            }
            else if (sender == btnEditWord)
            {
                EditWord();
            }
            else if (sender == btnDeleteWord)
            {
                DeleteWord();
            }


         //   AddWordForm newAddForm = new AddWordForm();
         //    newAddForm.ShowDialog();
         //     this.dictionaryTableAdapter.Fill(this.dictionaryDataSet.Dictionary);
        } // end Button_Click

        private void AddWord()
        {
            AddWordForm af = new AddWordForm();
            af.ShowDialog();

            WordInfo info = (WordInfo)af.Tag;

            if (info != null)
            {
                wordList.Add(info);
                lstDictionary.Items.Add(info.Word);
            }

            

        }
        private void EditWord()
        {
            EditWordForm ed = new EditWordForm();
            ed.ShowDialog();
        }
        private void DeleteWord()
        {
            
        }
        private void LoadItemsFromDB()
        {

        }
        



        private void btnEditWord_Click(object sender, EventArgs e)
        {
            EditWordForm newEditForm = new EditWordForm();

            newEditForm.ShowDialog();

            this.dictionaryTableAdapter.Fill(this.dictionaryDataSet.Dictionary);

            }

        private void btnDeleteWord_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected item?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Validate();
                this.dictionaryBindingSource.EndEdit();
                this.dictionaryTableAdapter.Update(dictionaryDataSet.Dictionary);
                tableAdapterManager.UpdateAll(dictionaryDataSet);
            };
        }

        private void lstDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstDictionary.SelectedIndex;


            if (index != -1)
            {
                pboxImage.ImageLocation = "Images\\" + wordList[index].Image;
                descriptionTextBox.Text = wordList[index].Definition;
            }// end if
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dictionaryTableAdapter.FillBy(this.dictionaryDataSet.Dictionary);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dictionaryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

    }
}
