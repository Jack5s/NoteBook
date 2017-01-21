using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NoteBook
{
    public partial class FrmFileRename : Form
    {
        private string[] FileNames;
        private string[] NewFileNames;
        public FrmFileRename()
        {
            InitializeComponent();
            this.Size = new Size(475, 372);
            //this.MinimumSize = this.Size;
            //this.MaximumSize = this.Size;
            FileNames = null;
            NewFileNames = null;
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDia = new OpenFileDialog();
            OpenDia.Multiselect = true;
            string Ex = textEx.Text;
            if (Ex.Length == 0)
            {
                OpenDia.Filter = "所有文件|*.*";
            }
            else
            {
                OpenDia.Filter = Ex + "文件|*." + Ex;
            }
            OpenDia.ShowDialog();
            if (OpenDia.FileNames.Length > 0)
            {
                dataGridName.Rows.Clear();
                FileNames = OpenDia.FileNames;
                NewFileNames = new string[FileNames.Length];
                dataGridName.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                int i;
                for (i = 0; i < FileNames.Length; i++)
                {
                    string[] data = new string[3];
                    data[0] = Path.GetFileName(FileNames[i]);
                    data[1] = "";
                    data[2] = Path.GetDirectoryName(FileNames[i]);
                    dataGridName.Rows.Add(data);
                }
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (NewFileNames != null)
            {
                string s1 = textBox1.Text;
                string s2 = textBox2.Text;
                int Count = FileNames.Length;
                int i, j;
                for (i = 0; i < FileNames.GetLength(0); i++)
                {
                    NewFileNames[i] = Path.GetDirectoryName(FileNames[i]) + "\\" + dataGridName.Rows[i].Cells[1].Value.ToString();
                }
                for (i = 0; i < Count; i++)
                {
                    for (j = 0; j < Count; j++)
                    {
                        if (NewFileNames[i] == NewFileNames[j] && i != j)
                        {
                            MessageBox.Show("文件名重复，请重新输入");
                            return;
                        }
                    }
                }
                for (i = 0; i < Count; i++)
                {
                    File.Move(FileNames[i], NewFileNames[i]);
                    //File.Delete(FileNames[i]);
                }
                MessageBox.Show("文件重命名成功！");
            }
            else
            {
                MessageBox.Show("请添加文件");
            }
        }

        private void PreView_Click(object sender, EventArgs e)
        {
            if (NewFileNames != null)
            {
                string s1 = textBox1.Text;
                string s2 = textBox2.Text;
                int i;
                dataGridName.Rows.Clear();
                if (s1.Length > 0)
                {
                    for (i = 0; i < FileNames.Length; i++)
                    {
                        if (checkEx.Checked == false)
                        {
                            string FilePath = Path.GetDirectoryName(FileNames[i]);
                            string FileName = Path.GetFileNameWithoutExtension(FileNames[i]);
                            string NewFileName = FileName.Replace(s1, s2);
                            NewFileNames[i] = FilePath + "\\" + NewFileName + Path.GetExtension(FileNames[i]);
                            string[] data = new string[3];
                            data[0] = Path.GetFileName(FileNames[i]);
                            data[1] = NewFileName + Path.GetExtension(FileNames[i]);
                            data[2] = FilePath;
                            dataGridName.Rows.Add(data);
                        }
                        else
                        {
                            string FilePath = Path.GetDirectoryName(FileNames[i]);
                            string FileName = Path.GetFileName(FileNames[i]);
                            string NewFileName = FileName.Replace(s1, s2);
                            NewFileNames[i] = FilePath + "\\" + NewFileName;
                            string[] data = new string[3];
                            data[0] = FileName;
                            data[1] = NewFileName;
                            data[2] = FilePath;
                            dataGridName.Rows.Add(data);
                        }
                    }
                }
                else
                {
                    for (i = 0; i < FileNames.Length; i++)
                    {
                        string FilePath = Path.GetDirectoryName(FileNames[i]);
                        string FileName = Path.GetFileName(FileNames[i]);
                        string[] data = new string[3];
                        data[0] = FileName;
                        data[1] = "";
                        data[2] = FilePath;
                        dataGridName.Rows.Add(data);
                    }
                }
            }
        }

        private void FrmFileRename_Load(object sender, EventArgs e)
        {
            
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            if (this.Size.Width > 600)
            {
                this.Size = new Size(475, 372);
            }
            else
            {
                this.Size = new Size(656, 372);
            }
            
        }

        private void checkEx_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
