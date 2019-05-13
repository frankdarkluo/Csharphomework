using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OrderTest_UI_
{
    class dblink
    {
        MySqlConnection sqlcnn = new MySqlConnection();
        MySqlCommand sqlcmd = new MySqlCommand();
        public Boolean dbtag = false;
        public Boolean DBcnn()
        {
            sqlcnn.ConnectionString = "server=localhost;uid='root';pwd=123;database=orderlists";
            sqlcmd.Connection = sqlcnn;
            try
            {
                sqlcnn.Open();
                dbtag = true;
                if (dbtag)
                    Console.WriteLine("数据库连接成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
            finally
            {

            }
            return dbtag;
        }
    }
}
