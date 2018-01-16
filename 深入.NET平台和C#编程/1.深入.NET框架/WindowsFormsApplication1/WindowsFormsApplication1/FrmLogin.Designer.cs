namespace WindowsFormsApplication1
{
    partial class FrmLogin
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lalEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lalPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblEP = new System.Windows.Forms.Label();
            this.linklblZC = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 91);
            this.panel1.TabIndex = 0;
            // 
            // lalEmail
            // 
            this.lalEmail.AutoSize = true;
            this.lalEmail.ForeColor = System.Drawing.Color.White;
            this.lalEmail.Location = new System.Drawing.Point(71, 104);
            this.lalEmail.Name = "lalEmail";
            this.lalEmail.Size = new System.Drawing.Size(77, 12);
            this.lalEmail.TabIndex = 1;
            this.lalEmail.Text = "电子邮件地址";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(73, 130);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(336, 21);
            this.txtEmail.TabIndex = 2;
            // 
            // lalPwd
            // 
            this.lalPwd.AutoSize = true;
            this.lalPwd.ForeColor = System.Drawing.Color.White;
            this.lalPwd.Location = new System.Drawing.Point(71, 186);
            this.lalPwd.Name = "lalPwd";
            this.lalPwd.Size = new System.Drawing.Size(29, 12);
            this.lalPwd.TabIndex = 1;
            this.lalPwd.Text = "密码";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(73, 212);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(336, 21);
            this.txtPwd.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(73, 271);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 33);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblEP
            // 
            this.lblEP.AutoSize = true;
            this.lblEP.ForeColor = System.Drawing.Color.White;
            this.lblEP.Location = new System.Drawing.Point(71, 349);
            this.lblEP.Name = "lblEP";
            this.lblEP.Size = new System.Drawing.Size(119, 12);
            this.lblEP.TabIndex = 5;
            this.lblEP.Text = "还没有通行证?现在就";
            // 
            // linklblZC
            // 
            this.linklblZC.AutoSize = true;
            this.linklblZC.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linklblZC.Location = new System.Drawing.Point(196, 349);
            this.linklblZC.Name = "linklblZC";
            this.linklblZC.Size = new System.Drawing.Size(29, 12);
            this.linklblZC.TabIndex = 4;
            this.linklblZC.TabStop = true;
            this.linklblZC.Text = "注册";
            this.linklblZC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblZC_LinkClicked);
            this.linklblZC.Click += new System.EventHandler(this.linklblZC_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(532, 448);
            this.Controls.Add(this.lblEP);
            this.Controls.Add(this.linklblZC);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lalPwd);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lalEmail);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lalEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lalPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblEP;
        private System.Windows.Forms.LinkLabel linklblZC;
    }
}

