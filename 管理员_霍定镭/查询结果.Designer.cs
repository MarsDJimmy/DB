namespace 管理员
{
    partial class 查询结果
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
            this.result = new System.Windows.Forms.ListView();
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
            this.button_return.Location = new System.Drawing.Point(50, 50);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(150, 50);
            this.button_return.TabIndex = 9;
            this.button_return.Text = "返回";
            this.button_return.UseVisualStyleBackColor = false;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // result
            // 
            this.result.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.result.AutoArrange = false;
            this.result.BackColor = System.Drawing.Color.Ivory;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result.FullRowSelect = true;
            this.result.GridLines = true;
            this.result.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.result.HideSelection = false;
            this.result.Location = new System.Drawing.Point(300, 50);
            this.result.Margin = new System.Windows.Forms.Padding(0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(800, 500);
            this.result.TabIndex = 10;
            this.result.UseCompatibleStateImageBehavior = false;
            this.result.View = System.Windows.Forms.View.Details;
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
            // 查询结果
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 644);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button_return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "查询结果";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询结果";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.查询结果_FormClosed);
            this.Load += new System.EventHandler(this.查询结果_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.ListView result;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}