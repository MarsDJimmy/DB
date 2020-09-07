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
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Database_Project
{
    public partial class Form_register : Form
    {
        public Form_register()
        {
            InitializeComponent();
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            //this.skinEngine1.SkinFile = Application.StartupPath + "Calmness.ssk";
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            string type = "";
            if (this.listBox_type.SelectedItems.Count > 0)
            {
                type = this.listBox_type.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("请选择你要注册的用户类型");
                return;
            }

            int id = 0;
            if (!int.TryParse(textBox_id.Text.Trim(), out id))
            {
                MessageBox.Show("请输入纯数字id，例如电话号码");
                textBox_id.Clear();
                return;
            }

            if (textBox_password.Text.Trim().Length<6)
            {
                MessageBox.Show("密码太短啦，请输入6位以上密码");
                textBox_password.Clear();
                return;
            }

            if (textBox_password.Text.Trim().Length > 20)
            {
                MessageBox.Show("密码太长啦，请输入20位以下密码");
                textBox_password.Clear();
                return;
            }

            if (textBox_username.Text.Trim().Length > 20)
            {
                MessageBox.Show("用户名太长啦，请输入20位以下用户名");
                textBox_username.Clear();
                return;
            }

            if(register(id, textBox_username.Text.Trim(), textBox_password.Text.Trim(), type))
            {
                if (type == "Buyer")
                {
                    //跳转至买家页面
                    this.Hide();
                }
                else if (type == "Seller")
                {
                    //跳转至卖家页面
                    this.Hide();
                }
                else if (type == "administrator")
                {
                    //跳转至管理员界面
                    this.Hide();
                }
            }
            else
            {
                textBox_id.Clear();
                return;
            }
            
        }

        private bool register(int userID, string Pwd, string userName, string userType)
        {

            string connString = "server=localhost;database=db_course_project;uid=root;pwd=041800";
            MySqlConnection con = new MySqlConnection(connString);
            con.Open();

            // SQL
            MySqlCommand com = new MySqlCommand("select ID from user where ID='" + userID + "'", con);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();

            int n = da.Fill(ds, "register");
            if (n != 0)
            {
                MessageBox.Show(" id 已存在！ 请换一个");
                return false;
            }
            else
            {
                // SQL
                com = new MySqlCommand("insert into user values ("
                    + userID + ",'" + userName + "','" + Pwd + "','" + userType + "')", con);
                com.ExecuteNonQuery();
                com = null;

                MessageBox.Show("注册成功！即将自动登录");
                return true;
            }

            con.Close();

            return false;
        }
    }
}
