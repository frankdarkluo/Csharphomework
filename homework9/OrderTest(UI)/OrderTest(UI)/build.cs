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
    public partial class build : Form
    {

        public build()
        {
            InitializeComponent();
        }
        private void Build_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = no_textbox.Text;
            string str2 = name_textbox.Text;
            string str3 = client_textbox.Text;
            string str4 = txt_buycount.Text;
            string str5 = txt_price.Text;
            string cons = "server=localhost;uid='root';pwd=123;database=orderlists";
            MySqlConnection conn = new MySqlConnection(cons);
            MySqlDataAdapter s = new MySqlDataAdapter("INSERT INTO orderlist VALUES(" + str1 + ",'" + str2 + "','" + str3 + "'," + str4 + "," + str5 + ")", conn);
            DataSet d = new DataSet();
            s.Fill(d, "t");
            this.Close();
        }
    }
}
