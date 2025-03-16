namespace WinformStudy
{
    partial class DateTimePickerForm
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
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.dtPickerYmd = new System.Windows.Forms.DateTimePicker();
            this.dtPickerHms = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dtPicker
            // 
            this.dtPicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker.Location = new System.Drawing.Point(239, 118);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.ShowCheckBox = true;
            this.dtPicker.ShowUpDown = true;
            this.dtPicker.Size = new System.Drawing.Size(200, 25);
            this.dtPicker.TabIndex = 0;
            // 
            // dtPickerYmd
            // 
            this.dtPickerYmd.CustomFormat = "yyyy-MM-dd";
            this.dtPickerYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerYmd.Location = new System.Drawing.Point(240, 184);
            this.dtPickerYmd.Name = "dtPickerYmd";
            this.dtPickerYmd.Size = new System.Drawing.Size(138, 25);
            this.dtPickerYmd.TabIndex = 1;
            // 
            // dtPickerHms
            // 
            this.dtPickerHms.CustomFormat = "HH:mm:ss";
            this.dtPickerHms.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerHms.Location = new System.Drawing.Point(385, 184);
            this.dtPickerHms.Name = "dtPickerHms";
            this.dtPickerHms.ShowUpDown = true;
            this.dtPickerHms.Size = new System.Drawing.Size(114, 25);
            this.dtPickerHms.TabIndex = 2;
            // 
            // DateTimePickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtPickerHms);
            this.Controls.Add(this.dtPickerYmd);
            this.Controls.Add(this.dtPicker);
            this.Name = "DateTimePickerForm";
            this.Text = "时间控件";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.DateTimePicker dtPickerYmd;
        private System.Windows.Forms.DateTimePicker dtPickerHms;
    }
}