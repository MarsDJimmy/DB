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
    public partial class 各种类店铺销量 : Form
    {
        public 各种类店铺销量()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Calmness.ssk";
        }
        //加载“各种类店铺销量”窗体
        private void 各种类店铺销量_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();//隐藏所有者窗体，即“店铺统计”窗体
        }
        //关闭“各种类店铺销量”窗体后
        private void 各种类店铺销量_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();//显示所有者窗体，即“店铺统计”窗体
        }
        //返回所有者窗体，即“店铺统计”窗体
        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }
        //确认所选择的日期类型
        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (comboBox_date.SelectedIndex == 0)//选择了“年-月-日”
            {
                dateTimePicker_date.CustomFormat = "yyyy - MM - dd";//更改日期格式
                dateTimePicker_date.Visible = true;//显示日历
                dateTimePicker_date.Enabled = true;//启用日历
            }
            else if (comboBox_date.SelectedIndex == 1)//选择了“年-月”
            {
                dateTimePicker_date.CustomFormat = "yyyy - MM";//更改日期格式
                dateTimePicker_date.Visible = true;//显示日历
                dateTimePicker_date.Enabled = true;//启用日历
            }
            else if (comboBox_date.SelectedIndex == 2)//选择了“年”
            {
                dateTimePicker_date.CustomFormat = "yyyy";//更改日期格式
                dateTimePicker_date.Visible = true;//显示日历
                dateTimePicker_date.Enabled = true;//启用日历
            }
            else if (comboBox_date.SelectedIndex == 3)//选择了“历史累计”
            {
                dateTimePicker_date.Visible = false;//不显示日历
            }
            else//未进行选择
            {
                MessageBox.Show("请选择日期类型！");
            }
        }
        //进行查询
        private void button_query_Click(object sender, EventArgs e)
        {
            //检查是否选择了正确的查询选项
            if (comboBox_date.SelectedIndex == -1)//未选择日期类型
            {
                MessageBox.Show("请选择日期类型！");
                return;
            }
            if (dateTimePicker_date.Enabled == false && comboBox_date.SelectedIndex != 3)//未选择日期
            {
                MessageBox.Show("请选择日期！");
                return;
            }
            //查询各种类店铺销量
            int year = -1;//年，初始为空
            int month = -1;//月，初始为空
            int day = -1;//日，初始为空
            if (comboBox_date.SelectedIndex == 0 || comboBox_date.SelectedIndex == 1 || comboBox_date.SelectedIndex == 2)//选择了“年”
            {
                year = dateTimePicker_date.Value.Year;//获取所选年份
            }
            if (comboBox_date.SelectedIndex == 0 || comboBox_date.SelectedIndex == 1)//选择了“月”
            {
                month = dateTimePicker_date.Value.Month;//获取所选月份
            }
            if (comboBox_date.SelectedIndex == 0)//选择了“日”
            {
                day = dateTimePicker_date.Value.Day;//获取所选天数
            }
            //调用StoreInfoStatis进行查询
            StoreInfoStatis query = new StoreInfoStatis();
            query.StoreSpecifyDate(year, month, day, 1);
            查询结果 查询结果 = new 查询结果();//创建“查询结果”窗体实例
            查询结果.info_各种类店铺销售额或销量 info = new 查询结果.info_各种类店铺销售额或销量();
            int num = 0;
            num = query.StoreStatInfo.Count();//获取查询结果有多少项
            for (int i = 0; i < num; i++)//复制查询结果
            {
                info.type = query.StoreStatInfo[i].type;//店铺类型
                info.quantity = query.StoreStatInfo[i].quantity;//销量
                info.proceeds = query.StoreStatInfo[i].proceeds;//销售额
                查询结果.result_各种类店铺销售额或销量.Add(info);
            }
            查询结果.type = "各种类店铺销量";
            查询结果.Show(this);//打开“查询结果”窗体
        }
    }
}
