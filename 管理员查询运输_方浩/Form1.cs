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
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Calmness.ssk";
            InitializeComponent();
        }

        private void btn_avgmoney_Click(object sender, EventArgs e)
        {
            int year = int.Parse(dtp_avgmoney.Value.Year.ToString());
            int month = int.Parse(dtp_avgmoney.Value.Month.ToString());
            int day = int.Parse(dtp_avgmoney.Value.Day.ToString());
            TransInfoStatis TransInfo = new TransInfoStatis();
            TransInfo.TransfareSpecifyDate(year, month, day);
            MessageBox.Show("所有商品的平均运费为:" + TransInfo.avg_trandfare.ToString()+"元");
        }

        private void btn_transmoney_Click(object sender, EventArgs e)
        {
            int year = int.Parse(dtp_transmoney.Value.Year.ToString());
            int month = int.Parse(dtp_transmoney.Value.Month.ToString());
            int day = int.Parse(dtp_transmoney.Value.Day.ToString());
            TransInfoStatis TransInfo = new TransInfoStatis();
            TransInfo.TransfareRank(year, month, day);
            Form_TransMoneyResult FormResult = new Form_TransMoneyResult();
            //if (查询数据库比较存在该日期)
            //    则执行以下部分在结果框显示结果
            //    把查询主窗体的日期信息传给查询的显示结果窗体
            FormResult.year = dtp_transmoney.Value.Year.ToString();
            FormResult.month = dtp_transmoney.Value.Month.ToString();
            FormResult.day = dtp_transmoney.Value.Day.ToString();
            FormResult.TransInfo.transInfoList = TransInfo.transInfoList;
            FormResult.ShowDialog(this);//用formmain唤醒formresult
            //else //否则就在提示显示查询日期不存在
            //MessageBox.Show("The date you type in isn't existed!");
        }
    }
}
