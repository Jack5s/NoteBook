using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NoteBook
{
    public partial class FrmTransStr : Form
    {
        private string Result;
        private string Flag;
        public FrmTransStr()
        {
            InitializeComponent();
        }
        public FrmTransStr(string data)
        {
            InitializeComponent();
            if (data.Length > 0)
            {
                textData.Text = data;
            }
            string a, b;
            a = "a";
            b = "b";
            string c = "是大法官 " + a + " faf " + b + " ssd =sad";
        }

        private void Transform_Click(object sender, EventArgs e)
        {            
            if (textData.Text.Length > 0)
            {
                if (textData.Text.Substring(textData.Text.Length - 1, 1) == "\"")
                {
                    Flag = textData.Text.Substring(textData.Text.Length - 2, 1);
                    Result = textData.Text.Remove(textData.Text.Length - 2, 1);
                }
                else
                {
                    Flag = textData.Text.Substring(textData.Text.Length - 1, 1);
                    Result = textData.Text.Remove(textData.Text.Length - 1, 1);
                }
                int IndexFlag = Result.IndexOf(Flag, 0);
                while (IndexFlag >= 0)
                {
                    int IndexSpace = Result.IndexOf(' ', IndexFlag + Flag.Length);
                    if (IndexSpace - IndexFlag > 1)
                    {
                        string VariableName = Result.Substring(IndexFlag + Flag.Length, IndexSpace - IndexFlag - 1);
                        string t = "\" + " + VariableName + " + \"";
                        Result = Result.Insert(IndexFlag, "\" + " + VariableName + " + \"");
                        Result = Result.Remove(IndexFlag + VariableName.Length + 8, Flag.Length + VariableName.Length);
                        IndexFlag = Result.IndexOf(Flag, IndexFlag + Flag.Length);
                    }
                    else
                    {
                        MessageBox.Show("输入有误!");
                        return;
                    }
                }
                textResult.Text = Result;
            }
        }
    }
}
