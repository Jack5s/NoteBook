namespace NoteBook
{
    partial class search
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
            this.ulcase = new System.Windows.Forms.CheckBox();
            this.all = new System.Windows.Forms.CheckBox();
            this.btnsearchnext = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.searchstr = new System.Windows.Forms.TextBox();
            this.replace = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.down = new System.Windows.Forms.RadioButton();
            this.up = new System.Windows.Forms.RadioButton();
            this.searchposition = new System.Windows.Forms.GroupBox();
            this.searchposition.SuspendLayout();
            this.SuspendLayout();
            // 
            // ulcase
            // 
            this.ulcase.AutoSize = true;
            this.ulcase.Location = new System.Drawing.Point(156, 93);
            this.ulcase.Name = "ulcase";
            this.ulcase.Size = new System.Drawing.Size(84, 16);
            this.ulcase.TabIndex = 0;
            this.ulcase.Text = "区分大小写";
            this.ulcase.UseVisualStyleBackColor = true;
            // 
            // all
            // 
            this.all.AutoSize = true;
            this.all.Location = new System.Drawing.Point(156, 61);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(72, 16);
            this.all.TabIndex = 1;
            this.all.Text = "全字匹配";
            this.all.UseVisualStyleBackColor = true;
            // 
            // btnsearchnext
            // 
            this.btnsearchnext.Location = new System.Drawing.Point(312, 24);
            this.btnsearchnext.Name = "btnsearchnext";
            this.btnsearchnext.Size = new System.Drawing.Size(80, 24);
            this.btnsearchnext.TabIndex = 3;
            this.btnsearchnext.Text = "查找下一个";
            this.btnsearchnext.UseVisualStyleBackColor = true;
            this.btnsearchnext.Click += new System.EventHandler(this.searchnext_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(312, 56);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 24);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // searchstr
            // 
            this.searchstr.AcceptsReturn = true;
            this.searchstr.AcceptsTab = true;
            this.searchstr.Location = new System.Drawing.Point(96, 24);
            this.searchstr.Multiline = true;
            this.searchstr.Name = "searchstr";
            this.searchstr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.searchstr.Size = new System.Drawing.Size(208, 21);
            this.searchstr.TabIndex = 6;
            this.searchstr.TextChanged += new System.EventHandler(this.searchstr_TextChanged);
            // 
            // replace
            // 
            this.replace.Location = new System.Drawing.Point(312, 88);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(80, 24);
            this.replace.TabIndex = 8;
            this.replace.Text = "替换";
            this.replace.UseVisualStyleBackColor = true;
            this.replace.Click += new System.EventHandler(this.replace_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text.Location = new System.Drawing.Point(22, 26);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(70, 14);
            this.text.TabIndex = 9;
            this.text.Text = "查找内容:";
            // 
            // down
            // 
            this.down.AutoSize = true;
            this.down.Location = new System.Drawing.Point(20, 42);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(47, 16);
            this.down.TabIndex = 10;
            this.down.TabStop = true;
            this.down.Text = "向下";
            this.down.UseVisualStyleBackColor = true;
            // 
            // up
            // 
            this.up.AutoSize = true;
            this.up.Location = new System.Drawing.Point(20, 20);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(47, 16);
            this.up.TabIndex = 11;
            this.up.TabStop = true;
            this.up.Text = "向上";
            this.up.UseVisualStyleBackColor = true;
            // 
            // searchposition
            // 
            this.searchposition.Controls.Add(this.up);
            this.searchposition.Controls.Add(this.down);
            this.searchposition.Location = new System.Drawing.Point(25, 61);
            this.searchposition.Name = "searchposition";
            this.searchposition.Size = new System.Drawing.Size(97, 70);
            this.searchposition.TabIndex = 12;
            this.searchposition.TabStop = false;
            this.searchposition.Text = "查找方向";
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 154);
            this.Controls.Add(this.searchposition);
            this.Controls.Add(this.text);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.searchstr);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.btnsearchnext);
            this.Controls.Add(this.all);
            this.Controls.Add(this.ulcase);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "search";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找";
            this.Load += new System.EventHandler(this.search_Load);
            this.searchposition.ResumeLayout(false);
            this.searchposition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ulcase;
        private System.Windows.Forms.CheckBox all;
        private System.Windows.Forms.Button btnsearchnext;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button replace;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox searchstr;
        private System.Windows.Forms.RadioButton down;
        private System.Windows.Forms.RadioButton up;
        private System.Windows.Forms.GroupBox searchposition;
    }
}