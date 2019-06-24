namespace CapstoneProject
{
    partial class AddWordForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label filenameLabel;
            System.Windows.Forms.Label DefinitionAdd;
            this.btnAddWord = new System.Windows.Forms.Button();
            this.dictionaryDataSet = new CapstoneProject.DictionaryDataSet();
            this.dictionaryTableAdapter = new CapstoneProject.DictionaryDataSetTableAdapters.DictionaryTableAdapter();
            this.dictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new CapstoneProject.DictionaryDataSetTableAdapters.TableAdapterManager();
            this.txtWordToAdd = new System.Windows.Forms.TextBox();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            filenameLabel = new System.Windows.Forms.Label();
            DefinitionAdd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(10, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // filenameLabel
            // 
            filenameLabel.AutoSize = true;
            filenameLabel.Location = new System.Drawing.Point(10, 48);
            filenameLabel.Name = "filenameLabel";
            filenameLabel.Size = new System.Drawing.Size(52, 13);
            filenameLabel.TabIndex = 6;
            filenameLabel.Text = "Filename:";
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(10, 272);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(206, 23);
            this.btnAddWord.TabIndex = 5;
            this.btnAddWord.Text = "Add Word";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // dictionaryDataSet
            // 
            this.dictionaryDataSet.DataSetName = "DictionaryDataSet";
            this.dictionaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dictionaryTableAdapter
            // 
            this.dictionaryTableAdapter.ClearBeforeFill = true;
            // 
            // dictionaryBindingSource
            // 
            this.dictionaryBindingSource.DataMember = "Dictionary";
            this.dictionaryBindingSource.DataSource = this.dictionaryDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DictionaryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CapstoneProject.DictionaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtWordToAdd
            // 
            this.txtWordToAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dictionaryBindingSource, "Name", true));
            this.txtWordToAdd.Location = new System.Drawing.Point(12, 25);
            this.txtWordToAdd.Name = "txtWordToAdd";
            this.txtWordToAdd.Size = new System.Drawing.Size(100, 20);
            this.txtWordToAdd.TabIndex = 6;
            // 
            // txtImageName
            // 
            this.txtImageName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dictionaryBindingSource, "Filename", true));
            this.txtImageName.Location = new System.Drawing.Point(13, 64);
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(100, 20);
            this.txtImageName.TabIndex = 7;
            this.txtImageName.TextChanged += new System.EventHandler(this.txtImageName_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dictionaryBindingSource, "Description", true));
            this.txtDescription.Location = new System.Drawing.Point(13, 122);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(204, 144);
            this.txtDescription.TabIndex = 8;
            // 
            // DefinitionAdd
            // 
            DefinitionAdd.AutoSize = true;
            DefinitionAdd.Location = new System.Drawing.Point(12, 96);
            DefinitionAdd.Name = "DefinitionAdd";
            DefinitionAdd.Size = new System.Drawing.Size(54, 13);
            DefinitionAdd.TabIndex = 9;
            DefinitionAdd.Text = "Definition:";
            // 
            // AddWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 301);
            this.Controls.Add(DefinitionAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(filenameLabel);
            this.Controls.Add(this.txtImageName);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.txtWordToAdd);
            this.Controls.Add(this.btnAddWord);
            this.Name = "AddWordForm";
            this.Text = "Add Word";
            this.Load += new System.EventHandler(this.AddWordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddWord;
        private DictionaryDataSet dictionaryDataSet;
        private System.Windows.Forms.BindingSource dictionaryBindingSource;
        private DictionaryDataSetTableAdapters.DictionaryTableAdapter dictionaryTableAdapter;
        private DictionaryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtWordToAdd;
        private System.Windows.Forms.TextBox txtImageName;
        private System.Windows.Forms.TextBox txtDescription;
    }
}