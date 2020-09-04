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
    public partial class 店铺统计 : Form
    {
        public 店铺统计()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Calmness.ssk";
        }
        //加载“店铺统计”窗体
        private void 店铺统计_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();//隐藏所有者窗体，即“管理员”窗体
        }
        //关闭“店铺统计”窗体后
        private void 店铺统计_FormClosed(object sender, FormClosedEventArgs e)
        {    
            this.Owner.Show();//显示所有者窗体，即“管理员”窗体
        }
        //返回所有者窗体，即“管理员”窗体
        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }
        //进入各种类店铺销量查询
        private void button_各种类店铺销量_Click(object sender, EventArgs e)
        {
            各种类店铺销量 各种类店铺销量 = new 各种类店铺销量();//创建“各种类店铺销量”窗体实例
            各种类店铺销量.Show(this);//打开“各种类店铺销量”窗体
        }
        //进入各种类店铺销售额查询
        private void button_各种类店铺销售额_Click(object sender, EventArgs e)
        {
            各种类店铺销售额 各种类店铺销售额 = new 各种类店铺销售额();//创建“各种类店铺销售额”窗体实例
            各种类店铺销售额.Show(this);//打开“各种类店铺销售额”窗体
        }
        //进入店铺销量查询
        private void button_店铺销量_Click(object sender, EventArgs e)
        {
            店铺销量 店铺销量 = new 店铺销量();//创建“店铺销量”窗体实例
            店铺销量.Show(this);//打开“店铺销量”窗体
        }
        //进入店铺销售额查询
        private void button_店铺销售额_Click(object sender, EventArgs e)
        {
            店铺销售额 店铺销售额 = new 店铺销售额();//创建“店铺销售额”窗体实例
            店铺销售额.Show(this);//打开“店铺销售额”窗体
        }
        //进入店铺评价查询
        private void button_店铺评价_Click(object sender, EventArgs e)
        {
            店铺评价 店铺评价 = new 店铺评价();//创建“店铺评价”窗体实例
            店铺评价.Show(this);//打开“店铺评价”窗体
        }
    }
}
