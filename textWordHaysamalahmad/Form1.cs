using System;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace textWordHaysamalahmad
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
            AddNewDocument();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDocument();
        }

        int index = -1;
        public void AddNewDocument(string MyFile = "")
        {
            index++;
            StandarFrm frm = new StandarFrm();
            frm.MdiParent = this;
            frm.IsOpened = false;
            frm.Index = index;
            //byte screenNumber = (byte)this.MdiChildren.Count();
            frm.Text += (index + 1) + "";
            if (!string.IsNullOrEmpty(MyFile.Trim()))
            {
                //frm.Text = MyFile;
                frm.FilePath = MyFile;
                frm.FileName = Path.GetFileNameWithoutExtension(MyFile);
                frm.Text = frm.FileName;
                frm.IsOpened = true;
            }

            frm.Show();
            ToolStripButton btn = new ToolStripButton();
            btn.Name = "btn" + index;
            btn.Text = frm.Text;
            if (!string.IsNullOrEmpty(MyFile.Trim()))
            {
                //btn.Text = Path.GetFileNameWithoutExtension(MyFile);
                btn.Text = frm.FileName;
            }
            btn.Click += delegate
            {
                //this.ActivateMdiChild(this.MdiChildren[(screenNumber - 1)]);
                this.ActivateMdiChild(frm);
                ActiveMdiChild.Focus();
                ActiveMdiChild.Controls["txt"].Focus();
            };
            ss.Items.Add(btn);

            frm.FormClosing += Frm_FormClosing;
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            return;
            DialogResult msg = MessageBox.Show("Do you want save changes?", "Save dialog", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            DevForm frm = ((DevForm)ActiveMdiChild);
            string fp = frm.FilePath + "";
            if (!string.IsNullOrEmpty(fp.Trim()) && !((DevTextBox)frm.Controls["txt"]).IsSaved)
            {
                if (msg == DialogResult.Yes)
                {
                    //saveToolStripMenuItem.PerformClick();
                    MessageBox.Show("Save");
                }
                else if (msg == DialogResult.Cancel)
                {
                    MessageBox.Show("Cancel");
                    //e.Cancel = true;
                }
            }

            if (string.IsNullOrEmpty(fp.Trim()) && frm.Controls["txt"].Text.Trim() != "")
            {
                if (msg == DialogResult.Yes)
                {
                    //saveAsToolStripMenuItem.PerformClick();
                    MessageBox.Show("Save As");
                }
                else if (msg == DialogResult.Cancel)
                {
                    //e.Cancel = true;
                    MessageBox.Show("cancel save as");
                }
            }
        }

        private void frmEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                if (this.ActiveMdiChild.Controls[0].Focused)
                {
                    ts.Focus();
                    ts.Items[0].Select();
                }
                else if (ts.Focused)
                {
                    ss.Focus();
                    ss.Items[0].Select();
                }
                else
                    this.ActiveMdiChild.Controls[0].Focus();
            }
            //else if (e.Control && e.KeyCode == Keys.N)
            //newToolStripButton.PerformClick();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select text File";
            ofd.Filter = "Text Files|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //if (Path.GetExtension(ofd.FileName).ToLower() == ".txt")
               // {
                    //if (MdiChildren[0].Controls[0].Text.Trim() == "" && !((DevForm)MdiChildren[0]).IsOpened)
                    //{
                        DevForm frm = ((DevForm)MdiChildren[0]);
                        //frm.FilePath = ofd.FileName;
                        //frm.FileName = Path.GetFileNameWithoutExtension(ofd.FileName);
                        //frm.IsOpened = false;
                        //frm.Text = frm.FileName;
                        frm.Controls[0].Text = File.ReadAllText(ofd.FileName);
                        ss.Items[0].Text = frm.FileName;

                        //this.Controls[0].Focus();   
                        this.ActivateMdiChild(MdiChildren[0]);
                   // }
                }
               //else
                //{
                    AddNewDocument(ofd.FileName);
                    this.ActiveMdiChild.Controls[0].Text = File.ReadAllText(ofd.FileName);
                }
       //     }
       // }
    

        private void frmEditor_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
