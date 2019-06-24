namespace Project3CSharp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nutsCheck = new System.Windows.Forms.CheckBox();
            this.cherryCheck = new System.Windows.Forms.CheckBox();
            this.sprinklesCheck = new System.Windows.Forms.CheckBox();
            this.iceCreamBox = new System.Windows.Forms.ComboBox();
            this.syrupBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syrupPic = new System.Windows.Forms.PictureBox();
            this.iceCreamPic = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syrupPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iceCreamPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ice Cream Flavor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Syrup:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toppings:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nutsCheck
            // 
            this.nutsCheck.AutoSize = true;
            this.nutsCheck.Location = new System.Drawing.Point(397, 89);
            this.nutsCheck.Margin = new System.Windows.Forms.Padding(2);
            this.nutsCheck.Name = "nutsCheck";
            this.nutsCheck.Size = new System.Drawing.Size(48, 17);
            this.nutsCheck.TabIndex = 3;
            this.nutsCheck.Text = "Nuts";
            this.nutsCheck.UseVisualStyleBackColor = true;
            this.nutsCheck.CheckedChanged += new System.EventHandler(this.nutsCheck_CheckedChanged);
            // 
            // cherryCheck
            // 
            this.cherryCheck.AutoSize = true;
            this.cherryCheck.Location = new System.Drawing.Point(397, 150);
            this.cherryCheck.Margin = new System.Windows.Forms.Padding(2);
            this.cherryCheck.Name = "cherryCheck";
            this.cherryCheck.Size = new System.Drawing.Size(64, 17);
            this.cherryCheck.TabIndex = 4;
            this.cherryCheck.Text = "Cherries";
            this.cherryCheck.UseVisualStyleBackColor = true;
            this.cherryCheck.CheckedChanged += new System.EventHandler(this.cherryCheck_CheckedChanged);
            // 
            // sprinklesCheck
            // 
            this.sprinklesCheck.AutoSize = true;
            this.sprinklesCheck.Location = new System.Drawing.Point(397, 205);
            this.sprinklesCheck.Margin = new System.Windows.Forms.Padding(2);
            this.sprinklesCheck.Name = "sprinklesCheck";
            this.sprinklesCheck.Size = new System.Drawing.Size(69, 17);
            this.sprinklesCheck.TabIndex = 5;
            this.sprinklesCheck.Text = "Sprinkles";
            this.sprinklesCheck.UseVisualStyleBackColor = true;
            this.sprinklesCheck.CheckedChanged += new System.EventHandler(this.sprinklesCheck_CheckedChanged);
            // 
            // iceCreamBox
            // 
            this.iceCreamBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iceCreamBox.FormattingEnabled = true;
            this.iceCreamBox.Items.AddRange(new object[] {
            "Vanilla",
            "Chocolate",
            "Strawberry"});
            this.iceCreamBox.Location = new System.Drawing.Point(11, 52);
            this.iceCreamBox.Margin = new System.Windows.Forms.Padding(2);
            this.iceCreamBox.Name = "iceCreamBox";
            this.iceCreamBox.Size = new System.Drawing.Size(150, 21);
            this.iceCreamBox.TabIndex = 8;
            this.iceCreamBox.SelectedIndexChanged += new System.EventHandler(this.iceCreamBox_SelectedIndexChanged);
            // 
            // syrupBox
            // 
            this.syrupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.syrupBox.FormattingEnabled = true;
            this.syrupBox.Items.AddRange(new object[] {
            "Chocolate",
            "Caramel",
            "Butterscotch"});
            this.syrupBox.Location = new System.Drawing.Point(195, 52);
            this.syrupBox.Margin = new System.Windows.Forms.Padding(2);
            this.syrupBox.Name = "syrupBox";
            this.syrupBox.Size = new System.Drawing.Size(152, 21);
            this.syrupBox.TabIndex = 9;
            this.syrupBox.SelectedIndexChanged += new System.EventHandler(this.syrupBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revertToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // revertToolStripMenuItem
            // 
            this.revertToolStripMenuItem.Name = "revertToolStripMenuItem";
            this.revertToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.revertToolStripMenuItem.Text = "Revert";
            this.revertToolStripMenuItem.Click += new System.EventHandler(this.revertToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // syrupPic
            // 
            this.syrupPic.ErrorImage = global::Project3CSharp.Properties.Resources.ButterScotchSyrup;
            this.syrupPic.Location = new System.Drawing.Point(195, 89);
            this.syrupPic.Margin = new System.Windows.Forms.Padding(2);
            this.syrupPic.Name = "syrupPic";
            this.syrupPic.Size = new System.Drawing.Size(151, 171);
            this.syrupPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.syrupPic.TabIndex = 7;
            this.syrupPic.TabStop = false;
            // 
            // iceCreamPic
            // 
            this.iceCreamPic.ErrorImage = null;
            this.iceCreamPic.Location = new System.Drawing.Point(11, 89);
            this.iceCreamPic.Margin = new System.Windows.Forms.Padding(2);
            this.iceCreamPic.Name = "iceCreamPic";
            this.iceCreamPic.Size = new System.Drawing.Size(148, 171);
            this.iceCreamPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iceCreamPic.TabIndex = 6;
            this.iceCreamPic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 284);
            this.Controls.Add(this.syrupBox);
            this.Controls.Add(this.iceCreamBox);
            this.Controls.Add(this.syrupPic);
            this.Controls.Add(this.iceCreamPic);
            this.Controls.Add(this.sprinklesCheck);
            this.Controls.Add(this.cherryCheck);
            this.Controls.Add(this.nutsCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Marco\'s Ice Cream Shop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syrupPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iceCreamPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox nutsCheck;
        private System.Windows.Forms.CheckBox cherryCheck;
        private System.Windows.Forms.CheckBox sprinklesCheck;
        private System.Windows.Forms.PictureBox iceCreamPic;
        private System.Windows.Forms.PictureBox syrupPic;
        private System.Windows.Forms.ComboBox iceCreamBox;
        private System.Windows.Forms.ComboBox syrupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

