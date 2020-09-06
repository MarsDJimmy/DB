namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_transport = new System.Windows.Forms.Label();
            this.lbl_date1 = new System.Windows.Forms.Label();
            this.lbl_avgmoney = new System.Windows.Forms.Label();
            this.dtp_avgmoney = new System.Windows.Forms.DateTimePicker();
            this.btn_avgmoney = new System.Windows.Forms.Button();
            this.lbl_transmoney = new System.Windows.Forms.Label();
            this.dtp_transmoney = new System.Windows.Forms.DateTimePicker();
            this.btn_transmoney = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.SuspendLayout();
            // 
            // lbl_transport
            // 
            this.lbl_transport.AutoSize = true;
            this.lbl_transport.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_transport.Location = new System.Drawing.Point(51, 36);
            this.lbl_transport.Name = "lbl_transport";
            this.lbl_transport.Size = new System.Drawing.Size(261, 30);
            this.lbl_transport.TabIndex = 1;
            this.lbl_transport.Text = "查询运输统计信息";
            // 
            // lbl_date1
            // 
            this.lbl_date1.AutoSize = true;
            this.lbl_date1.Location = new System.Drawing.Point(305, 145);
            this.lbl_date1.Name = "lbl_date1";
            this.lbl_date1.Size = new System.Drawing.Size(134, 18);
            this.lbl_date1.TabIndex = 8;
            this.lbl_date1.Text = "日期(年/月/日)";
            // 
            // lbl_avgmoney
            // 
            this.lbl_avgmoney.AutoSize = true;
            this.lbl_avgmoney.Location = new System.Drawing.Point(53, 191);
            this.lbl_avgmoney.Name = "lbl_avgmoney";
            this.lbl_avgmoney.Size = new System.Drawing.Size(215, 18);
            this.lbl_avgmoney.TabIndex = 9;
            this.lbl_avgmoney.Text = "各种类商品平均运费查询:";
            // 
            // dtp_avgmoney
            // 
            this.dtp_avgmoney.CustomFormat = "";
            this.dtp_avgmoney.Location = new System.Drawing.Point(308, 185);
            this.dtp_avgmoney.Name = "dtp_avgmoney";
            this.dtp_avgmoney.ShowUpDown = true;
            this.dtp_avgmoney.Size = new System.Drawing.Size(200, 28);
            this.dtp_avgmoney.TabIndex = 10;
            this.dtp_avgmoney.Value = new System.DateTime(2020, 8, 23, 0, 0, 0, 0);
            // 
            // btn_avgmoney
            // 
            this.btn_avgmoney.Location = new System.Drawing.Point(578, 184);
            this.btn_avgmoney.Name = "btn_avgmoney";
            this.btn_avgmoney.Size = new System.Drawing.Size(75, 32);
            this.btn_avgmoney.TabIndex = 11;
            this.btn_avgmoney.Text = "查询";
            this.btn_avgmoney.UseVisualStyleBackColor = true;
            this.btn_avgmoney.Click += new System.EventHandler(this.btn_avgmoney_Click);
            // 
            // lbl_transmoney
            // 
            this.lbl_transmoney.AutoSize = true;
            this.lbl_transmoney.Location = new System.Drawing.Point(53, 253);
            this.lbl_transmoney.Name = "lbl_transmoney";
            this.lbl_transmoney.Size = new System.Drawing.Size(179, 18);
            this.lbl_transmoney.TabIndex = 12;
            this.lbl_transmoney.Text = "运费查询并降序显示:";
            // 
            // dtp_transmoney
            // 
            this.dtp_transmoney.Location = new System.Drawing.Point(308, 247);
            this.dtp_transmoney.Name = "dtp_transmoney";
            this.dtp_transmoney.ShowUpDown = true;
            this.dtp_transmoney.Size = new System.Drawing.Size(200, 28);
            this.dtp_transmoney.TabIndex = 13;
            this.dtp_transmoney.Value = new System.DateTime(2020, 8, 23, 0, 0, 0, 0);
            // 
            // btn_transmoney
            // 
            this.btn_transmoney.Location = new System.Drawing.Point(578, 247);
            this.btn_transmoney.Name = "btn_transmoney";
            this.btn_transmoney.Size = new System.Drawing.Size(75, 32);
            this.btn_transmoney.TabIndex = 14;
            this.btn_transmoney.Text = "查询";
            this.btn_transmoney.UseVisualStyleBackColor = true;
            this.btn_transmoney.Click += new System.EventHandler(this.btn_transmoney_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 610);
            this.Controls.Add(this.btn_transmoney);
            this.Controls.Add(this.dtp_transmoney);
            this.Controls.Add(this.lbl_transmoney);
            this.Controls.Add(this.btn_avgmoney);
            this.Controls.Add(this.dtp_avgmoney);
            this.Controls.Add(this.lbl_avgmoney);
            this.Controls.Add(this.lbl_date1);
            this.Controls.Add(this.lbl_transport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_transport;
        private System.Windows.Forms.Label lbl_date1;
        private System.Windows.Forms.Label lbl_avgmoney;
        private System.Windows.Forms.DateTimePicker dtp_avgmoney;
        private System.Windows.Forms.Button btn_avgmoney;
        private System.Windows.Forms.Label lbl_transmoney;
        private System.Windows.Forms.DateTimePicker dtp_transmoney;
        private System.Windows.Forms.Button btn_transmoney;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

