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

namespace Project3CSharp
{
    public partial class Form1 : Form
    {

        int savedIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void iceCreamBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (iceCreamBox.SelectedIndex)
            {
                case 0:
                    iceCreamPic.Image = Properties.Resources.vanilla;
                    break;

                case 1:
                    iceCreamPic.Image = Properties.Resources.Chocolate;
                    break;

                case 2:
                    iceCreamPic.Image = Properties.Resources.Strawberry;
                    break;
            }
        }

        private void syrupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (syrupBox.SelectedIndex)
            {
                case 0:
                    syrupPic.Image = Properties.Resources.ChocolateSyrup;
                    break;

                case 1:
                    syrupPic.Image = Properties.Resources.CaramelSyrup;
                    break;

                case 2:
                    syrupPic.Image = Properties.Resources.ButterScotchSyrup;
                    break;
            }

        }

        private void nutsCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (nutsCheck.Checked)
            {
                this.Tag = "checked";
            }
            else
            {
                this.Tag = "unchecked";
            }
        }

        private void cherryCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cherryCheck.Checked)
            {
                this.Tag = "checked";
            }
            else
            {
                this.Tag = "unchecked";
            }
        }

        private void sprinklesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (sprinklesCheck.Checked)
            {
                this.Tag = "checked";
            }
            else
            {
                this.Tag = "unchecked";
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Order File(*.icorder)|*.icorder|Text Files(*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.Title = "SELECT A FILE NOW!!!!!";
            ofd.FileName = "";


            DialogResult result = ofd.ShowDialog();
        
            StreamReader reader = File.OpenText(ofd.FileName))

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                sr = new StreamReader(ofd.FileName);

                strInput = sr.ReadLine();

                sr.Close;
            }



        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "DefaultOutputName.icorder";
            save.Filter = "Text File | *.icorder";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());

                if (save.ShowDialog() == DialogResult.OK)
                {
                    writer = new StreamWriter(SaveFileDialog
                }

                





                if (nutsCheck.Checked == true)
                {
                    writer.WriteLine("YES");
                }
                else
                {
                    writer.WriteLine("NO");
                }

                if (cherryCheck.Checked)
                {
                    writer.WriteLine("YES");
                }
                else
                {
                    writer.WriteLine("NO");
                }

                if (sprinklesCheck.Checked)
                {
                    writer.WriteLine("YES");
                }
                else
                {
                    writer.WriteLine("NO");
                }
                
                writer.Dispose();
                writer.Close();
            }
        }

        private void revertToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
