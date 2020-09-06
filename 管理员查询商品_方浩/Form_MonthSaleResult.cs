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
    public partial class Form_MonthSaleResult : Form
    {
        public Form_MonthSaleResult()
        {
            InitializeComponent();
        }

        public string year,GoodsType;
        public GoodsInfoStatis GoodsInfo = new GoodsInfoStatis();

        private void Form_MonthSaleResult_Load(object sender, EventArgs e)
        {
            lbl_date.Text = lbl_date.Text.ToString() + year + "年";
            lbl_type.Text = lbl_type.Text.ToString() + GoodsType;
            for (int i = 1; i < 13; i++)
            {
                ListViewItem mylvi = listView1.Items.Add(i.ToString());
                mylvi.SubItems.Add(GoodsInfo.goods_month_sales[i].ToString());
            }
            //添加项
        }
    }
}
