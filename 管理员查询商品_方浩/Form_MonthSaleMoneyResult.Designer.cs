namespace WindowsFormsApp1
{
    partial class Form_MonthSaleMoneyResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_date = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_date.Location = new System.Drawing.Point(50, 45);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(184, 30);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "查询日期为:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(175, 129);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(600, 360);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "月份";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "销售额";
            this.columnHeader2.Width = 200;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_type.Location = new System.Drawing.Point(488, 45);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(184, 30);
            this.lbl_type.TabIndex = 9;
            this.lbl_type.Text = "商品种类为:";
            // 
            // Form_MonthSaleMoneyResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 625);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbl_date);
            this.Name = "Form_MonthSaleMoneyResult";
            this.Text = "Form_MonthSaleMoneyResult";
            this.Load += new System.EventHandler(this.Form_MonthSaleMoneyResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lbl_type;
    }
}