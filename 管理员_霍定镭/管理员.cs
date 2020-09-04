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
    public partial class 管理员 : Form
    {
        public 管理员()
        {
            InitializeComponent();
        }
        //进入我的信息
        private void button_我的信息_Click(object sender, EventArgs e)
        {
            我的信息 我的信息 = new 我的信息();//创建“我的信息”窗体实例
            我的信息.Show(this);//打开“我的信息”窗体
        }
        //进入店铺统计
        private void button_店铺统计_Click(object sender, EventArgs e)
        {         
            店铺统计 店铺统计 = new 店铺统计();//创建“店铺统计”窗体实例
            店铺统计.Show(this);//打开“店铺统计”窗体
        }
    }
}
