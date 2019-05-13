using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_ordertest
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("InsertDetail:莫言");
            InsertDetails();
            QueryDetails();
            Console.WriteLine("DeleteDetail:莫言");
            DeleteDetails();
            QueryDetails();
            Console.WriteLine("ModifyDetail:Dicky");
            ModifyDetails();
            QueryDetails();
            Console.WriteLine("QueryDetailsAndOrder:");
            QueryDetailsAndOrder();
            Console.ReadKey();
        }

        private static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(
                "datasource=localhost;username=root;" +
                "password=123;database=orderlist;charset=utf8");
            connection.Open();
            return connection;
        }

        //增
        private static void InsertDetails(){
            using(MySqlConnection connection = GetConnection()){
                using (MySqlCommand cmd=new MySqlCommand
                ("INSERT INTO Details(Name) VALUES(@Name)", connection)){
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@Name", "莫言");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //删
        private static void DeleteDetails(){
            using (MySqlConnection connection = GetConnection()){
                using (MySqlCommand cmd = new MySqlCommand
                ("delete from details where Name= '莫言'", connection)){
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //改
        private static void ModifyDetails()
        {
            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand
                ("UPDATE  details SET Name='Dicky' where Id=24", connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //查
        private static void QueryDetailsAndOrder(){
            using (MySqlConnection connection = GetConnection()){
                string stm = @"SELECT Product,Name From Details,
                orders WHERE details.Id=orders.orderId";
                using (MySqlCommand cmd = new MySqlCommand(stm, connection)){
                    using (MySqlDataReader reader = cmd.ExecuteReader()){
                        while (reader.Read()){
                            Console.WriteLine(reader.GetString(0) + "\t" +
                             reader.GetString(1));
                        }
                    }
                }
            }
        }

        //查
        private static void QueryDetails(){
            using (MySqlConnection connection = GetConnection()){
                string stm = "SELECT * FROM details";
                using (MySqlCommand cmd = new MySqlCommand(stm, connection)){
                    using (MySqlDataReader reader = cmd.ExecuteReader()){
                        while (reader.Read()){
                            Console.WriteLine(reader.GetInt32(0) + ": "
                                + reader.GetString(1));
                        }
                    }
                }
            }
        }
    }
}
