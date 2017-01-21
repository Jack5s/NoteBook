using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace NoteBook
{
    public partial class txt : Form
    {
        private string Path = "";
        private string FileName="记事本";
        private bool IsChange;

        #region 构造函数
        public txt()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            
            int Position = textBox.SelectionStart + textBox.SelectionLength;
            Line.Text = FillStr("行数" + (textBox.GetLineFromCharIndex(Position) + 1).ToString(), 10, ' ');
            Column.Text = FillStr("列数" + (Position - textBox.GetFirstCharIndexFromLine(textBox.GetLineFromCharIndex(Position)) + 1).ToString(), 10, ' ');
            this.Text = FileName;         
            自动换行ToolStripMenuItem_CheckedChanged(null, null);
            IsChange = false;
        }

        public txt(string FullPath)
        {
            InitializeComponent();            
            this.Text = FileName;
            textBox.Text = OpenFile(FullPath);
            textBox.Select(textBox.TextLength, 0);
            int Position = textBox.SelectionStart + textBox.SelectionLength;
            Line.Text = FillStr("行数" + (textBox.GetLineFromCharIndex(Position) + 1).ToString(), 10, ' ');
            Column.Text = FillStr("列数" + (Position - textBox.GetFirstCharIndexFromLine(textBox.GetLineFromCharIndex(Position)) + 1).ToString(), 10, ' '); 
            int i = FullPath.LastIndexOf('\\');
            FileName = FullPath.Substring(i + 1);
            Path = FullPath.Substring(0, FullPath.Length - FileName.Length - 1);
            this.Text = FileName;            
            自动换行ToolStripMenuItem_CheckedChanged(null, null);
            IsChange = false;
        }
        #endregion

        #region 菜单栏
        #region 文件
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsChange == true)
            {

                SaveTF tf;
                if (Path == "")
                {
                    tf = new SaveTF();
                }
                else
                {
                    tf = new SaveTF(Path + "\\" + FileName);
                }
                tf.ShowDialog();
                if (tf.DialogResult == DialogResult.OK)
                {
                    保存ToolStripMenuItem_Click(sender, e);
                }
                if (tf.DialogResult == DialogResult.Cancel)
                {
                    return;
                }
            }
            textBox.Text = "";
            Path = "";
            IsChange = false;
            FileName = "记事本";
            this.Text = FileName;
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsChange == true)
            {
                SaveTF tf;
                if (Path == "")
                {
                    tf = new SaveTF();
                }
                else
                {
                    tf = new SaveTF(Path + "\\" + FileName);
                }
                tf.ShowDialog();
                if (tf.DialogResult == DialogResult.OK)
                {
                    保存ToolStripMenuItem_Click(sender, e);
                }
                if (tf.DialogResult == DialogResult.Cancel)
                {
                    return;
                }
            }
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "文本文件|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                FileName = open.FileName.Substring(open.FileName.LastIndexOf('\\') + 1);
                Path = open.FileName.Substring(0, open.FileName.Length - FileName.Length - 1);
                textBox.Text = OpenFile(open.FileName);
                this.Text = FileName;
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Path != "" && FileName != "")
            {
                SaveFile(Path + "\\" + FileName);
                this.Text = FileName;
                IsChange = false;
            }
            else
            {
                另存为ToolStripMenuItem_Click(sender, e);
            }
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "文本文件|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                SaveFile(save.FileName);
                FileName = save.FileName.Substring(save.FileName.LastIndexOf('\\') + 1);
                Path = save.FileName.Substring(0, save.FileName.Length - FileName.Length - 1);
                this.Text = FileName;
                IsChange = false;
            }      
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion 

        #region 编辑
        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox.SelectedText);
            textBox.SelectedText = "";
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.SelectedText.Length > 0)
            {
                Clipboard.Clear();
                Clipboard.SetText(textBox.SelectedText,TextDataFormat.Text);
            }
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectedText = Clipboard.GetText();
        }

        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search frmsear = new search(textBox);
            frmsear.Show(this);
        }

        private void 替换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            replace frmrepl = new replace(textBox);
            frmrepl.Show(this);
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        private void 日期ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectedText = DateTime.Now.ToString();
        }
        #endregion

        #region 工具
        private void 单词数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics s = new Statistics(textBox);
            s.Show();
        }

        private void 字符串转换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransStr a = new FrmTransStr(textBox.SelectedText);
            a.Show();
        }

        private void 数据浏览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDataView a = new FrmDataView();
            a.Show();
        }

        #region 文件操作
        private void 文件重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFileRename a = new FrmFileRename();
            a.Show();
        }
        #endregion

        #endregion

        #region 格式
        private void 自动换行ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (自动换行ToolStripMenuItem.Checked == true)
            {
                textBox.WordWrap = true;
            }
            if (自动换行ToolStripMenuItem.Checked == false)
            {                
                textBox.WordWrap = false;
                textBox.ScrollBars = ScrollBars.Both;
            }
            int Position = textBox.SelectionStart + textBox.SelectionLength;
            Line.Text = FillStr("行数" + (textBox.GetLineFromCharIndex(Position) + 1).ToString(), 10, ' ');
            Column.Text = FillStr("列数" + (Position - textBox.GetFirstCharIndexFromLine(textBox.GetLineFromCharIndex(Position)) + 1).ToString(), 10, ' ');
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                textBox.Font = font.Font;
            }
        }
        #endregion
        
        #region 查看
        private void 状态栏ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (状态栏ToolStripMenuItem.Checked == false)
            {
                statusStrip.Visible = false;
            }
            if (状态栏ToolStripMenuItem.Checked == true)
            {
                statusStrip.Visible = true;
            }
        }

        #endregion
        
        #region 帮助
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.ShowDialog();
        }
        #endregion

        #endregion

        private void txt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsChange == true)
            {
                SaveTF tf;
                if (Path == "")
                {
                    tf = new SaveTF();
                }
                else
                {
                    tf = new SaveTF(Path + "\\" + FileName);
                }
                tf.ShowDialog();
                if (tf.DialogResult == DialogResult.OK)
                {
                    保存ToolStripMenuItem_Click(sender, e);
                }
                if (tf.DialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            IsChange = true;
            this.Text = "*" + FileName;
        }

        private string OpenFile(string FullPath)
        {
            try
            {
                StreamReader streamread = new StreamReader(FullPath, System.Text.ASCIIEncoding.Default);
                string Text = "";
                int Size = 1;
                //if (i == 0)
                //{
                //    char[] temp = new char[Size];
                //    while (streamread.Peek() > 0)
                //    {
                //        for (i = 0; i < Size; i++)
                //        {
                //            Text += temp[i].ToString();
                //        }
                //    }
                //    streamread.Close();
                //}
                Text = streamread.ReadToEnd();
                streamread.Close();
                return Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

        private void SaveFile(string FullPath)
        {
            try
            {
                StreamWriter streamwriter = new StreamWriter(FullPath, false, System.Text.ASCIIEncoding.Default, 1024000);
                streamwriter.Write(textBox.Text);
                streamwriter.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string FillStr(string Str, int Length, char c)
        {
            if (Str.Length >= Length)
            {
                return Str;
            }
            string Result = Str;
            int i;
            for (i = Str.Length; i < Length; i++)
            {
                Result += c.ToString();
            }
            return Result;
        }


        private void textBox_MouseCaptureChanged(object sender, EventArgs e)
        {
            int Position = textBox.SelectionStart + textBox.SelectionLength;
            Line.Text = FillStr("行数" + (textBox.GetLineFromCharIndex(Position) + 1).ToString(), 10, ' ');
            Column.Text = FillStr("列数" + (Position - textBox.GetFirstCharIndexFromLine(textBox.GetLineFromCharIndex(Position)) + 1).ToString(), 10, ' ');
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            int Position = textBox.SelectionStart + textBox.SelectionLength;
            Line.Text = FillStr("行数" + (textBox.GetLineFromCharIndex(Position) + 1).ToString(), 10, ' ');
            Column.Text = FillStr("列数" + (Position - textBox.GetFirstCharIndexFromLine(textBox.GetLineFromCharIndex(Position)) + 1).ToString(), 10, ' ');
        }

        private void txt_Load(object sender, EventArgs e)
        {

        }

    }
}
