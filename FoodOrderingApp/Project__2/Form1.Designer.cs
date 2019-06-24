namespace Project2
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
            this.ListingBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.foodOrdertxt = new System.Windows.Forms.TextBox();
            this.loadOrderbtn = new System.Windows.Forms.Button();
            this.saveOrderbtn = new System.Windows.Forms.Button();
            this.addToListbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListingBox
            // 
            this.ListingBox.FormattingEnabled = true;
            this.ListingBox.Location = new System.Drawing.Point(12, 53);
            this.ListingBox.Name = "ListingBox";
            this.ListingBox.Size = new System.Drawing.Size(210, 238);
            this.ListingBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food Order:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Food Order:";
            // 
            // foodOrdertxt
            // 
            this.foodOrdertxt.Location = new System.Drawing.Point(244, 53);
            this.foodOrdertxt.Name = "foodOrdertxt";
            this.foodOrdertxt.Size = new System.Drawing.Size(142, 20);
            this.foodOrdertxt.TabIndex = 3;
            // 
            // loadOrderbtn
            // 
            this.loadOrderbtn.Location = new System.Drawing.Point(12, 308);
            this.loadOrderbtn.Name = "loadOrderbtn";
            this.loadOrderbtn.Size = new System.Drawing.Size(210, 23);
            this.loadOrderbtn.TabIndex = 4;
            this.loadOrderbtn.Text = "Load Order From File";
            this.loadOrderbtn.UseVisualStyleBackColor = true;
            this.loadOrderbtn.Click += new System.EventHandler(this.loadOrderbtn_Click);
            // 
            // saveOrderbtn
            // 
            this.saveOrderbtn.Location = new System.Drawing.Point(12, 346);
            this.saveOrderbtn.Name = "saveOrderbtn";
            this.saveOrderbtn.Size = new System.Drawing.Size(210, 23);
            this.saveOrderbtn.TabIndex = 5;
            this.saveOrderbtn.Text = "Save Order to File";
            this.saveOrderbtn.UseVisualStyleBackColor = true;
            this.saveOrderbtn.Click += new System.EventHandler(this.saveOrderbtn_Click);
            // 
            // addToListbtn
            // 
            this.addToListbtn.Location = new System.Drawing.Point(244, 104);
            this.addToListbtn.Name = "addToListbtn";
            this.addToListbtn.Size = new System.Drawing.Size(142, 23);
            this.addToListbtn.TabIndex = 6;
            this.addToListbtn.Text = "Add to List";
            this.addToListbtn.UseVisualStyleBackColor = true;
            this.addToListbtn.Click += new System.EventHandler(this.addToListbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 390);
            this.Controls.Add(this.addToListbtn);
            this.Controls.Add(this.saveOrderbtn);
            this.Controls.Add(this.loadOrderbtn);
            this.Controls.Add(this.foodOrdertxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListingBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListingBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox foodOrdertxt;
        private System.Windows.Forms.Button loadOrderbtn;
        private System.Windows.Forms.Button saveOrderbtn;
        private System.Windows.Forms.Button addToListbtn;
    }
}

