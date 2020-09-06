namespace Database_Project
{
    partial class Form_login
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
            this.label_id = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_id.Location = new System.Drawing.Point(160, 140);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(455, 46);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "id ( your phone number )";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_password.Location = new System.Drawing.Point(280, 280);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(185, 46);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "password";
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_id.Location = new System.Drawing.Point(640, 140);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(245, 55);
            this.textBox_id.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_password.Location = new System.Drawing.Point(640, 280);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(245, 55);
            this.textBox_password.TabIndex = 3;
            // 
            // button_register
            // 
            this.button_register.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_register.Location = new System.Drawing.Point(240, 500);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(240, 80);
            this.button_register.TabIndex = 4;
            this.button_register.Text = "register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_login.Location = new System.Drawing.Point(680, 500);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(240, 80);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 697);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_id);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form_login";
            this.Text = "Form_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_login;
    }
}

