namespace 管理员
{
    partial class 我的信息
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
            this.label_ID = new System.Windows.Forms.Label();
            this.label_adm_name = new System.Windows.Forms.Label();
            this.label_ID_data = new System.Windows.Forms.Label();
            this.label_adm_name_data = new System.Windows.Forms.Label();
            this.button_return = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.BackColor = System.Drawing.Color.GreenYellow;
            this.label_ID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ID.Location = new System.Drawing.Point(225, 200);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(250, 50);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "管理员ID：";
            this.label_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_adm_name
            // 
            this.label_adm_name.BackColor = System.Drawing.Color.GreenYellow;
            this.label_adm_name.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_adm_name.Location = new System.Drawing.Point(225, 300);
            this.label_adm_name.Name = "label_adm_name";
            this.label_adm_name.Size = new System.Drawing.Size(250, 50);
            this.label_adm_name.TabIndex = 1;
            this.label_adm_name.Text = "管理员姓名：";
            this.label_adm_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ID_data
            // 
            this.label_ID_data.BackColor = System.Drawing.Color.GreenYellow;
            this.label_ID_data.Font = new System.Drawing.Font("隶书", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ID_data.Location = new System.Drawing.Point(475, 200);
            this.label_ID_data.Name = "label_ID_data";
            this.label_ID_data.Size = new System.Drawing.Size(400, 50);
            this.label_ID_data.TabIndex = 2;
            this.label_ID_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_adm_name_data
            // 
            this.label_adm_name_data.BackColor = System.Drawing.Color.GreenYellow;
            this.label_adm_name_data.Font = new System.Drawing.Font("隶书", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_adm_name_data.Location = new System.Drawing.Point(475, 300);
            this.label_adm_name_data.Name = "label_adm_name_data";
            this.label_adm_name_data.Size = new System.Drawing.Size(400, 50);
            this.label_adm_name_data.TabIndex = 3;
            this.label_adm_name_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_return
            // 
            this.button_return.AutoSize = true;
            this.button_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_return.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_return.ForeColor = System.Drawing.Color.White;
            this.button_return.Location = new System.Drawing.Point(150, 600);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(150, 50);
            this.button_return.TabIndex = 8;
            this.button_return.Text = "返回";
            this.button_return.UseVisualStyleBackColor = false;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
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
            // 我的信息
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.label_adm_name_data);
            this.Controls.Add(this.label_ID_data);
            this.Controls.Add(this.label_adm_name);
            this.Controls.Add(this.label_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "我的信息";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.我的信息_FormClosed);
            this.Load += new System.EventHandler(this.我的信息_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_adm_name;
        private System.Windows.Forms.Label label_ID_data;
        private System.Windows.Forms.Label label_adm_name_data;
        private System.Windows.Forms.Button button_return;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}