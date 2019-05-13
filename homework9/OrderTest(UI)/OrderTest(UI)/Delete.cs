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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void sure_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            string cons = "server=localhost;uid='root';pwd=123;database=orderlists";
            MySqlConnection conn = new MySqlConnection(cons);
            MySqlDataAdapter s = new MySqlDataAdapter("delete from orderlist where OrderId ="+num, conn);
            DataSet d = new DataSet();
            s.Fill(d, "t");
            this.Close();
        }
    }
}
