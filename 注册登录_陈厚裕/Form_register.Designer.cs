namespace Database_Project
{
    partial class Form_register
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
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.listBox_type = new System.Windows.Forms.ListBox();
            this.label_type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_username.Location = new System.Drawing.Point(280, 160);
            this.label_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(189, 46);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_password.Location = new System.Drawing.Point(280, 240);
            this.label_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(185, 46);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "password";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_id.Location = new System.Drawing.Point(100, 80);
            this.label_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(455, 46);
            this.label_id.TabIndex = 2;
            this.label_id.Text = "id ( your phone number )";
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_username.Location = new System.Drawing.Point(560, 160);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(280, 55);
            this.textBox_username.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_password.Location = new System.Drawing.Point(560, 240);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(280, 55);
            this.textBox_password.TabIndex = 4;
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_id.Location = new System.Drawing.Point(560, 80);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(280, 55);
            this.textBox_id.TabIndex = 5;
            // 
            // button_register
            // 
            this.button_register.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_register.Location = new System.Drawing.Point(480, 500);
            this.button_register.Margin = new System.Windows.Forms.Padding(2);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(240, 100);
            this.button_register.TabIndex = 6;
            this.button_register.Text = "register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // listBox_type
            // 
            this.listBox_type.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_type.FormattingEnabled = true;
            this.listBox_type.ItemHeight = 46;
            this.listBox_type.Items.AddRange(new object[] {
            "administrator",
            "Buyer",
            "Seller"});
            this.listBox_type.Location = new System.Drawing.Point(560, 320);
            this.listBox_type.Name = "listBox_type";
            this.listBox_type.Size = new System.Drawing.Size(280, 142);
            this.listBox_type.TabIndex = 7;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_type.Location = new System.Drawing.Point(280, 320);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(184, 46);
            this.label_type.TabIndex = 8;
            this.label_type.Text = "your type";
            // 
            // Form_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 697);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.listBox_type);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form_register";
            this.Text = "Form_register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.ListBox listBox_type;
        private System.Windows.Forms.Label label_type;
    }
}