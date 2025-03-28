﻿namespace WinformStudy
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnOpenForm2 = new System.Windows.Forms.Button();
            this.lbpsw = new System.Windows.Forms.Label();
            this.txbpsw = new System.Windows.Forms.TextBox();
            this.txbWithph = new WinformStudy.TextBoxWithPlaceHolder();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(130, 86);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(52, 15);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "用户名";
            this.labelUserName.Click += new System.EventHandler(this.labelUserName_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(240, 86);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 25);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(107, 346);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnOpenForm2
            // 
            this.btnOpenForm2.Location = new System.Drawing.Point(270, 346);
            this.btnOpenForm2.Name = "btnOpenForm2";
            this.btnOpenForm2.Size = new System.Drawing.Size(135, 23);
            this.btnOpenForm2.TabIndex = 3;
            this.btnOpenForm2.Text = "打开form2";
            this.btnOpenForm2.UseVisualStyleBackColor = true;
            this.btnOpenForm2.Click += new System.EventHandler(this.btnOpenForm2_Click);
            // 
            // lbpsw
            // 
            this.lbpsw.AutoSize = true;
            this.lbpsw.Location = new System.Drawing.Point(130, 132);
            this.lbpsw.Name = "lbpsw";
            this.lbpsw.Size = new System.Drawing.Size(37, 15);
            this.lbpsw.TabIndex = 4;
            this.lbpsw.Text = "密码";
            // 
            // txbpsw
            // 
            this.txbpsw.Location = new System.Drawing.Point(240, 132);
            this.txbpsw.Name = "txbpsw";
            this.txbpsw.PasswordChar = '*';
            this.txbpsw.Size = new System.Drawing.Size(100, 25);
            this.txbpsw.TabIndex = 5;
            // 
            // txbWithph
            // 
            this.txbWithph.Location = new System.Drawing.Point(240, 206);
            this.txbWithph.Name = "txbWithph";
            this.txbWithph.PlaceHolder = "请输入信息";
            this.txbWithph.RegExp = "^[0-9]*$";
            this.txbWithph.RegExpFailureText = "正则信息验证失败";
            this.txbWithph.Size = new System.Drawing.Size(100, 25);
            this.txbWithph.TabIndex = 6;
            this.txbWithph.TextChanged += new System.EventHandler(this.txbWithph_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbWithph);
            this.Controls.Add(this.txbpsw);
            this.Controls.Add(this.lbpsw);
            this.Controls.Add(this.btnOpenForm2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labelUserName);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "窗体1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnOpenForm2;
        private System.Windows.Forms.Label lbpsw;
        private System.Windows.Forms.TextBox txbpsw;
        private TextBoxWithPlaceHolder txbWithph;
    }
}

