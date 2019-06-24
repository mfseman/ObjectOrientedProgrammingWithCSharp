namespace CapstoneProject
{
    partial class mainForm
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
            this.lstDictionary = new System.Windows.Forms.ListBox();
            this.dictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dictionaryDataSet = new CapstoneProject.DictionaryDataSet();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnEditWord = new System.Windows.Forms.Button();
            this.btnDeleteWord = new System.Windows.Forms.Button();
            this.pboxImage = new System.Windows.Forms.PictureBox();
            this.dictionaryTableAdapter = new CapstoneProject.DictionaryDataSetTableAdapters.DictionaryTableAdapter();
            this.tableAdapterManager = new CapstoneProject.DictionaryDataSetTableAdapters.TableAdapterManager();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDictionary
            // 
            this.lstDictionary.DataSource = this.dictionaryBindingSource;
            this.lstDictionary.DisplayMember = "Name";
            this.lstDictionary.FormattingEnabled = true;
            this.lstDictionary.Location = new System.Drawing.Point(13, 13);
            this.lstDictionary.Name = "lstDictionary";
            this.lstDictionary.Size = new System.Drawing.Size(163, 186);
            this.lstDictionary.TabIndex = 0;
            this.lstDictionary.SelectedIndexChanged += new System.EventHandler(this.lstDictionary_SelectedIndexChanged);
            // 
            // dictionaryBindingSource
            // 
            this.dictionaryBindingSource.DataMember = "Dictionary";
            this.dictionaryBindingSource.DataSource = this.dictionaryDataSet;
            this.dictionaryBindingSource.CurrentChanged += new System.EventHandler(this.dictionaryBindingSource_CurrentChanged);
            // 
            // dictionaryDataSet
            // 
            this.dictionaryDataSet.DataSetName = "DictionaryDataSet";
            this.dictionaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(13, 205);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(162, 23);
            this.btnAddWord.TabIndex = 1;
            this.btnAddWord.Text = "Add Word";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnEditWord
            // 
            this.btnEditWord.Location = new System.Drawing.Point(13, 234);
            this.btnEditWord.Name = "btnEditWord";
            this.btnEditWord.Size = new System.Drawing.Size(162, 23);
            this.btnEditWord.TabIndex = 2;
            this.btnEditWord.Text = "Edit Word";
            this.btnEditWord.UseVisualStyleBackColor = true;
            this.btnEditWord.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnDeleteWord
            // 
            this.btnDeleteWord.Location = new System.Drawing.Point(13, 263);
            this.btnDeleteWord.Name = "btnDeleteWord";
            this.btnDeleteWord.Size = new System.Drawing.Size(162, 23);
            this.btnDeleteWord.TabIndex = 3;
            this.btnDeleteWord.Text = "Delete Word";
            this.btnDeleteWord.UseVisualStyleBackColor = true;
            this.btnDeleteWord.Click += new System.EventHandler(this.Button_Click);
            // 
            // pboxImage
            // 
            this.pboxImage.Location = new System.Drawing.Point(181, 13);
            this.pboxImage.Name = "pboxImage";
            this.pboxImage.Size = new System.Drawing.Size(150, 185);
            this.pboxImage.TabIndex = 4;
            this.pboxImage.TabStop = false;
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
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dictionaryBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(337, 11);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(173, 188);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 305);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.pboxImage);
            this.Controls.Add(this.btnDeleteWord);
            this.Controls.Add(this.btnEditWord);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.lstDictionary);
            this.Name = "mainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDictionary;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnEditWord;
        private System.Windows.Forms.Button btnDeleteWord;
        private System.Windows.Forms.PictureBox pboxImage;
        private DictionaryDataSet dictionaryDataSet;
        private System.Windows.Forms.BindingSource dictionaryBindingSource;
        private DictionaryDataSetTableAdapters.DictionaryTableAdapter dictionaryTableAdapter;
        private DictionaryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}

