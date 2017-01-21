namespace NoteBook
{
    partial class replace
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
            this.text = new System.Windows.Forms.Label();
            this.replacestr = new System.Windows.Forms.TextBox();
            this.btnreplaceall = new System.Windows.Forms.Button();
            this.retext = new System.Windows.Forms.Label();
            this.searchposition = new System.Windows.Forms.GroupBox();
            this.up = new System.Windows.Forms.RadioButton();
            this.down = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.all = new System.Windows.Forms.CheckBox();
            this.ulcase = new System.Windows.Forms.CheckBox();
            this.btnreplace = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.btnsearchnext = new System.Windows.Forms.Button();
            this.searchstr = new System.Windows.Forms.TextBox();
            this.searchposition.SuspendLayout();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text.Location = new System.Drawing.Point(12, 19);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(70, 14);
            this.text.TabIndex = 17;
            this.text.Text = "查找内容:";
            // 
            // replacestr
            // 
            this.replacestr.AcceptsReturn = true;
            this.replacestr.AcceptsTab = true;
            this.replacestr.Location = new System.Drawing.Point(88, 54);
            this.replacestr.Multiline = true;
            this.replacestr.Name = "replacestr";
            this.replacestr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.replacestr.Size = new System.Drawing.Size(208, 21);
            this.replacestr.TabIndex = 18;
            // 
            // btnreplaceall
            // 
            this.btnreplaceall.Location = new System.Drawing.Point(311, 115);
            this.btnreplaceall.Name = "btnreplaceall";
            this.btnreplaceall.Size = new System.Drawing.Size(80, 24);
            this.btnreplaceall.TabIndex = 29;
            this.btnreplaceall.TabStop = false;
            this.btnreplaceall.Text = "全部替换";
            this.btnreplaceall.Click += new System.EventHandler(this.replaceall_Click);
            // 
            // retext
            // 
            this.retext.AutoSize = true;
            this.retext.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.retext.Location = new System.Drawing.Point(12, 59);
            this.retext.Name = "retext";
            this.retext.Size = new System.Drawing.Size(70, 14);
            this.retext.TabIndex = 8;
            this.retext.Text = "替换内容:";
            // 
            // searchposition
            // 
            this.searchposition.Controls.Add(this.up);
            this.searchposition.Controls.Add(this.down);
            this.searchposition.Location = new System.Drawing.Point(15, 90);
            this.searchposition.Name = "searchposition";
            this.searchposition.Size = new System.Drawing.Size(97, 70);
            this.searchposition.TabIndex = 25;
            this.searchposition.TabStop = false;
            this.searchposition.Text = "查找方向";
            // 
            // up
            // 
            this.up.AutoSize = true;
            this.up.Location = new System.Drawing.Point(20, 20);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(47, 16);
            this.up.TabIndex = 11;
            this.up.Text = "向上";
            this.up.UseVisualStyleBackColor = true;
            // 
            // down
            // 
            this.down.AutoSize = true;
            this.down.Location = new System.Drawing.Point(20, 42);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(47, 16);
            this.down.TabIndex = 10;
            this.down.Text = "向下";
            this.down.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "查找内容:";
            // 
            // all
            // 
            this.all.AutoSize = true;
            this.all.Location = new System.Drawing.Point(146, 90);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(72, 16);
            this.all.TabIndex = 22;
            this.all.TabStop = false;
            this.all.Text = "全字匹配";
            this.all.UseVisualStyleBackColor = true;
            // 
            // ulcase
            // 
            this.ulcase.AutoSize = true;
            this.ulcase.Location = new System.Drawing.Point(146, 115);
            this.ulcase.Name = "ulcase";
            this.ulcase.Size = new System.Drawing.Size(84, 16);
            this.ulcase.TabIndex = 21;
            this.ulcase.TabStop = false;
            this.ulcase.Text = "区分大小写";
            this.ulcase.UseVisualStyleBackColor = true;
            // 
            // btnreplace
            // 
            this.btnreplace.Location = new System.Drawing.Point(311, 85);
            this.btnreplace.Name = "btnreplace";
            this.btnreplace.Size = new System.Drawing.Size(80, 24);
            this.btnreplace.TabIndex = 28;
            this.btnreplace.TabStop = false;
            this.btnreplace.Text = "替换";
            this.btnreplace.UseVisualStyleBackColor = true;
            this.btnreplace.Click += new System.EventHandler(this.btnreplace_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(311, 55);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 24);
            this.cancel.TabIndex = 27;
            this.cancel.TabStop = false;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // btnsearchnext
            // 
            this.btnsearchnext.Location = new System.Drawing.Point(311, 25);
            this.btnsearchnext.Name = "btnsearchnext";
            this.btnsearchnext.Size = new System.Drawing.Size(80, 24);
            this.btnsearchnext.TabIndex = 26;
            this.btnsearchnext.TabStop = false;
            this.btnsearchnext.Text = "查找下一个";
            this.btnsearchnext.UseVisualStyleBackColor = true;
            this.btnsearchnext.Click += new System.EventHandler(this.searchnext_Click);
            // 
            // searchstr
            // 
            this.searchstr.AcceptsReturn = true;
            this.searchstr.AcceptsTab = true;
            this.searchstr.Location = new System.Drawing.Point(88, 25);
            this.searchstr.Multiline = true;
            this.searchstr.Name = "searchstr";
            this.searchstr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.searchstr.Size = new System.Drawing.Size(208, 21);
            this.searchstr.TabIndex = 30;
            this.searchstr.TabStop = false;
            this.searchstr.TextChanged += new System.EventHandler(this.searchstr_TextChanged);
            // 
            // replace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 163);
            this.Controls.Add(this.searchstr);
            this.Controls.Add(this.btnreplace);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.btnsearchnext);
            this.Controls.Add(this.searchposition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.all);
            this.Controls.Add(this.ulcase);
            this.Controls.Add(this.btnreplaceall);
            this.Controls.Add(this.retext);
            this.Controls.Add(this.replacestr);
            this.Location = new System.Drawing.Point(312, 24);
            this.Name = "replace";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "替换";
            this.Load += new System.EventHandler(this.replace_Load);
            this.searchposition.ResumeLayout(false);
            this.searchposition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox replacestr;
        private System.Windows.Forms.Button btnreplaceall;
        private System.Windows.Forms.Label retext;
        private System.Windows.Forms.GroupBox searchposition;
        private System.Windows.Forms.RadioButton up;
        private System.Windows.Forms.RadioButton down;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox all;
        private System.Windows.Forms.CheckBox ulcase;
        private System.Windows.Forms.Button btnreplace;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button btnsearchnext;
        private System.Windows.Forms.TextBox searchstr;
    }
}