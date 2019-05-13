using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OrderTest_UI_
{
    public partial class Modify : Form
    {
        public int OrderNo { get; set; }
        public string name1 { get; set; }
        public string Client { get; set; }
        public Order order;
        public Modify()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = modify_no_textbox.Text;
            string str2 = modify_name_textbox.Text;
            string str3 = modify_client_textbox.Text;
            string str4 = txt_buycount.Text;
            string str5 = txt_price.Text;
            string cons = "server=localhost;uid='root';pwd=123;database=orderlists";
            MySqlConnection conn = new MySqlConnection(cons);
            MySqlDataAdapter s = new MySqlDataAdapter("UPDATE orderlist SET Product='"+str2+"',Client='"+str3+"',Buy_count=" + str4 + ",Price=" + str5+" WHERE OrderId="+str1, conn);
            DataSet d = new DataSet();
            s.Fill(d, "t");
            this.Close();
        }
    }
}
