namespace NoteBook
{
    partial class FrmTransStr
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
            this.textData = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.Transform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textData
            // 
            this.textData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textData.Location = new System.Drawing.Point(12, 32);
            this.textData.Multiline = true;
            this.textData.Name = "textData";
            this.textData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textData.Size = new System.Drawing.Size(386, 108);
            this.textData.TabIndex = 0;
            // 
            // textResult
            // 
            this.textResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textResult.Location = new System.Drawing.Point(12, 175);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textResult.Size = new System.Drawing.Size(386, 108);
            this.textResult.TabIndex = 1;
            // 
            // Transform
            // 
            this.Transform.Location = new System.Drawing.Point(12, 146);
            this.Transform.Name = "Transform";
            this.Transform.Size = new System.Drawing.Size(75, 23);
            this.Transform.TabIndex = 2;
            this.Transform.Text = "变换";
            this.Transform.UseVisualStyleBackColor = true;
            this.Transform.Click += new System.EventHandler(this.Transform_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "变量名前加标识符，标识符为字符串最后一个字符(不算前后双引号)";
            // 
            // FrmTransStr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Transform);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textData);
            this.Name = "FrmTransStr";
            this.Text = "FrmTransStr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button Transform;
        private System.Windows.Forms.Label label1;
    }
}