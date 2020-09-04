namespace 管理员
{
    partial class 管理员
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
            this.button_我的信息 = new System.Windows.Forms.Button();
            this.button_店铺统计 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_我的信息
            // 
            this.button_我的信息.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_我的信息.Font = new System.Drawing.Font("楷体", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_我的信息.Location = new System.Drawing.Point(150, 300);
            this.button_我的信息.Name = "button_我的信息";
            this.button_我的信息.Size = new System.Drawing.Size(175, 75);
            this.button_我的信息.TabIndex = 0;
            this.button_我的信息.Text = "我的信息";
            this.button_我的信息.UseVisualStyleBackColor = false;
            this.button_我的信息.Click += new System.EventHandler(this.button_我的信息_Click);
            // 
            // button_店铺统计
            // 
            this.button_店铺统计.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_店铺统计.Font = new System.Drawing.Font("楷体", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_店铺统计.Location = new System.Drawing.Point(450, 300);
            this.button_店铺统计.Name = "button_店铺统计";
            this.button_店铺统计.Size = new System.Drawing.Size(175, 75);
            this.button_店铺统计.TabIndex = 1;
            this.button_店铺统计.Text = "店铺统计";
            this.button_店铺统计.UseVisualStyleBackColor = false;
            this.button_店铺统计.Click += new System.EventHandler(this.button_店铺统计_Click);
            // 
            // 管理员
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.button_店铺统计);
            this.Controls.Add(this.button_我的信息);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "管理员";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_我的信息;
        private System.Windows.Forms.Button button_店铺统计;
    }
}

