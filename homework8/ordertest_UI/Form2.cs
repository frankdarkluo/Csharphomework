using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderTest_UI_
{
    public partial class Form2 : Form
    {
        public int OrderNo { get; set; }
        public string name1 { get; set; }
        public string Client { get; set; }
        public Order order;
        public Form2(Order order)
        {
            InitializeComponent();
            this.order = order;
            no_textbox.DataBindings.Add("Text", this, "OrderNo");
            name_textbox.DataBindings.Add("Text", this, "name1");
            client_textbox.DataBindings.Add("Text", this, "Client");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.order.no = this.OrderNo;
            this.order.name = this.name1;
            this.order.client = this.Client;
            this.Dispose();
        }
    }
}
