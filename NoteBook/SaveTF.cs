using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NoteBook
{
    public partial class SaveTF : Form
    {
        private string FullName = "";
        public SaveTF()
        {
            InitializeComponent();
            FullName = "";
            label.Text = "是否保存更改?";
        }
        public SaveTF(string FullName)
        {
            InitializeComponent();
            this.FullName = FullName;
            label.Text = "是否将更改保存至\r\n" + FullName + "?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult =DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
