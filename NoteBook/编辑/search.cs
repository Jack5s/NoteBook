using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NoteBook
{
    public partial class search : Form
    {
        private int index = -1;
        private TextBox txt;
        private string StrText;
        public search(TextBox location)
        {
            InitializeComponent();
            txt = location;
            StrText = "\n" + txt.Text + "\n";
        }
        public search()
        {
            InitializeComponent();
        }

        private void replace_Click(object sender, EventArgs e)
        {
            this.Close();
            replace rep = new replace(txt);
            rep.Show();
        }

        private void search_Load(object sender, EventArgs e)
        {
            all.Checked = false;
            down.Checked = true;
            ulcase.Checked = true;
            btnsearchnext.Enabled = false;
        }

        private void searchnext_Click(object sender, EventArgs e)
        {
            string SearchStr = searchstr.Text;
            StrText = "\n" + txt.Text + "\n";
            if (ulcase.Checked == false)
            {
                SearchStr = SearchStr.ToUpper();
                StrText = StrText.ToUpper();
            }
            do
            {
                index = StrText.IndexOf(SearchStr, index + 1);
                if (index != -1)
                {
                    if (all.Checked == false)
                    {
                        txt.Select(index - 1, SearchStr.Length);
                        txt.Focus();
                        return;
                    }
                    else
                    {
                        string start;
                        string end;
                        start = StrText.Substring(index - 1, 1);//截取找到字符串的前一个字符
                        end = StrText.Substring(index + SearchStr.Length, 1);//截取找到字符串的后一个字符
                        if ((start == " " || start == "\n") && (end == " " || end == "\n"))
                        {
                            txt.Select(index - 1, SearchStr.Length);
                            txt.Focus();
                            return;
                        }
                    }
                }
            } while (index != -1);
            MessageBox.Show("已完成搜索");
            return;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchstr_TextChanged(object sender, EventArgs e)
        {
            if (searchstr.Text == "")
            {
                btnsearchnext.Enabled = false;
            }
            else
            {
                btnsearchnext.Enabled = true;
            }
        }
    }
}