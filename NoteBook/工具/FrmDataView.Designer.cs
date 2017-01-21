namespace NoteBook
{
    partial class FrmDataView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiotext = new System.Windows.Forms.RadioButton();
            this.radio64int = new System.Windows.Forms.RadioButton();
            this.radio32int = new System.Windows.Forms.RadioButton();
            this.radio16int = new System.Windows.Forms.RadioButton();
            this.textPath = new System.Windows.Forms.TextBox();
            this.open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textsplit = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(27, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(240, 199);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiotext);
            this.groupBox1.Controls.Add(this.radio64int);
            this.groupBox1.Controls.Add(this.radio32int);
            this.groupBox1.Controls.Add(this.radio16int);
            this.groupBox1.Location = new System.Drawing.Point(305, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读取方式";
            // 
            // radiotext
            // 
            this.radiotext.AutoSize = true;
            this.radiotext.Location = new System.Drawing.Point(20, 34);
            this.radiotext.Name = "radiotext";
            this.radiotext.Size = new System.Drawing.Size(71, 16);
            this.radiotext.TabIndex = 3;
            this.radiotext.TabStop = true;
            this.radiotext.Tag = "text";
            this.radiotext.Text = "文本文件";
            this.radiotext.UseVisualStyleBackColor = true;
            this.radiotext.CheckedChanged += new System.EventHandler(this.radiotext_CheckedChanged);
            // 
            // radio64int
            // 
            this.radio64int.AutoSize = true;
            this.radio64int.Location = new System.Drawing.Point(184, 65);
            this.radio64int.Name = "radio64int";
            this.radio64int.Size = new System.Drawing.Size(65, 16);
            this.radio64int.TabIndex = 2;
            this.radio64int.TabStop = true;
            this.radio64int.Tag = "64int";
            this.radio64int.Text = "64位int";
            this.radio64int.UseVisualStyleBackColor = true;
            this.radio64int.CheckedChanged += new System.EventHandler(this.radio64int_CheckedChanged);
            // 
            // radio32int
            // 
            this.radio32int.AutoSize = true;
            this.radio32int.Location = new System.Drawing.Point(104, 65);
            this.radio32int.Name = "radio32int";
            this.radio32int.Size = new System.Drawing.Size(65, 16);
            this.radio32int.TabIndex = 1;
            this.radio32int.TabStop = true;
            this.radio32int.Tag = "32int";
            this.radio32int.Text = "32位int";
            this.radio32int.UseVisualStyleBackColor = true;
            this.radio32int.CheckedChanged += new System.EventHandler(this.radio32int_CheckedChanged);
            // 
            // radio16int
            // 
            this.radio16int.AutoSize = true;
            this.radio16int.Location = new System.Drawing.Point(20, 65);
            this.radio16int.Name = "radio16int";
            this.radio16int.Size = new System.Drawing.Size(65, 16);
            this.radio16int.TabIndex = 0;
            this.radio16int.TabStop = true;
            this.radio16int.Tag = "16int";
            this.radio16int.Text = "16位int";
            this.radio16int.UseVisualStyleBackColor = true;
            this.radio16int.CheckedChanged += new System.EventHandler(this.radio16int_CheckedChanged);
            // 
            // textPath
            // 
            this.textPath.BackColor = System.Drawing.Color.White;
            this.textPath.Location = new System.Drawing.Point(27, 34);
            this.textPath.Name = "textPath";
            this.textPath.ReadOnly = true;
            this.textPath.Size = new System.Drawing.Size(240, 21);
            this.textPath.TabIndex = 3;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(192, 61);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 4;
            this.open.Text = "浏览";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "分隔符：";
            // 
            // textsplit
            // 
            this.textsplit.BackColor = System.Drawing.Color.White;
            this.textsplit.Location = new System.Drawing.Point(362, 34);
            this.textsplit.Name = "textsplit";
            this.textsplit.Size = new System.Drawing.Size(198, 21);
            this.textsplit.TabIndex = 6;
            this.textsplit.TextChanged += new System.EventHandler(this.textsplit_TextChanged);
            // 
            // FrmDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 309);
            this.Controls.Add(this.textsplit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.open);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmDataView";
            this.Text = "FrmDataView";
            this.Load += new System.EventHandler(this.FrmDataView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiotext;
        private System.Windows.Forms.RadioButton radio64int;
        private System.Windows.Forms.RadioButton radio32int;
        private System.Windows.Forms.RadioButton radio16int;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textsplit;
    }
}