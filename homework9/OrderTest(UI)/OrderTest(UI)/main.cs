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
    public partial class main : Form
    {
        public int Keyword { get; set; }
        
        public void init(){
            
        }
        RadioButton search, build, modify, delete;
        public main()
        {
            InitializeComponent();
            init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cons = "server=localhost;uid='root';pwd=123;database=orderlists";
            MySqlConnection conn = new MySqlConnection(cons);
            MySqlDataAdapter s = new MySqlDataAdapter("select * from orderlist", conn);
            DataSet d = new DataSet();
            s.Fill(d, "t");
            grid.DataSource = d.Tables["t"];
            grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void search_menu_CheckedChanged(object sender, EventArgs e)
        {
            if (search_menu.Checked)
            {
                search = search_menu;
                TextInput.ReadOnly = false;
                grid.ReadOnly = true;
                Form1_Load(sender, e);
            }
            
        }

        private void build_menu_CheckedChanged(object sender, EventArgs e)
        {
            build bd = new build();
            
            if (build_menu.Checked)
            {
                bd.ShowDialog();
            }
        }

        private void modify_menu_CheckedChanged(object sender, EventArgs e)
        {
            Order old_order = new Order();
            Modify dialog2 = new Modify();
            if (modify_menu.Checked)
            {
                modify = modify_menu;
                TextInput.ReadOnly = true;
                grid.ReadOnly = false;
                dialog2.ShowDialog();
               
            }
        }

        private void delete_menu_CheckedChanged(object sender, EventArgs e)
        {
            if (delete_menu.Checked)
            {
                Delete del = new Delete();
                del.Show();
                
            }
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            string cons = "server=localhost;uid='root';pwd=123;database=orderlists";
            MySqlConnection conn = new MySqlConnection(cons);
            MySqlDataAdapter s = new MySqlDataAdapter("select * from orderlist where OrderId="+Convert.ToInt32(TextInput.Text), conn);
            if (TextInput.Text == "" || TextInput.Text == null)
                Form1_Load(sender, e);
            DataSet d = new DataSet();
            s.Fill(d, "t");
            grid.DataSource = d.Tables["t"];
            grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            try
            {

            }
            catch (Exception ee)
            {
                if (Convert.ToInt32(TextInput.Text) > grid.RowCount)
                    MessageBox.Show(ee.Message, "error");
            }
        }
    }
}
