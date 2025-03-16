namespace WinformStudy
{
    partial class RadioButtonCheckBoxForm
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
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.btSubmit = new System.Windows.Forms.Button();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.cbMusic = new System.Windows.Forms.CheckBox();
            this.cbFootball = new System.Windows.Forms.CheckBox();
            this.cbTableTennis = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(140, 82);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(43, 19);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "男";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(140, 213);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 1;
            this.btSubmit.Text = "提交";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbFemale.Location = new System.Drawing.Point(208, 81);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(43, 19);
            this.rbFemale.TabIndex = 2;
            this.rbFemale.Text = "女";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // cbMusic
            // 
            this.cbMusic.AutoSize = true;
            this.cbMusic.Location = new System.Drawing.Point(140, 156);
            this.cbMusic.Name = "cbMusic";
            this.cbMusic.Size = new System.Drawing.Size(59, 19);
            this.cbMusic.TabIndex = 3;
            this.cbMusic.Text = "音乐";
            this.cbMusic.UseVisualStyleBackColor = true;
            this.cbMusic.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbFootball
            // 
            this.cbFootball.AutoSize = true;
            this.cbFootball.Location = new System.Drawing.Point(278, 156);
            this.cbFootball.Name = "cbFootball";
            this.cbFootball.Size = new System.Drawing.Size(59, 19);
            this.cbFootball.TabIndex = 4;
            this.cbFootball.Text = "足球";
            this.cbFootball.UseVisualStyleBackColor = true;
            this.cbFootball.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbTableTennis
            // 
            this.cbTableTennis.AutoSize = true;
            this.cbTableTennis.Location = new System.Drawing.Point(401, 156);
            this.cbTableTennis.Name = "cbTableTennis";
            this.cbTableTennis.Size = new System.Drawing.Size(59, 19);
            this.cbTableTennis.TabIndex = 5;
            this.cbTableTennis.Text = "桌球";
            this.cbTableTennis.UseVisualStyleBackColor = true;
            // 
            // RadioButtonCheckBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTableTennis);
            this.Controls.Add(this.cbFootball);
            this.Controls.Add(this.cbMusic);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.rbMale);
            this.Name = "RadioButtonCheckBoxForm";
            this.Text = "单选多选框窗体";
            this.Load += new System.EventHandler(this.RadioButtonCheckBoxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.CheckBox cbMusic;
        private System.Windows.Forms.CheckBox cbFootball;
        private System.Windows.Forms.CheckBox cbTableTennis;
    }
}