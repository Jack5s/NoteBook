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
    public partial class FrmDataView : Form
    {
        private string FilePath = "";
        public FrmDataView()
        {
            InitializeComponent();
            radiotext.Checked = true;
        }

        private void FrmDataView_Load(object sender, EventArgs e)
        {

        }

        private void radiotext_CheckedChanged(object sender, EventArgs e)
        {
            ReadBinFile();
        }

        private void radio16int_CheckedChanged(object sender, EventArgs e)
        {
            ReadBinFile();
        }

        private void radio32int_CheckedChanged(object sender, EventArgs e)
        {
            ReadBinFile();
        }

        private void radio64int_CheckedChanged(object sender, EventArgs e)
        {
            ReadBinFile();
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendia = new OpenFileDialog();
            opendia.Filter = "所有文件|*.*";
            if (opendia.ShowDialog() == DialogResult.OK)
            {
                FilePath = opendia.FileName;
                textPath.Text = FilePath;
                ReadBinFile();
            }
        }
        private void textsplit_TextChanged(object sender, EventArgs e)
        {
            ReadBinFile();
        }
        private void ReadBinFile()
        {
            if (FilePath != "")
            {
                int i;
                string tag = "";
                for (i = 0; i < groupBox1.Controls.Count; i++)
                {
                    if (groupBox1.Controls[i] is RadioButton)
                    {
                        RadioButton r = groupBox1.Controls[i] as RadioButton;
                        if (r.Checked == true)
                        {
                            tag = GetTag(r);
                            break;
                        }
                    }
                }
                FileStream fs = new FileStream(FilePath, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                textBox1.Text = "";
                try
                {
                    switch (tag)
                    {
                        case "text":
                            char c = br.ReadChar();
                            while (true)
                            {
                                textBox1.Text += c.ToString() + textsplit.Text;
                                c = br.ReadChar();
                            }
                        case "16int":
                            int num16 = br.ReadInt16();
                            while (true)
                            {
                                textBox1.Text += num16.ToString() + textsplit.Text;
                                num16 = br.ReadInt16();
                            }
                        case "32int":
                            int num32 = br.ReadInt32();
                            while (true)
                            {
                                textBox1.Text += num32.ToString() + textsplit.Text;
                                num32 = br.ReadInt32();
                            }
                        case "64int":
                            long num64 = br.ReadInt64();
                            while (true)
                            {
                                textBox1.Text += num64.ToString() + textsplit.Text;
                                num64 = br.ReadInt64();
                            }
                    }
                    int b = br.ReadInt32();
                }
                catch (EndOfStreamException)
                {

                }
                finally
                {
                    br.Close();
                    fs.Close();
                }
            }
        }
        private string GetTag(RadioButton r)
        {
            return r.Tag.ToString();
        }



    }
}
