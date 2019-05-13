namespace OrderTest_UI_
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.modify_no = new System.Windows.Forms.Label();
            this.modify_no_textbox = new System.Windows.Forms.TextBox();
            this.modify_name = new System.Windows.Forms.Label();
            this.modify_name_textbox = new System.Windows.Forms.TextBox();
            this.modify_client_textbox = new System.Windows.Forms.TextBox();
            this.modify_client = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(240, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modify_no
            // 
            this.modify_no.AutoSize = true;
            this.modify_no.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modify_no.Location = new System.Drawing.Point(117, 61);
            this.modify_no.Name = "modify_no";
            this.modify_no.Size = new System.Drawing.Size(165, 37);
            this.modify_no.TabIndex = 1;
            this.modify_no.Text = "订单号：";
            // 
            // modify_no_textbox
            // 
            this.modify_no_textbox.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_no_textbox.Location = new System.Drawing.Point(343, 57);
            this.modify_no_textbox.Name = "modify_no_textbox";
            this.modify_no_textbox.Size = new System.Drawing.Size(213, 50);
            this.modify_no_textbox.TabIndex = 2;
            // 
            // modify_name
            // 
            this.modify_name.AutoSize = true;
            this.modify_name.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modify_name.Location = new System.Drawing.Point(117, 144);
            this.modify_name.Name = "modify_name";
            this.modify_name.Size = new System.Drawing.Size(165, 37);
            this.modify_name.TabIndex = 3;
            this.modify_name.Text = "商品名：";
            // 
            // modify_name_textbox
            // 
            this.modify_name_textbox.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_name_textbox.Location = new System.Drawing.Point(343, 140);
            this.modify_name_textbox.Name = "modify_name_textbox";
            this.modify_name_textbox.Size = new System.Drawing.Size(213, 50);
            this.modify_name_textbox.TabIndex = 4;
            // 
            // modify_client_textbox
            // 
            this.modify_client_textbox.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_client_textbox.Location = new System.Drawing.Point(343, 222);
            this.modify_client_textbox.Name = "modify_client_textbox";
            this.modify_client_textbox.Size = new System.Drawing.Size(213, 50);
            this.modify_client_textbox.TabIndex = 5;
            // 
            // modify_client
            // 
            this.modify_client.AutoSize = true;
            this.modify_client.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modify_client.Location = new System.Drawing.Point(117, 226);
            this.modify_client.Name = "modify_client";
            this.modify_client.Size = new System.Drawing.Size(165, 37);
            this.modify_client.TabIndex = 6;
            this.modify_client.Text = "客户名：";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modify_client);
            this.Controls.Add(this.modify_client_textbox);
            this.Controls.Add(this.modify_name_textbox);
            this.Controls.Add(this.modify_name);
            this.Controls.Add(this.modify_no_textbox);
            this.Controls.Add(this.modify_no);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "修改订单";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label modify_no;
        private System.Windows.Forms.TextBox modify_no_textbox;
        private System.Windows.Forms.Label modify_name;
        private System.Windows.Forms.TextBox modify_name_textbox;
        private System.Windows.Forms.TextBox modify_client_textbox;
        private System.Windows.Forms.Label modify_client;
    }
}