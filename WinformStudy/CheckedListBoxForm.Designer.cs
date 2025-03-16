namespace WinformStudy
{
    partial class CheckedListBoxForm
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
            this.ClbFruits = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ClbFruits
            // 
            this.ClbFruits.CheckOnClick = true;
            this.ClbFruits.FormattingEnabled = true;
            this.ClbFruits.Items.AddRange(new object[] {
            "苹果",
            "梨子",
            "香蕉"});
            this.ClbFruits.Location = new System.Drawing.Point(213, 108);
            this.ClbFruits.Name = "ClbFruits";
            this.ClbFruits.Size = new System.Drawing.Size(120, 84);
            this.ClbFruits.TabIndex = 0;
            // 
            // CheckedListBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClbFruits);
            this.Name = "CheckedListBoxForm";
            this.Text = "复选列表框";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ClbFruits;
    }
}