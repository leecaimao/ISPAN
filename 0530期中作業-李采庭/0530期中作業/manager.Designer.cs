
namespace _0530期中作業
{
    partial class manager
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn會員資料管理 = new System.Windows.Forms.Button();
            this.btn員工資料管理 = new System.Windows.Forms.Button();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "管理者介面";
            // 
            // btn會員資料管理
            // 
            this.btn會員資料管理.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員資料管理.Location = new System.Drawing.Point(84, 162);
            this.btn會員資料管理.Name = "btn會員資料管理";
            this.btn會員資料管理.Size = new System.Drawing.Size(214, 80);
            this.btn會員資料管理.TabIndex = 1;
            this.btn會員資料管理.Text = "會員資料管理";
            this.btn會員資料管理.UseVisualStyleBackColor = true;
            this.btn會員資料管理.Click += new System.EventHandler(this.btn會員資料管理_Click);
            // 
            // btn員工資料管理
            // 
            this.btn員工資料管理.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn員工資料管理.Location = new System.Drawing.Point(84, 269);
            this.btn員工資料管理.Name = "btn員工資料管理";
            this.btn員工資料管理.Size = new System.Drawing.Size(214, 80);
            this.btn員工資料管理.TabIndex = 2;
            this.btn員工資料管理.Text = "員工資料管理";
            this.btn員工資料管理.UseVisualStyleBackColor = true;
            this.btn員工資料管理.Click += new System.EventHandler(this.btn員工資料管理_Click);
            // 
            // lblLoginName
            // 
            this.lblLoginName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoginName.Location = new System.Drawing.Point(12, 25);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(286, 24);
            this.lblLoginName.TabIndex = 3;
            this.lblLoginName.Text = "使用者名稱";
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(403, 502);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.btn員工資料管理);
            this.Controls.Add(this.btn會員資料管理);
            this.Controls.Add(this.label1);
            this.Name = "manager";
            this.Text = "管理者介面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.manager_FormClosing);
            this.Load += new System.EventHandler(this.manager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn會員資料管理;
        private System.Windows.Forms.Button btn員工資料管理;
        private System.Windows.Forms.Label lblLoginName;
    }
}