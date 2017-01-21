using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NoteBook
{
    public partial class Statistics : Form
    {
        private TextBox textbox;
        private int number;
        public Statistics()
        {
            InitializeComponent();
        }
        public Statistics(TextBox Textbox)
        {
            textbox = Textbox;
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            int i = 0;
            bool PastIsWord = false;
            number = 0;
            while (i < textbox.SelectedText.Length)
            {
                if (CheckWord(textbox.SelectedText[i]) == false && PastIsWord == false)
                {
                    i++;
                    continue;
                }
                if (CheckWord(textbox.SelectedText[i]) == true && PastIsWord == true)
                {
                    i++;
                    continue;
                }
                if (CheckWord(textbox.SelectedText[i]) == false && PastIsWord == true)//单词结束
                {
                    PastIsWord = false;
                    i++;
                    continue;
                }
                if (CheckWord(textbox.SelectedText[i]) == true && PastIsWord == false)//单词开始
                {
                    PastIsWord = true;
                    number++;
                    i++;
                    continue;
                }
            }
            MessageBox.Show(number.ToString());
            textbox.Focus();
        }

        /// <summary>
        /// 判断当前字符c是否是单词（而不是分隔符）
        /// </summary>
        /// <param name="c">当前字符</param>
        /// <returns></returns>
        private bool CheckWord(char c)
        {
            if (CheckEnter.Checked == true && (c == '\n' || c == '\r'))
            {
                return false;
            }
            if (CheckSpace.Checked == true && c == ' ')
            {
                return false;
            }
            return true;
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            CheckEnter.Checked = false;
            CheckSpace.Checked = false;
        }

    }
}
