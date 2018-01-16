namespace Managament_of_set_meal
{
    partial class FrmMain
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
            this.gbxNewSetMeal = new System.Windows.Forms.GroupBox();
            this.txtSetName = new System.Windows.Forms.TextBox();
            this.lblSetName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxSelectMeal = new System.Windows.Forms.GroupBox();
            this.txtSetName2 = new System.Windows.Forms.TextBox();
            this.txtAllPrice = new System.Windows.Forms.TextBox();
            this.lkllblAllPrice = new System.Windows.Forms.LinkLabel();
            this.lklblName = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lklblXXX = new System.Windows.Forms.LinkLabel();
            this.btnDelect = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.cbxManage = new System.Windows.Forms.ComboBox();
            this.cbxList = new System.Windows.Forms.ComboBox();
            this.lblManage = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.gbxNewSetMeal.SuspendLayout();
            this.gbxSelectMeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxNewSetMeal
            // 
            this.gbxNewSetMeal.Controls.Add(this.txtSetName);
            this.gbxNewSetMeal.Controls.Add(this.lblSetName);
            this.gbxNewSetMeal.Controls.Add(this.btnAdd);
            this.gbxNewSetMeal.Location = new System.Drawing.Point(18, 18);
            this.gbxNewSetMeal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxNewSetMeal.Name = "gbxNewSetMeal";
            this.gbxNewSetMeal.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxNewSetMeal.Size = new System.Drawing.Size(758, 135);
            this.gbxNewSetMeal.TabIndex = 0;
            this.gbxNewSetMeal.TabStop = false;
            this.gbxNewSetMeal.Text = "新建套餐";
            // 
            // txtSetName
            // 
            this.txtSetName.Location = new System.Drawing.Point(210, 48);
            this.txtSetName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSetName.Name = "txtSetName";
            this.txtSetName.Size = new System.Drawing.Size(264, 28);
            this.txtSetName.TabIndex = 1;
            // 
            // lblSetName
            // 
            this.lblSetName.AutoSize = true;
            this.lblSetName.Location = new System.Drawing.Point(126, 52);
            this.lblSetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSetName.Name = "lblSetName";
            this.lblSetName.Size = new System.Drawing.Size(80, 18);
            this.lblSetName.TabIndex = 0;
            this.lblSetName.Text = "套餐名称";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(526, 45);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxSelectMeal
            // 
            this.gbxSelectMeal.Controls.Add(this.txtSetName2);
            this.gbxSelectMeal.Controls.Add(this.txtAllPrice);
            this.gbxSelectMeal.Controls.Add(this.lkllblAllPrice);
            this.gbxSelectMeal.Controls.Add(this.lklblName);
            this.gbxSelectMeal.Controls.Add(this.dataGridView1);
            this.gbxSelectMeal.Controls.Add(this.lklblXXX);
            this.gbxSelectMeal.Controls.Add(this.btnDelect);
            this.gbxSelectMeal.Controls.Add(this.btnAdd2);
            this.gbxSelectMeal.Controls.Add(this.cbxManage);
            this.gbxSelectMeal.Controls.Add(this.cbxList);
            this.gbxSelectMeal.Controls.Add(this.lblManage);
            this.gbxSelectMeal.Controls.Add(this.lblList);
            this.gbxSelectMeal.Location = new System.Drawing.Point(18, 182);
            this.gbxSelectMeal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSelectMeal.Name = "gbxSelectMeal";
            this.gbxSelectMeal.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxSelectMeal.Size = new System.Drawing.Size(758, 459);
            this.gbxSelectMeal.TabIndex = 0;
            this.gbxSelectMeal.TabStop = false;
            this.gbxSelectMeal.Text = "检查套餐维护";
            // 
            // txtSetName2
            // 
            this.txtSetName2.Location = new System.Drawing.Point(111, 152);
            this.txtSetName2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSetName2.Name = "txtSetName2";
            this.txtSetName2.ReadOnly = true;
            this.txtSetName2.Size = new System.Drawing.Size(148, 28);
            this.txtSetName2.TabIndex = 7;
            // 
            // txtAllPrice
            // 
            this.txtAllPrice.Location = new System.Drawing.Point(352, 152);
            this.txtAllPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAllPrice.Name = "txtAllPrice";
            this.txtAllPrice.ReadOnly = true;
            this.txtAllPrice.Size = new System.Drawing.Size(148, 28);
            this.txtAllPrice.TabIndex = 7;
            // 
            // lkllblAllPrice
            // 
            this.lkllblAllPrice.AutoSize = true;
            this.lkllblAllPrice.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lkllblAllPrice.LinkColor = System.Drawing.Color.Black;
            this.lkllblAllPrice.Location = new System.Drawing.Point(291, 156);
            this.lkllblAllPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lkllblAllPrice.Name = "lkllblAllPrice";
            this.lkllblAllPrice.Size = new System.Drawing.Size(53, 18);
            this.lkllblAllPrice.TabIndex = 6;
            this.lkllblAllPrice.TabStop = true;
            this.lkllblAllPrice.Text = "价格:";
            // 
            // lklblName
            // 
            this.lklblName.AutoSize = true;
            this.lklblName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklblName.LinkColor = System.Drawing.Color.Black;
            this.lklblName.Location = new System.Drawing.Point(146, 156);
            this.lklblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklblName.Name = "lklblName";
            this.lklblName.Size = new System.Drawing.Size(0, 18);
            this.lklblName.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.set,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(9, 198);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(740, 238);
            this.dataGridView1.TabIndex = 4;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "项目名";
            this.Name.Name = "Name";
            // 
            // set
            // 
            this.set.DataPropertyName = "desciption";
            this.set.HeaderText = "描述";
            this.set.Name = "set";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "价格";
            this.price.Name = "price";
            // 
            // lklblXXX
            // 
            this.lklblXXX.AutoSize = true;
            this.lklblXXX.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklblXXX.LinkColor = System.Drawing.Color.Black;
            this.lklblXXX.Location = new System.Drawing.Point(36, 156);
            this.lklblXXX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklblXXX.Name = "lklblXXX";
            this.lklblXXX.Size = new System.Drawing.Size(80, 18);
            this.lklblXXX.TabIndex = 3;
            this.lklblXXX.TabStop = true;
            this.lklblXXX.Text = "套餐名: ";
            // 
            // btnDelect
            // 
            this.btnDelect.Location = new System.Drawing.Point(560, 99);
            this.btnDelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelect.Name = "btnDelect";
            this.btnDelect.Size = new System.Drawing.Size(112, 34);
            this.btnDelect.TabIndex = 2;
            this.btnDelect.Text = "删除";
            this.btnDelect.UseVisualStyleBackColor = true;
            this.btnDelect.Click += new System.EventHandler(this.btnDelect_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(402, 99);
            this.btnAdd2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(112, 34);
            this.btnAdd2.TabIndex = 2;
            this.btnAdd2.Text = "添加";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // cbxManage
            // 
            this.cbxManage.FormattingEnabled = true;
            this.cbxManage.Location = new System.Drawing.Point(510, 45);
            this.cbxManage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxManage.Name = "cbxManage";
            this.cbxManage.Size = new System.Drawing.Size(180, 26);
            this.cbxManage.TabIndex = 1;
            // 
            // cbxList
            // 
            this.cbxList.FormattingEnabled = true;
            this.cbxList.Location = new System.Drawing.Point(172, 50);
            this.cbxList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxList.Name = "cbxList";
            this.cbxList.Size = new System.Drawing.Size(180, 26);
            this.cbxList.TabIndex = 1;
            this.cbxList.SelectedIndexChanged += new System.EventHandler(this.cbxList_SelectedIndexChanged);
            // 
            // lblManage
            // 
            this.lblManage.AutoSize = true;
            this.lblManage.Location = new System.Drawing.Point(414, 50);
            this.lblManage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(80, 18);
            this.lblManage.TabIndex = 0;
            this.lblManage.Text = "检查项目";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(76, 54);
            this.lblList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(80, 18);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "套餐列表";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 658);
            this.Controls.Add(this.gbxSelectMeal);
            this.Controls.Add(this.gbxNewSetMeal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "体验套餐管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbxNewSetMeal.ResumeLayout(false);
            this.gbxNewSetMeal.PerformLayout();
            this.gbxSelectMeal.ResumeLayout(false);
            this.gbxSelectMeal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxNewSetMeal;
        private System.Windows.Forms.TextBox txtSetName;
        private System.Windows.Forms.Label lblSetName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxSelectMeal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel lklblXXX;
        private System.Windows.Forms.Button btnDelect;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.ComboBox cbxList;
        private System.Windows.Forms.Label lblManage;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.LinkLabel lkllblAllPrice;
        private System.Windows.Forms.LinkLabel lklblName;
        private System.Windows.Forms.TextBox txtAllPrice;
        private System.Windows.Forms.ComboBox cbxManage;
        private System.Windows.Forms.TextBox txtSetName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn set;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}

