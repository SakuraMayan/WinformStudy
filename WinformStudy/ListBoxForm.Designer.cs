namespace WinformStudy
{
    partial class ListBoxForm
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
            this.listb = new System.Windows.Forms.ListBox();
            this.BtSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listb
            // 
            this.listb.FormattingEnabled = true;
            this.listb.HorizontalScrollbar = true;
            this.listb.ItemHeight = 15;
            this.listb.Items.AddRange(new object[] {
            "足球",
            "音乐",
            "桌球"});
            this.listb.Location = new System.Drawing.Point(139, 110);
            this.listb.Name = "listb";
            this.listb.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listb.Size = new System.Drawing.Size(120, 94);
            this.listb.TabIndex = 0;
            this.listb.SelectedIndexChanged += new System.EventHandler(this.listb_SelectedIndexChanged);
            // 
            // BtSubmit
            // 
            this.BtSubmit.Location = new System.Drawing.Point(139, 243);
            this.BtSubmit.Name = "BtSubmit";
            this.BtSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtSubmit.TabIndex = 1;
            this.BtSubmit.Text = "提交";
            this.BtSubmit.UseVisualStyleBackColor = true;
            this.BtSubmit.Click += new System.EventHandler(this.BtSubmit_Click);
            // 
            // ListBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtSubmit);
            this.Controls.Add(this.listb);
            this.Name = "ListBoxForm";
            this.Text = "列表框";
            this.Load += new System.EventHandler(this.ListBoxForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listb;
        private System.Windows.Forms.Button BtSubmit;
    }
}