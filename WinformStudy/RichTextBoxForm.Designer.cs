namespace WinformStudy
{
    partial class RichTextBoxForm
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
            this.richTb = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTb
            // 
            this.richTb.Location = new System.Drawing.Point(53, 108);
            this.richTb.Name = "richTb";
            this.richTb.Size = new System.Drawing.Size(306, 96);
            this.richTb.TabIndex = 0;
            this.richTb.Text = "";
            this.richTb.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTb_LinkClicked);
            this.richTb.TextChanged += new System.EventHandler(this.richTb_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "插入图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "选中文本加粗";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RichTextBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTb);
            this.Name = "RichTextBoxForm";
            this.Text = "RichTextBoxForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}