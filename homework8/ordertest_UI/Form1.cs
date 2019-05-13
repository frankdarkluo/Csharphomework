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
    public partial class Form1 : Form
    {
        public List<Order> orderlist = new List<Order>();
        // 订单号，商品名，客户名
        Order order1 = new Order(1, "Apple", "Frank");
        Order order2 = new Order(2, "HUAWEI", "Jasmine");
        Order order3 = new Order(3, "Samsung", "Excelsior");
        //订单号，购买个数，单价
        OrderDetails details1 = new OrderDetails(1, 1, 6999);
        OrderDetails details2 = new OrderDetails(2, 1, 3899);
        OrderDetails details3 = new OrderDetails(3, 2, 2699);
        public int Keyword { get; set; }

        RadioButton search, build, modify, delete;
        public Form1()
        {
            InitializeComponent();
            order1.AddDetails(details1);
            order2.AddDetails(details2);
            order3.AddDetails(details3);
            orderlist.Add(order1);
            orderlist.Add(order2);
            orderlist.Add(order3);
           
            order_bs.DataSource = orderlist;
            TextInput.DataBindings.Add("Text", this, "Keyword");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
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
            }
            
        }

        

        private void build_menu_CheckedChanged(object sender, EventArgs e)
        {
            Order neworder = new Order();
            Form2 dialog1 = new Form2(neworder);
            if (build_menu.Checked)
            {
                build = build_menu;
                TextInput.ReadOnly = true;
                dialog1.Visible = false;
                dialog1.ShowDialog();
                order_bs.ResetBindings(false);
            }
           
        }

        private void modify_menu_CheckedChanged(object sender, EventArgs e)
        {
            Order old_order = new Order();
            Form3 dialog2 = new Form3(old_order);
            if (modify_menu.Checked)
            {
                modify = modify_menu;
                TextInput.ReadOnly = true;
                grid.ReadOnly = false;
                dialog2.ShowDialog();
                if (old_order.no==dialog2.OrderNo)
                {
                    old_order.no = dialog2.OrderNo;
                    old_order.name = dialog2.name1;
                    old_order.client = dialog2.Client;
                }
                order_bs.ResetBindings(false);
            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void delete_menu_CheckedChanged(object sender, EventArgs e)
        {
            if (delete_menu.Checked)
            {
                grid.Refresh();
                delete = delete_menu;
                TextInput.ReadOnly = true;
                grid.ReadOnly = false;
                order_bs.ResetBindings(false);
            }
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (Keyword.ToString() == null||Keyword.ToString()=="")
                order_bs.DataSource = orderlist;
            else
            {
                order_bs.DataSource = orderlist.Where(s => s.no == Keyword);
            } 
        }
    }
}
