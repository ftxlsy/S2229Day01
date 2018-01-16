namespace ATM
{
    partial class FrmATM
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
            this.gbxSelect = new System.Windows.Forms.GroupBox();
            this.lblMoney1 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.btndraw = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblbalance = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.gbxforward = new System.Windows.Forms.GroupBox();
            this.lblMoney2 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtMoney2 = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnforward = new System.Windows.Forms.Button();
            this.gbxMessage = new System.Windows.Forms.GroupBox();
            this.lblNumZH = new System.Windows.Forms.Label();
            this.lblNameA = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNuser = new System.Windows.Forms.Label();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.btnplug_off = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnplug_in = new System.Windows.Forms.Button();
            this.gbxSelect.SuspendLayout();
            this.gbxforward.SuspendLayout();
            this.gbxMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSelect
            // 
            this.gbxSelect.Controls.Add(this.lblMoney1);
            this.gbxSelect.Controls.Add(this.txtMoney);
            this.gbxSelect.Controls.Add(this.btndraw);
            this.gbxSelect.Controls.Add(this.btnSelect);
            this.gbxSelect.Controls.Add(this.lblbalance);
            this.gbxSelect.Controls.Add(this.lblMoney);
            this.gbxSelect.Location = new System.Drawing.Point(12, 21);
            this.gbxSelect.Name = "gbxSelect";
            this.gbxSelect.Size = new System.Drawing.Size(555, 141);
            this.gbxSelect.TabIndex = 0;
            this.gbxSelect.TabStop = false;
            this.gbxSelect.Text = "查询取款";
            // 
            // lblMoney1
            // 
            this.lblMoney1.AutoSize = true;
            this.lblMoney1.Location = new System.Drawing.Point(295, 50);
            this.lblMoney1.Name = "lblMoney1";
            this.lblMoney1.Size = new System.Drawing.Size(62, 18);
            this.lblMoney1.TabIndex = 0;
            this.lblMoney1.Text = "label1";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(298, 89);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(183, 28);
            this.txtMoney.TabIndex = 2;
            // 
            // btndraw
            // 
            this.btndraw.Location = new System.Drawing.Point(82, 90);
            this.btndraw.Name = "btndraw";
            this.btndraw.Size = new System.Drawing.Size(75, 27);
            this.btndraw.TabIndex = 1;
            this.btndraw.Text = "取款";
            this.btndraw.UseVisualStyleBackColor = true;
            this.btndraw.Click += new System.EventHandler(this.btndraw_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(82, 46);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 27);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblbalance
            // 
            this.lblbalance.AutoSize = true;
            this.lblbalance.Location = new System.Drawing.Point(185, 51);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(62, 18);
            this.lblbalance.TabIndex = 0;
            this.lblbalance.Text = "余额：";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(185, 92);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(62, 18);
            this.lblMoney.TabIndex = 0;
            this.lblMoney.Text = "金额：";
            // 
            // gbxforward
            // 
            this.gbxforward.Controls.Add(this.lblMoney2);
            this.gbxforward.Controls.Add(this.lblNum);
            this.gbxforward.Controls.Add(this.txtMoney2);
            this.gbxforward.Controls.Add(this.txtNum);
            this.gbxforward.Controls.Add(this.btnforward);
            this.gbxforward.Location = new System.Drawing.Point(12, 186);
            this.gbxforward.Name = "gbxforward";
            this.gbxforward.Size = new System.Drawing.Size(555, 151);
            this.gbxforward.TabIndex = 1;
            this.gbxforward.TabStop = false;
            this.gbxforward.Text = "转账";
            // 
            // lblMoney2
            // 
            this.lblMoney2.AutoSize = true;
            this.lblMoney2.Location = new System.Drawing.Point(185, 56);
            this.lblMoney2.Name = "lblMoney2";
            this.lblMoney2.Size = new System.Drawing.Size(62, 18);
            this.lblMoney2.TabIndex = 0;
            this.lblMoney2.Text = "金额：";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(185, 97);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(62, 18);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "账号：";
            // 
            // txtMoney2
            // 
            this.txtMoney2.Location = new System.Drawing.Point(298, 53);
            this.txtMoney2.Name = "txtMoney2";
            this.txtMoney2.Size = new System.Drawing.Size(183, 28);
            this.txtMoney2.TabIndex = 2;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(298, 94);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(183, 28);
            this.txtNum.TabIndex = 2;
            // 
            // btnforward
            // 
            this.btnforward.Location = new System.Drawing.Point(82, 72);
            this.btnforward.Name = "btnforward";
            this.btnforward.Size = new System.Drawing.Size(75, 28);
            this.btnforward.TabIndex = 1;
            this.btnforward.Text = "转账";
            this.btnforward.UseVisualStyleBackColor = true;
            this.btnforward.Click += new System.EventHandler(this.btnforward_Click);
            // 
            // gbxMessage
            // 
            this.gbxMessage.Controls.Add(this.lblNumZH);
            this.gbxMessage.Controls.Add(this.lblNameA);
            this.gbxMessage.Controls.Add(this.lblNum2);
            this.gbxMessage.Controls.Add(this.lblNuser);
            this.gbxMessage.Location = new System.Drawing.Point(12, 356);
            this.gbxMessage.Name = "gbxMessage";
            this.gbxMessage.Size = new System.Drawing.Size(555, 147);
            this.gbxMessage.TabIndex = 2;
            this.gbxMessage.TabStop = false;
            this.gbxMessage.Text = "详细信息";
            // 
            // lblNumZH
            // 
            this.lblNumZH.AutoSize = true;
            this.lblNumZH.Location = new System.Drawing.Point(173, 55);
            this.lblNumZH.Name = "lblNumZH";
            this.lblNumZH.Size = new System.Drawing.Size(62, 18);
            this.lblNumZH.TabIndex = 0;
            this.lblNumZH.Text = "label1";
            // 
            // lblNameA
            // 
            this.lblNameA.AutoSize = true;
            this.lblNameA.Location = new System.Drawing.Point(173, 96);
            this.lblNameA.Name = "lblNameA";
            this.lblNameA.Size = new System.Drawing.Size(62, 18);
            this.lblNameA.TabIndex = 0;
            this.lblNameA.Text = "label1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(79, 55);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(62, 18);
            this.lblNum2.TabIndex = 0;
            this.lblNum2.Text = "账号：";
            // 
            // lblNuser
            // 
            this.lblNuser.AutoSize = true;
            this.lblNuser.Location = new System.Drawing.Point(79, 96);
            this.lblNuser.Name = "lblNuser";
            this.lblNuser.Size = new System.Drawing.Size(80, 18);
            this.lblNuser.TabIndex = 0;
            this.lblNuser.Text = "用户名：";
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(104, 537);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(143, 28);
            this.txtNum3.TabIndex = 2;
            // 
            // lblNum3
            // 
            this.lblNum3.AutoSize = true;
            this.lblNum3.Location = new System.Drawing.Point(36, 540);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(62, 18);
            this.lblNum3.TabIndex = 0;
            this.lblNum3.Text = "账号：";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(376, 537);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(155, 28);
            this.txtPwd.TabIndex = 2;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(297, 540);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(62, 18);
            this.lblPwd.TabIndex = 0;
            this.lblPwd.Text = "密码：";
            // 
            // btnplug_off
            // 
            this.btnplug_off.Location = new System.Drawing.Point(238, 600);
            this.btnplug_off.Name = "btnplug_off";
            this.btnplug_off.Size = new System.Drawing.Size(75, 28);
            this.btnplug_off.TabIndex = 1;
            this.btnplug_off.Text = "退卡";
            this.btnplug_off.UseVisualStyleBackColor = true;
            this.btnplug_off.Click += new System.EventHandler(this.btnplug_off_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(348, 600);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 28);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnplug_in
            // 
            this.btnplug_in.Location = new System.Drawing.Point(132, 600);
            this.btnplug_in.Name = "btnplug_in";
            this.btnplug_in.Size = new System.Drawing.Size(75, 28);
            this.btnplug_in.TabIndex = 1;
            this.btnplug_in.Text = "插卡";
            this.btnplug_in.UseVisualStyleBackColor = true;
            this.btnplug_in.Click += new System.EventHandler(this.btnplug_in_Click);
            // 
            // FrmATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 661);
            this.Controls.Add(this.gbxMessage);
            this.Controls.Add(this.btnplug_in);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnplug_off);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.gbxforward);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.gbxSelect);
            this.Controls.Add(this.txtNum3);
            this.Name = "FrmATM";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmATM_Load);
            this.gbxSelect.ResumeLayout(false);
            this.gbxSelect.PerformLayout();
            this.gbxforward.ResumeLayout(false);
            this.gbxforward.PerformLayout();
            this.gbxMessage.ResumeLayout(false);
            this.gbxMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSelect;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button btndraw;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblbalance;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.GroupBox gbxforward;
        private System.Windows.Forms.Label lblMoney2;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtMoney2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnforward;
        private System.Windows.Forms.GroupBox gbxMessage;
        private System.Windows.Forms.Label lblNumZH;
        private System.Windows.Forms.Label lblNameA;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNuser;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Button btnplug_off;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnplug_in;
        private System.Windows.Forms.Label lblMoney1;
    }
}

