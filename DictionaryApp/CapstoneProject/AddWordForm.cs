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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProject
{
    public partial class AddWordForm : Form
    {
        public AddWordForm()
        {
            InitializeComponent();
        }

        private void dictionaryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dictionaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dictionaryDataSet);

        }

        private void AddWordForm_Load(object sender, EventArgs e)
        {
            this.dictionaryTableAdapter.Fill(this.dictionaryDataSet.Dictionary);

        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DictionaryDBCap.mdf;Integrated Security=True;Connect Timeout=30";
           
            // 1. create SQL Connection object and insert statement
            SqlConnection connection = new SqlConnection(connString);
            string insertStatement = "INSERT Dictionary " +
                "(Word, Image, Definition) " + 
                "VALUES (@Word, @Image, @Definition)";

            // 2. Create SQL Command object
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            // 3. Add appropriate Parameters
            insertCommand.Parameters.AddWithValue("@Word", txtWordToAdd.Text);
            insertCommand.Parameters.AddWithValue("@Image", txtImageName.Text);
            insertCommand.Parameters.AddWithValue("@Definition", txtDescription.Text);
            // 4. execute statement and send to main form
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();

                string selectStatement = "SELECT IDENT_CURRENT('Dictionary') FROM Dictionary";

                SqlCommand selectCommand =
                     new SqlCommand(selectStatement, connection);
                int idNum = Convert.ToInt32(selectCommand.ExecuteScalar());
                MessageBox.Show("Adding the Idex " + idNum);

                WordInfo tempInfo = new WordInfo();
                tempInfo.Word = txtWordToAdd.Text;
                tempInfo.Image = txtImageName.Text;
                tempInfo.Definition = txtDescription.Text;

                Tag = tempInfo;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Sql Connection error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }//end of finally

            this.Close();

            //this.dictionaryTableAdapter.InsertQuery(txtWordToAdd.Text, txtImageName.Text, txtDescription.Text);
          //  this.Close();
        }

        private void txtImageName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
