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
    public partial class Form_SaleMoneyResult : Form
    {
        public Form_SaleMoneyResult()
        {
            InitializeComponent();
        }
        public string year, month, day;
        public GoodsInfoStatis GoodsInfo = new GoodsInfoStatis();

        private void FormSaleMoneyResult_Load(object sender, EventArgs e)
        {
            lbl_date.Text = lbl_date.Text.ToString() + year + "年" + month + "月" + day + "日";
            for (int i = 0; i < GoodsInfo.GoodsStatInfo.Count(); i++)
            {
                ListViewItem mylvi = listView1.Items.Add(i.ToString());
                mylvi.SubItems.Add(GoodsInfo.GoodsStatInfo[i].type.ToString());
                mylvi.SubItems.Add(GoodsInfo.GoodsStatInfo[i].proceeds.ToString());
            }
            //将查询出的销售额通过Listview控件的方法加入到对应的列表框中，需要得到商品的类型和其对应的销售额两个值
        }
    }
}
