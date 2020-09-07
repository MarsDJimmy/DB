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

namespace Database_Project
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            //this.skinEngine1.SkinFile = Application.StartupPath + "Calmness.ssk";
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_register form_reg = new Form_register();
            form_reg.Show();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (!int.TryParse(textBox_id.Text.Trim(), out id))
            {
                MessageBox.Show("请输入纯数字id，可能是你的电话号码");
                textBox_id.Clear();
                return;
            }

            string type = login(id, textBox_password.Text.Trim());

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
            else
            {
                textBox_password.Clear();
                return;
            }
        }

        private string login(int userID, string pwd)
        {
            string connString = "server=localhost;database=db_course_project;uid=root;pwd=041800";
            MySqlConnection con = new MySqlConnection(connString);
            con.Open();

            //SQL
            using (MySqlCommand cmd = new MySqlCommand("select ID, password, type from user", con))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    string p = reader.GetString("password");
                    string type = reader.GetString("type");
                    if (id==userID && p == pwd)
                    {
                        MessageBox.Show("登录成功！即将跳转至"+type+"界面");
                        return type;
                    }
                }

                MessageBox.Show("登录失败！id 或者密码不正确");
            }

            con.Close();
            return "false";
        }
    }
}
