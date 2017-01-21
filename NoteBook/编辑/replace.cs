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
    public partial class replace : Form
    {
        private int index = -1;
        private TextBox txt;
        private string textbox_text;
        public replace(TextBox location)
        {
            txt = location;
            textbox_text =txt.Text;
            InitializeComponent();
        }

        public replace()
        {
            InitializeComponent();
        }

        private void replaceall_Click(object sender, EventArgs e)
        {
            do
            {
                btnreplace_Click(sender, e);
                if (index != -1)
                {
                    index = index + replacestr.Text.Length - searchstr.Text.Length;
                }
            }
            while (index != -1);
        }

        private void searchnext_Click(object sender, EventArgs e)
        {
            string search_str = searchstr.Text;
            textbox_text = "\n" + txt.Text + "\n";
            btnreplace.Enabled = true;
            if (ulcase.Checked == false)
            {
                search_str = search_str.ToUpper();
                textbox_text = textbox_text.ToUpper();
            }
            do
            {
                index = textbox_text.IndexOf(search_str, index + 1);
                if (index != -1)
                {
                    if (all.Checked == false)
                    {
                        txt.Select(index - 1, search_str.Length);
                        txt.Focus();
                        return;
                    }
                    else
                    {
                        string start;
                        string end;
                        start = textbox_text.Substring(index - 1, 1);//截取找到字符串的前一个字符
                        end = textbox_text.Substring(index + search_str.Length, 1);//截取找到字符串的后一个字符
                        if ((start == " " || start == "\n") && (end == " " || end == "\n"))
                        {
                            txt.Select(index - 1, search_str.Length);
                            txt.Focus();
                            return;
                        }
                    }
                }
            } 
            while (index != -1);
            MessageBox.Show("已完成搜索");
            return;
        }

        private void btnreplace_Click(object sender, EventArgs e)
        {
            if (txt.SelectedText == searchstr.Text)
            {
                txt.SelectedText = replacestr.Text;
                index = index + replacestr.Text.Length - searchstr.Text.Length;
            }
            searchnext_Click(sender, e);
        }

        private void replace_Load(object sender, EventArgs e)
        {
            btnsearchnext.Enabled = false;
            btnreplace.Enabled = false;
            btnreplaceall.Enabled = false;
        }

        private void searchstr_TextChanged(object sender, EventArgs e)
        {
            if (searchstr.Text == "")
            {
                btnsearchnext.Enabled = false;
                btnreplace.Enabled = false;
                btnreplaceall.Enabled = false;
            }
            else
            {
                btnsearchnext.Enabled = true;
                btnreplace.Enabled = true;
                btnreplaceall.Enabled = true;
            }
        }
    }
}