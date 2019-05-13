namespace OrderTest_UI_
{
    partial class main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete_menu = new System.Windows.Forms.RadioButton();
            this.modify_menu = new System.Windows.Forms.RadioButton();
            this.build_menu = new System.Windows.Forms.RadioButton();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.search_menu = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete_menu);
            this.groupBox1.Controls.Add(this.modify_menu);
            this.groupBox1.Controls.Add(this.build_menu);
            this.groupBox1.Controls.Add(this.TextInput);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.search_menu);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1348, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // delete_menu
            // 
            this.delete_menu.AutoSize = true;
            this.delete_menu.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete_menu.Location = new System.Drawing.Point(1137, 27);
            this.delete_menu.Name = "delete_menu";
            this.delete_menu.Size = new System.Drawing.Size(196, 41);
            this.delete_menu.TabIndex = 9;
            this.delete_menu.TabStop = true;
            this.delete_menu.Text = "删除订单";
            this.delete_menu.UseVisualStyleBackColor = true;
            this.delete_menu.CheckedChanged += new System.EventHandler(this.delete_menu_CheckedChanged);
            // 
            // modify_menu
            // 
            this.modify_menu.AutoSize = true;
            this.modify_menu.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modify_menu.Location = new System.Drawing.Point(922, 27);
            this.modify_menu.Name = "modify_menu";
            this.modify_menu.Size = new System.Drawing.Size(196, 41);
            this.modify_menu.TabIndex = 8;
            this.modify_menu.TabStop = true;
            this.modify_menu.Text = "修改订单";
            this.modify_menu.UseVisualStyleBackColor = true;
            this.modify_menu.CheckedChanged += new System.EventHandler(this.modify_menu_CheckedChanged);
            // 
            // build_menu
            // 
            this.build_menu.AutoSize = true;
            this.build_menu.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.build_menu.Location = new System.Drawing.Point(694, 27);
            this.build_menu.Name = "build_menu";
            this.build_menu.Size = new System.Drawing.Size(196, 41);
            this.build_menu.TabIndex = 7;
            this.build_menu.TabStop = true;
            this.build_menu.Text = "新建订单";
            this.build_menu.UseVisualStyleBackColor = true;
            this.build_menu.CheckedChanged += new System.EventHandler(this.build_menu_CheckedChanged);
            // 
            // TextInput
            // 
            this.TextInput.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextInput.Location = new System.Drawing.Point(43, 24);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(247, 44);
            this.TextInput.TabIndex = 6;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search.Location = new System.Drawing.Point(334, 24);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(113, 53);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // search_menu
            // 
            this.search_menu.AutoSize = true;
            this.search_menu.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search_menu.Location = new System.Drawing.Point(473, 28);
            this.search_menu.Name = "search_menu";
            this.search_menu.Size = new System.Drawing.Size(196, 41);
            this.search_menu.TabIndex = 3;
            this.search_menu.TabStop = true;
            this.search_menu.Text = "查询订单";
            this.search_menu.UseVisualStyleBackColor = true;
            this.search_menu.CheckedChanged += new System.EventHandler(this.search_menu_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grid);
            this.groupBox2.Location = new System.Drawing.Point(4, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1348, 506);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(3, 31);
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 37;
            this.grid.Size = new System.Drawing.Size(1342, 472);
            this.grid.TabIndex = 4;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "订单管理系统";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton search_menu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.RadioButton delete_menu;
        private System.Windows.Forms.RadioButton modify_menu;
        private System.Windows.Forms.RadioButton build_menu;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn mynoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}

