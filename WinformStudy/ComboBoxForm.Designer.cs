namespace WinformStudy
{
    partial class ComboBoxForm
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
            this.CbbCity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CbbCity
            // 
            this.CbbCity.FormattingEnabled = true;
            this.CbbCity.Items.AddRange(new object[] {
            "重庆",
            "成都",
            "上海",
            "北京"});
            this.CbbCity.Location = new System.Drawing.Point(224, 113);
            this.CbbCity.Name = "CbbCity";
            this.CbbCity.Size = new System.Drawing.Size(121, 23);
            this.CbbCity.TabIndex = 0;
            // 
            // ComboBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CbbCity);
            this.Name = "ComboBoxForm";
            this.Text = "下拉框/组合框";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbbCity;
    }
}