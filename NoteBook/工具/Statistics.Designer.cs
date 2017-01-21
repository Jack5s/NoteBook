namespace NoteBook
{
    partial class Statistics
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
            this.CheckEnter = new System.Windows.Forms.CheckBox();
            this.CheckSpace = new System.Windows.Forms.CheckBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckEnter
            // 
            this.CheckEnter.AutoSize = true;
            this.CheckEnter.Location = new System.Drawing.Point(12, 55);
            this.CheckEnter.Name = "CheckEnter";
            this.CheckEnter.Size = new System.Drawing.Size(60, 16);
            this.CheckEnter.TabIndex = 0;
            this.CheckEnter.Text = "回车键";
            this.CheckEnter.UseVisualStyleBackColor = true;
            // 
            // CheckSpace
            // 
            this.CheckSpace.AutoSize = true;
            this.CheckSpace.Location = new System.Drawing.Point(12, 33);
            this.CheckSpace.Name = "CheckSpace";
            this.CheckSpace.Size = new System.Drawing.Size(60, 16);
            this.CheckSpace.TabIndex = 1;
            this.CheckSpace.Text = "空格键";
            this.CheckSpace.UseVisualStyleBackColor = true;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(243, 128);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 2;
            this.Confirm.Text = "确认";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "分隔符：";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.CheckSpace);
            this.Controls.Add(this.CheckEnter);
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckEnter;
        private System.Windows.Forms.CheckBox CheckSpace;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label label1;
    }
}