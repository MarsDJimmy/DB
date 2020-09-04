namespace 管理员
{
    partial class 各种类店铺销售额
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
            this.button_return = new System.Windows.Forms.Button();
            this.button_query = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.comboBox_date = new System.Windows.Forms.ComboBox();
            this.label_date = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.SuspendLayout();
            // 
            // button_return
            // 
            this.button_return.AutoSize = true;
            this.button_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_return.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_return.ForeColor = System.Drawing.Color.White;
            this.button_return.Location = new System.Drawing.Point(150, 500);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(150, 50);
            this.button_return.TabIndex = 8;
            this.button_return.Text = "返回";
            this.button_return.UseVisualStyleBackColor = false;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // button_query
            // 
            this.button_query.AutoSize = true;
            this.button_query.BackColor = System.Drawing.Color.Coral;
            this.button_query.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_query.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_query.ForeColor = System.Drawing.Color.White;
            this.button_query.Location = new System.Drawing.Point(500, 500);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(150, 50);
            this.button_query.TabIndex = 21;
            this.button_query.Text = "查询";
            this.button_query.UseVisualStyleBackColor = false;
            this.button_query.Click += new System.EventHandler(this.button_query_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.AutoSize = true;
            this.button_confirm.BackColor = System.Drawing.Color.Coral;
            this.button_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_confirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_confirm.ForeColor = System.Drawing.Color.White;
            this.button_confirm.Location = new System.Drawing.Point(500, 150);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(150, 50);
            this.button_confirm.TabIndex = 25;
            this.button_confirm.Text = "确认";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // comboBox_date
            // 
            this.comboBox_date.BackColor = System.Drawing.Color.Ivory;
            this.comboBox_date.DropDownHeight = 100;
            this.comboBox_date.DropDownWidth = 150;
            this.comboBox_date.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_date.FormattingEnabled = true;
            this.comboBox_date.IntegralHeight = false;
            this.comboBox_date.ItemHeight = 18;
            this.comboBox_date.Items.AddRange(new object[] {
            "年-月-日",
            "年-月",
            "年",
            "历史累计"});
            this.comboBox_date.Location = new System.Drawing.Point(150, 150);
            this.comboBox_date.Name = "comboBox_date";
            this.comboBox_date.Size = new System.Drawing.Size(250, 26);
            this.comboBox_date.TabIndex = 24;
            this.comboBox_date.Text = "请选择日期类型";
            // 
            // label_date
            // 
            this.label_date.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label_date.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_date.Location = new System.Drawing.Point(150, 50);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(500, 50);
            this.label_date.TabIndex = 23;
            this.label_date.Text = "按日期（年月日，可为空）查询";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.CalendarFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker_date.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker_date.CustomFormat = "";
            this.dateTimePicker_date.Enabled = false;
            this.dateTimePicker_date.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_date.Location = new System.Drawing.Point(150, 250);
            this.dateTimePicker_date.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_date.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.ShowUpDown = true;
            this.dateTimePicker_date.Size = new System.Drawing.Size(300, 28);
            this.dateTimePicker_date.TabIndex = 22;
            this.dateTimePicker_date.Value = new System.DateTime(2020, 8, 6, 0, 0, 0, 0);
            this.dateTimePicker_date.Visible = false;
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
            // 各种类店铺销售额
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 644);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.comboBox_date);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.button_query);
            this.Controls.Add(this.button_return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "各种类店铺销售额";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "各种类店铺销售额";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.各种类店铺销售额_FormClosed);
            this.Load += new System.EventHandler(this.各种类店铺销售额_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_query;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.ComboBox comboBox_date;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}