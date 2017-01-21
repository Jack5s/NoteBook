namespace NoteBook
{
    partial class FrmFileRename
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
            this.Confirm = new System.Windows.Forms.Button();
            this.dataGridName = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.open = new System.Windows.Forms.Button();
            this.checkEx = new System.Windows.Forms.CheckBox();
            this.PreView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textEx = new System.Windows.Forms.TextBox();
            this.Setting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridName)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Confirm.Location = new System.Drawing.Point(191, 288);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 0;
            this.Confirm.Text = "确认";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // dataGridName
            // 
            this.dataGridName.AllowUserToAddRows = false;
            this.dataGridName.AllowUserToDeleteRows = false;
            this.dataGridName.AllowUserToOrderColumns = true;
            this.dataGridName.AllowUserToResizeRows = false;
            this.dataGridName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridName.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridName.BackgroundColor = System.Drawing.Color.White;
            this.dataGridName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridName.Location = new System.Drawing.Point(12, 84);
            this.dataGridName.Name = "dataGridName";
            this.dataGridName.RowHeadersVisible = false;
            this.dataGridName.RowTemplate.Height = 23;
            this.dataGridName.Size = new System.Drawing.Size(439, 184);
            this.dataGridName.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "原文件名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "预览";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 200F;
            this.Column3.HeaderText = "文件路径";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 21);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(258, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "替换为";
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(376, 46);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 5;
            this.open.Text = "打开文件";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // checkEx
            // 
            this.checkEx.AutoSize = true;
            this.checkEx.Location = new System.Drawing.Point(471, 117);
            this.checkEx.Name = "checkEx";
            this.checkEx.Size = new System.Drawing.Size(84, 16);
            this.checkEx.TabIndex = 6;
            this.checkEx.Text = "更改后缀名";
            this.checkEx.UseVisualStyleBackColor = true;
            this.checkEx.CheckedChanged += new System.EventHandler(this.checkEx_CheckedChanged);
            // 
            // PreView
            // 
            this.PreView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PreView.Location = new System.Drawing.Point(110, 288);
            this.PreView.Name = "PreView";
            this.PreView.Size = new System.Drawing.Size(75, 23);
            this.PreView.TabIndex = 7;
            this.PreView.Text = "预览";
            this.PreView.UseVisualStyleBackColor = true;
            this.PreView.Click += new System.EventHandler(this.PreView_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "后缀名：";
            // 
            // textEx
            // 
            this.textEx.Location = new System.Drawing.Point(528, 12);
            this.textEx.Name = "textEx";
            this.textEx.Size = new System.Drawing.Size(100, 21);
            this.textEx.TabIndex = 9;
            // 
            // Setting
            // 
            this.Setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Setting.Location = new System.Drawing.Point(376, 288);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(75, 23);
            this.Setting.TabIndex = 10;
            this.Setting.Text = "设置";
            this.Setting.UseVisualStyleBackColor = true;
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // FrmFileRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 333);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.textEx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PreView);
            this.Controls.Add(this.checkEx);
            this.Controls.Add(this.open);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridName);
            this.Controls.Add(this.Confirm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFileRename";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件名批量更改";
            this.Load += new System.EventHandler(this.FrmFileRename_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.DataGridView dataGridName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.CheckBox checkEx;
        private System.Windows.Forms.Button PreView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEx;
        private System.Windows.Forms.Button Setting;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}