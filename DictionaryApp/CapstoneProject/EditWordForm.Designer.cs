namespace CapstoneProject
{
    partial class EditWordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblWordToEdit;
            System.Windows.Forms.Label lblFilename;
            this.btnEditWord = new System.Windows.Forms.Button();
            this.dictionaryDataSet = new CapstoneProject.DictionaryDataSet();
            this.dictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dictionaryTableAdapter = new CapstoneProject.DictionaryDataSetTableAdapters.DictionaryTableAdapter();
            this.tableAdapterManager = new CapstoneProject.DictionaryDataSetTableAdapters.TableAdapterManager();
            this.txtWordToEdit = new System.Windows.Forms.TextBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            lblWordToEdit = new System.Windows.Forms.Label();
            lblFilename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWordToEdit
            // 
            lblWordToEdit.AutoSize = true;
            lblWordToEdit.Location = new System.Drawing.Point(12, 10);
            lblWordToEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWordToEdit.Name = "lblWordToEdit";
            lblWordToEdit.Size = new System.Drawing.Size(90, 17);
            lblWordToEdit.TabIndex = 11;
            lblWordToEdit.Text = "Word to Edit:";
            // 
            // lblFilename
            // 
            lblFilename.AutoSize = true;
            lblFilename.Location = new System.Drawing.Point(12, 58);
            lblFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFilename.Name = "lblFilename";
            lblFilename.Size = new System.Drawing.Size(69, 17);
            lblFilename.TabIndex = 12;
            lblFilename.Text = "Filename:";
            // 
            // btnEditWord
            // 
            this.btnEditWord.Location = new System.Drawing.Point(16, 355);
            this.btnEditWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditWord.Name = "btnEditWord";
            this.btnEditWord.Size = new System.Drawing.Size(317, 28);
            this.btnEditWord.TabIndex = 11;
            this.btnEditWord.Text = "Edit Word";
            this.btnEditWord.UseVisualStyleBackColor = true;
            this.btnEditWord.Click += new System.EventHandler(this.btnEditWord_Click);
            // 
            // dictionaryDataSet
            // 
            this.dictionaryDataSet.DataSetName = "DictionaryDataSet";
            this.dictionaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dictionaryBindingSource
            // 
            this.dictionaryBindingSource.DataMember = "Dictionary";
            this.dictionaryBindingSource.DataSource = this.dictionaryDataSet;
            // 
            // dictionaryTableAdapter
            // 
            this.dictionaryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DictionaryTableAdapter = this.dictionaryTableAdapter;
            this.tableAdapterManager.UpdateOrder = CapstoneProject.DictionaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtWordToEdit
            // 
            this.txtWordToEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dictionaryBindingSource, "Name", true));
            this.txtWordToEdit.Location = new System.Drawing.Point(16, 30);
            this.txtWordToEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWordToEdit.Name = "txtWordToEdit";
            this.txtWordToEdit.ReadOnly = true;
            this.txtWordToEdit.Size = new System.Drawing.Size(132, 22);
            this.txtWordToEdit.TabIndex = 12;
            // 
            // txtFilename
            // 
            this.txtFilename.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dictionaryBindingSource, "Filename", true));
            this.txtFilename.Location = new System.Drawing.Point(16, 78);
            this.txtFilename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(132, 22);
            this.txtFilename.TabIndex = 13;
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dictionaryBindingSource, "Description", true));
            this.txtDescription.Location = new System.Drawing.Point(16, 110);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(317, 221);
            this.txtDescription.TabIndex = 14;
            // 
            // EditWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 397);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(lblFilename);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(lblWordToEdit);
            this.Controls.Add(this.txtWordToEdit);
            this.Controls.Add(this.btnEditWord);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditWordForm";
            this.Text = "Edit Word";
            this.Load += new System.EventHandler(this.EditWordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditWord;
        private DictionaryDataSet dictionaryDataSet;
        private System.Windows.Forms.BindingSource dictionaryBindingSource;
        private DictionaryDataSetTableAdapters.DictionaryTableAdapter dictionaryTableAdapter;
        private DictionaryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtWordToEdit;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.TextBox txtDescription;
    }
}