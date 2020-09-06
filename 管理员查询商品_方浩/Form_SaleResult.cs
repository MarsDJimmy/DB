using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_SaleResult : Form
    {
        public Form_SaleResult()
        {
            InitializeComponent();
        }

        public string year, month, day;
        public GoodsInfoStatis GoodsInfo =new  GoodsInfoStatis();

        private void Form_SaleResult_Load(object sender, EventArgs e)
        {
            lbl_date.Text = lbl_date.Text.ToString() + year + "年" + month + "月" + day + "日";
            for(int i=0;i<GoodsInfo.GoodsStatInfo.Count();i++)
            {
                ListViewItem mylvi = listView1.Items.Add(i.ToString());
                mylvi.SubItems.Add(GoodsInfo.GoodsStatInfo[i].type.ToString());
                mylvi.SubItems.Add(GoodsInfo.GoodsStatInfo[i].quantity.ToString());
            }
            //将查询出的销售量通过listview控件的方法加入到对应的列表框中，需要得到商品的类型和其对应的销售量两个值
        }
    }
}
