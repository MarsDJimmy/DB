using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 管理员
{
    public partial class 查询结果 : Form
    {
        public 查询结果()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Calmness.ssk";
        }

        public string type;//是店铺统计中的哪个类型

        //查询“各种类店铺销售额”或“各种类店铺销量”
        public struct info_各种类店铺销售额或销量
        {
            public string type;//店铺类型
            public int quantity;//销量
            public int proceeds;//销售额
        };
        public List<info_各种类店铺销售额或销量> result_各种类店铺销售额或销量 = new List<info_各种类店铺销售额或销量>();
        //查询“店铺销售额”或“店铺销量”
        public struct info_店铺销售额或销量
        {
            public string name;//店铺名称
            public int quantity;//销量
            public int proceeds;//销售额
            public string type;//店铺类型
        };
        public List<info_店铺销售额或销量> result_店铺销售额或销量 = new List<info_店铺销售额或销量>();
        //查询“店铺评价”
        public struct info_店铺评价
        {
            public int id;//店铺ID
            public string name;//店铺名称
            public double assessment;//店铺评价
            public string type;//店铺类型
        };
        public List<info_店铺评价> result_店铺评价 = new List<info_店铺评价>();
        
        //加载“查询结果”窗体
        private void 查询结果_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();//隐藏所有者窗体
            //确定查询对象，更改窗体显示信息
            if (type == "各种类店铺销售额")//查询各种类店铺销售额
            {
                this.Text = "各种类店铺销售额";//更改窗体名称
                //更改表格列项
                result.Columns.Add(" ",100);
                result.Columns.Add("店铺类型", 100);
                result.Columns.Add("销量", 100);
                result.Columns.Add("销售额", 100);
                //更改表格行项
                int num = result_各种类店铺销售额或销量.Count;//获取查询结果有多少项
                for (int i = 0; i < num; i++)
                {
                    result.Items.Add((i + 1).ToString());//序号
                    result.Items[i].SubItems.Add(result_各种类店铺销售额或销量[i].type);//店铺类型
                    result.Items[i].SubItems.Add(result_各种类店铺销售额或销量[i].quantity.ToString());//销量
                    result.Items[i].SubItems.Add(result_各种类店铺销售额或销量[i].proceeds.ToString());//销售额
                }
            }
            if (type == "各种类店铺销量")//查询各种类店铺销量
            {
                this.Text = "各种类店铺销量";//更改窗体名称
                //更改表格列项
                result.Columns.Add(" ", 100);
                result.Columns.Add("店铺类型", 100);
                result.Columns.Add("销量", 100);
                result.Columns.Add("销售额", 100);
                //更改表格行项
                int num = result_各种类店铺销售额或销量.Count;//获取查询结果有多少项
                for (int i = 0; i < num; i++)
                {
                    result.Items.Add((i + 1).ToString());//序号
                    result.Items[i].SubItems.Add(result_各种类店铺销售额或销量[i].type);//店铺类型
                    result.Items[i].SubItems.Add(result_各种类店铺销售额或销量[i].quantity.ToString());//销量
                    result.Items[i].SubItems.Add(result_各种类店铺销售额或销量[i].proceeds.ToString());//销售额
                }
            }
            if (type == "店铺销售额")//查询店铺销售额
            {
                this.Text = "各种类店铺销售额";//更改窗体名称
                //更改表格列项
                result.Columns.Add(" ", 100);
                result.Columns.Add("店铺名称", 100);
                result.Columns.Add("销量", 100);
                result.Columns.Add("销售额", 100);
                result.Columns.Add("店铺类型", 100);
                //更改表格行项
                int num = result_店铺销售额或销量.Count;//获取查询结果有多少项
                for (int i = 0; i < num; i++)
                {
                    result.Items.Add((i + 1).ToString());//序号
                    result.Items[i].SubItems.Add(result_店铺销售额或销量[i].name);//店铺名称
                    result.Items[i].SubItems.Add(result_店铺销售额或销量[i].quantity.ToString());//销量
                    result.Items[i].SubItems.Add(result_店铺销售额或销量[i].proceeds.ToString());//销售额
                    result.Items[i].SubItems.Add(result_店铺销售额或销量[i].type);//店铺类型
                }
            }
            if (type == "店铺销量")//查询店铺销量
            {
                this.Text = "店铺销量";//更改窗体名称
                //更改表格列项
                result.Columns.Add(" ", 100);
                result.Columns.Add("店铺名称", 100);
                result.Columns.Add("销量", 100);
                result.Columns.Add("销售额", 100);
                result.Columns.Add("店铺类型", 100);
                //更改表格行项
                int num = result_店铺销售额或销量.Count;//获取查询结果有多少项
                for (int i = 0; i < num; i++)
                {
                    result.Items.Add((i + 1).ToString());//序号
                    result.Items[i].SubItems.Add(result_店铺销售额或销量[i].name);//店铺名称
                    result.Items[i].SubItems.Add(result_店铺销售额或销量[i].quantity.ToString());//销量
                    result.Items[i].SubItems.Add(result_店铺销售额或销量[i].proceeds.ToString());//销售额
                    result.Items[i].SubItems.Add(result_店铺销售额或销量[i].type);//店铺类型
                }
            }
            if (type == "店铺评价")//查询店铺销量
            {
                this.Text = "店铺评价";//更改窗体名称
                //更改表格列项
                result.Columns.Add(" ", 100);
                result.Columns.Add("店铺ID", 100);
                result.Columns.Add("店铺名称", 100);
                result.Columns.Add("店铺评价", 100);
                result.Columns.Add("店铺类型", 100);
                //更改表格行项
                int num = result_店铺评价.Count;//获取查询结果有多少项
                for (int i = 0; i < num; i++)
                {
                    result.Items.Add((i + 1).ToString());//序号
                    result.Items[i].SubItems.Add(result_店铺评价[i].id.ToString());//店铺ID
                    result.Items[i].SubItems.Add(result_店铺评价[i].name);//店铺名称
                    result.Items[i].SubItems.Add(result_店铺评价[i].assessment.ToString());//店铺评价
                    result.Items[i].SubItems.Add(result_店铺评价[i].type);//店铺类型
                }
            }
        }
        //关闭“查询结果”窗体后
        private void 查询结果_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();//显示所有者窗体
        }
        //返回所有者窗体
        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }
    }
}
