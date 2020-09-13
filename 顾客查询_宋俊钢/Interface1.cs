using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    class customer
    {
        /*public struct customerInfo

        {
            public int customer_id;//买家id
            public string customer_name;//买家名
            public int proceeds;//销售额
        };

        static public List<customerInfo> GoodsStatInfo = new List<customerInfo>();*/

        /*后期改为：调用董振宇的.cs文件，此函数 为董振宇编写
         如果不具备某一参数 则令其为-1 如：2020年8月 则参数2020，8，-1*/
        static public string Date(int year, int month, int day)//日期处理

        {

            string Year, Month, Day;
            string dateTime = "%";
            if (year == -1)
            {
                return dateTime;
            }

            else
            {
                Year = year.ToString();
            }

            if (month == -1)
            {
                dateTime = Year + dateTime;
                return dateTime;
            }

            else if (month > 0 && month < 10)
            {
                Month = "0" + month.ToString();
            }
            else
            {
                Month = month.ToString();
            }

            if (day == -1)
            {
                dateTime = Year + "-" + Month + dateTime;
                return dateTime;
            }
            else if (day > 0 && day < 10)
            {
                Day = "0" + day.ToString();
            }
            else
            {
                Day = day.ToString();
            }
            dateTime = Year + "-" + Month + "-" + Day + dateTime;
            return dateTime;
        }

        /*查询某买家的订单
         * searchMode=0，按订单号查询
         * searchMode=1，按日期查询
         */
        public void month(int year, int month, int day)
        {
            string date1 = Date(year, month, day);

            /* 连接数据库*/
            string constr = "Server=localhost;DataBase=db_mall;uid=root;pwd=12345678"; //设置连接字符串
            MySqlConnection conn = new MySqlConnection(constr);                  //实例化连接对象
            conn.Open();

            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql;

                sql = "select* " +
                    "from goods natural join goods_order natural join `order` " +
                    "where date ='" + date1 + "'";

            
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date1", date1));
                cmd.ExecuteNonQuery();//用来执行sql语句
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                    //对于不同的数据库字段类型，我们需要用不同的方法获取
                    string type = reader.GetString("type");
                    int quantity = reader.GetInt32("quantity");
                    int proceeds = reader.GetInt32("proceeds");
                    /*弹框输出信息*/
                    MessageBox.Show(type + quantity.ToString() + proceeds.ToString());
                    break;
                }
            }
        }
        public void infor_search(int id)
        {



            /* 连接数据库*/
            string constr = "Server=localhost;DataBase=db_mall;uid=root;pwd=12345678"; //设置连接字符串
            MySqlConnection conn = new MySqlConnection(constr);                  //实例化连接对象
            conn.Open();

            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql;

                sql = "select* " +
                    "from customer " +
                    "where customer_id= '" + id + "'";


                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();//用来执行sql语句
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                    //对于不同的数据库字段类型，我们需要用不同的方法获取

                    int customer_id = reader.GetInt32(0);
                    string customer_name = reader.GetString(1);
                    int customer_phone_num = reader.GetInt32(2);
                    string address = reader.GetString(3);
                    /*弹框输出信息*/
                    MessageBox.Show(customer_id + customer_name.ToString() + customer_phone_num + address.ToString());
                    break;
                }
            }
        }
        public void Order_search(int year, int month, int day, int searchMode, string Order_ID, string Customer_id)
        {
            string tem = Order_ID;
            string date1 = Date(year, month, day);

            /* 连接数据库*/
            string constr = "Server=localhost;DataBase=db_mall;uid=root;pwd=12345678"; //设置连接字符串
            MySqlConnection conn = new MySqlConnection(constr);                  //实例化连接对象
            conn.Open();

            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql;
                if (searchMode == 0)//searchMode=1则表示用订单号查询
                {
                    sql = "select*" +
                        "from goods natural join goods_order " +
                        "where order_id = '" + tem + "' ";
                }
                else
                {
                    sql = "select* " +
                        "from goods natural join goods_order natural join `order` " +
                        "where date ='" + date1 + "'";
                }
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date1", date1));
                cmd.ExecuteNonQuery();//用来执行sql语句
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                    //对于不同的数据库字段类型，我们需要用不同的方法获取
                    int goods_id = reader.GetInt32("goods_id");
                    string goods_name = reader.GetString("goods_name");
                    string type = reader.GetString("type");
                    int quantity = reader.GetInt32("quantity");


                     int proceeds= reader.GetInt32("proceeds");
                    /*弹框输出信息*/
                    MessageBox.Show(goods_id + goods_name.ToString() +type.ToString()+quantity +proceeds);
                    break;
                }
            }
        }
        /*查询消费金额,按年月日，也可按类查询*/
        public void date_consumption_Records(int year, int month, int day, string Customer_id)
        {
            string date1 = Date(year, month, day);

            /* 连接数据库*/
            string constr = "Server=localhost;DataBase=db_mall;uid=root;pwd=12345678"; //设置连接字符串
            MySqlConnection conn = new MySqlConnection(constr);                  //实例化连接对象
            conn.Open();

            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql;
                
                    sql = "select* " +
                        "from goods natural join goods_order natural join `order` " +
                        "where date ='" + date1 + "'";
                
               /* else
                {
                    sql = "select sum(price) " +
                        "from goods natural join goods_order natural join `order` " +
                        "where date like @date  and type like @goodsType" +
                        "group by @ Customer_id" +
                        "order by date desc";
                }
                if(year == -1)
                {
                    sql = "select sum(price) from goods natural join goods_order natural join `order`";
                }
                else if(month == -1)
                {
                    sql = "select sum(price) " +
                        "from goods natural join goods_order natural join `order` " +
                        "where date like @date " +
                        "group by year(date) " +
                        "order by year(date) desc";
                }
                else if (day == -1)
                {
                    sql = "select sum(price) " +
                        "from goods natural join goods_order natural join `order` " +
                        "where date like @date " +
                        "group by month(date) " +
                        "order by month(date) desc";
                }
                else
                {
                    sql = "select sum(price) " +
                        "from goods natural join goods_order natural join `order` " +
                        "where date like @date ";
                }*/
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date1", date1));
                cmd.ExecuteNonQuery();//用来执行sql语句
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                    //对于不同的数据库字段类型，我们需要用不同的方法获取
                    string type = reader.GetString("type");
                        
                    int quantity = reader.GetInt32("quantity");
                    int proceeds = reader.GetInt32("proceeds");
                    /*弹框输出信息*/
                    MessageBox.Show(type + quantity.ToString() + proceeds.ToString());
                    break;
                }
            }
        }
    }
}
