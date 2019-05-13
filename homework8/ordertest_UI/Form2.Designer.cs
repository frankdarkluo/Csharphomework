namespace OrderTest_UI_
{
    partial class Form2
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
            this.no = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.no_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.client = new System.Windows.Forms.Label();
            this.client_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.no.Location = new System.Drawing.Point(100, 61);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(165, 37);
            this.no.TabIndex = 0;
            this.no.Text = "订单号：";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(100, 163);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(165, 37);
            this.name.TabIndex = 1;
            this.name.Text = "商品名：";
            // 
            // no_textbox
            // 
            this.no_textbox.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_textbox.Location = new System.Drawing.Point(273, 57);
            this.no_textbox.Name = "no_textbox";
            this.no_textbox.Size = new System.Drawing.Size(252, 50);
            this.no_textbox.TabIndex = 2;
            this.no_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textbox.Location = new System.Drawing.Point(273, 159);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(252, 50);
            this.name_textbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(213, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // client
            // 
            this.client.AutoSize = true;
            this.client.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.client.Location = new System.Drawing.Point(100, 265);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(165, 37);
            this.client.TabIndex = 5;
            this.client.Text = "客户名：";
            // 
            // client_textbox
            // 
            this.client_textbox.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_textbox.Location = new System.Drawing.Point(273, 261);
            this.client_textbox.Name = "client_textbox";
            this.client_textbox.Size = new System.Drawing.Size(252, 50);
            this.client_textbox.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 473);
            this.Controls.Add(this.client_textbox);
            this.Controls.Add(this.client);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.no_textbox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.no);
            this.Name = "Form2";
            this.Text = "新建订单";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label no;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox no_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label client;
        private System.Windows.Forms.TextBox client_textbox;
    }
}