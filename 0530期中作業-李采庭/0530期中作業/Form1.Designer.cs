
namespace _0530期中作業
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn會員登入訂購 = new System.Windows.Forms.Button();
            this.btn菜單 = new System.Windows.Forms.Button();
            this.btn管理者登入 = new System.Windows.Forms.Button();
            this.lbl管理者登入 = new System.Windows.Forms.Label();
            this.lbl菜單 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(324, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "鹽水雞";
            // 
            // btn會員登入訂購
            // 
            this.btn會員登入訂購.Image = global::_0530期中作業.Properties.Resources._1234567;
            this.btn會員登入訂購.Location = new System.Drawing.Point(535, 234);
            this.btn會員登入訂購.Name = "btn會員登入訂購";
            this.btn會員登入訂購.Size = new System.Drawing.Size(255, 175);
            this.btn會員登入訂購.TabIndex = 6;
            this.btn會員登入訂購.UseVisualStyleBackColor = true;
            this.btn會員登入訂購.Click += new System.EventHandler(this.btn會員登入訂購_Click);
            // 
            // btn菜單
            // 
            this.btn菜單.Image = global::_0530期中作業.Properties.Resources._12345;
            this.btn菜單.Location = new System.Drawing.Point(274, 234);
            this.btn菜單.Name = "btn菜單";
            this.btn菜單.Size = new System.Drawing.Size(255, 175);
            this.btn菜單.TabIndex = 5;
            this.btn菜單.UseVisualStyleBackColor = true;
            this.btn菜單.Click += new System.EventHandler(this.btn菜單_Click);
            // 
            // btn管理者登入
            // 
            this.btn管理者登入.Image = global::_0530期中作業.Properties.Resources.d6102480;
            this.btn管理者登入.Location = new System.Drawing.Point(12, 234);
            this.btn管理者登入.Name = "btn管理者登入";
            this.btn管理者登入.Size = new System.Drawing.Size(255, 175);
            this.btn管理者登入.TabIndex = 4;
            this.btn管理者登入.UseVisualStyleBackColor = true;
            this.btn管理者登入.Click += new System.EventHandler(this.btn管理者登入_Click);
            // 
            // lbl管理者登入
            // 
            this.lbl管理者登入.AutoSize = true;
            this.lbl管理者登入.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl管理者登入.Location = new System.Drawing.Point(99, 412);
            this.lbl管理者登入.Name = "lbl管理者登入";
            this.lbl管理者登入.Size = new System.Drawing.Size(105, 24);
            this.lbl管理者登入.TabIndex = 7;
            this.lbl管理者登入.Text = "管理者登入";
            this.lbl管理者登入.Click += new System.EventHandler(this.btn管理者登入_Click);
            // 
            // lbl菜單
            // 
            this.lbl菜單.AutoSize = true;
            this.lbl菜單.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl菜單.Location = new System.Drawing.Point(372, 412);
            this.lbl菜單.Name = "lbl菜單";
            this.lbl菜單.Size = new System.Drawing.Size(48, 24);
            this.lbl菜單.TabIndex = 8;
            this.lbl菜單.Text = "菜單";
            this.lbl菜單.Click += new System.EventHandler(this.btn菜單_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(598, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "會員登入訂購";
            this.label2.Click += new System.EventHandler(this.btn會員登入訂購_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl菜單);
            this.Controls.Add(this.lbl管理者登入);
            this.Controls.Add(this.btn會員登入訂購);
            this.Controls.Add(this.btn菜單);
            this.Controls.Add(this.btn管理者登入);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "鹽水雞";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn管理者登入;
        private System.Windows.Forms.Button btn菜單;
        private System.Windows.Forms.Button btn會員登入訂購;
        private System.Windows.Forms.Label lbl管理者登入;
        private System.Windows.Forms.Label lbl菜單;
        private System.Windows.Forms.Label label2;
    }
}

