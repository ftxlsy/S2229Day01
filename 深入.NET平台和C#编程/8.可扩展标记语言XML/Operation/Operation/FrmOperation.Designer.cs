namespace Operation
{
    partial class FrmOperation
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
            this.gbxcount = new System.Windows.Forms.GroupBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.cbxSign = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.gbxcount.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxcount
            // 
            this.gbxcount.Controls.Add(this.btnCount);
            this.gbxcount.Controls.Add(this.txtNum2);
            this.gbxcount.Controls.Add(this.txtNum1);
            this.gbxcount.Controls.Add(this.cbxSign);
            this.gbxcount.Location = new System.Drawing.Point(56, 71);
            this.gbxcount.Name = "gbxcount";
            this.gbxcount.Size = new System.Drawing.Size(696, 147);
            this.gbxcount.TabIndex = 0;
            this.gbxcount.TabStop = false;
            this.gbxcount.Text = "计算";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(551, 58);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(87, 30);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "计算";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(391, 58);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 28);
            this.txtNum2.TabIndex = 1;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(41, 60);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 28);
            this.txtNum1.TabIndex = 1;
            // 
            // cbxSign
            // 
            this.cbxSign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSign.FormattingEnabled = true;
            this.cbxSign.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbxSign.Location = new System.Drawing.Point(208, 60);
            this.cbxSign.Name = "cbxSign";
            this.cbxSign.Size = new System.Drawing.Size(121, 26);
            this.cbxSign.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "计算结果：";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(274, 277);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 18);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "label1";
            // 
            // FrmOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 356);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxcount);
            this.Name = "FrmOperation";
            this.Text = "计算器";
            this.gbxcount.ResumeLayout(false);
            this.gbxcount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxcount;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.ComboBox cbxSign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
    }
}

