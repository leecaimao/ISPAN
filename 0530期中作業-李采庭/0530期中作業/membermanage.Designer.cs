
namespace _0530期中作業
{
    partial class membermanage
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
            this.btn新增會員 = new System.Windows.Forms.Button();
            this.btn修改資料 = new System.Windows.Forms.Button();
            this.btn刪除會員 = new System.Windows.Forms.Button();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.lbl密碼 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txt地址 = new System.Windows.Forms.TextBox();
            this.txt手機號碼 = new System.Windows.Forms.TextBox();
            this.dtp生日 = new System.Windows.Forms.DateTimePicker();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn資料搜尋 = new System.Windows.Forms.Button();
            this.btn回首頁 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(456, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "會員資料管理";
            // 
            // btn新增會員
            // 
            this.btn新增會員.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增會員.Location = new System.Drawing.Point(12, 131);
            this.btn新增會員.Name = "btn新增會員";
            this.btn新增會員.Size = new System.Drawing.Size(109, 45);
            this.btn新增會員.TabIndex = 1;
            this.btn新增會員.Text = "新增會員";
            this.btn新增會員.UseVisualStyleBackColor = true;
            this.btn新增會員.Click += new System.EventHandler(this.btn新增會員_Click);
            // 
            // btn修改資料
            // 
            this.btn修改資料.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改資料.Location = new System.Drawing.Point(12, 313);
            this.btn修改資料.Name = "btn修改資料";
            this.btn修改資料.Size = new System.Drawing.Size(109, 45);
            this.btn修改資料.TabIndex = 2;
            this.btn修改資料.Text = "修改資料";
            this.btn修改資料.UseVisualStyleBackColor = true;
            this.btn修改資料.Click += new System.EventHandler(this.btn修改資料_Click);
            // 
            // btn刪除會員
            // 
            this.btn刪除會員.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除會員.Location = new System.Drawing.Point(12, 220);
            this.btn刪除會員.Name = "btn刪除會員";
            this.btn刪除會員.Size = new System.Drawing.Size(109, 45);
            this.btn刪除會員.TabIndex = 3;
            this.btn刪除會員.Text = "刪除會員";
            this.btn刪除會員.UseVisualStyleBackColor = true;
            this.btn刪除會員.Click += new System.EventHandler(this.btn刪除會員_Click);
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空欄位.Location = new System.Drawing.Point(12, 406);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(109, 45);
            this.btn清空欄位.TabIndex = 4;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = true;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.txt密碼);
            this.groupBox1.Controls.Add(this.lbl密碼);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txt地址);
            this.groupBox1.Controls.Add(this.txt手機號碼);
            this.groupBox1.Controls.Add(this.dtp生日);
            this.groupBox1.Controls.Add(this.txt姓名);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(127, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 538);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txt密碼
            // 
            this.txt密碼.Location = new System.Drawing.Point(100, 479);
            this.txt密碼.Multiline = true;
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.Size = new System.Drawing.Size(191, 41);
            this.txt密碼.TabIndex = 12;
            // 
            // lbl密碼
            // 
            this.lbl密碼.AutoSize = true;
            this.lbl密碼.Location = new System.Drawing.Point(6, 496);
            this.lbl密碼.Name = "lbl密碼";
            this.lbl密碼.Size = new System.Drawing.Size(48, 24);
            this.lbl密碼.TabIndex = 11;
            this.lbl密碼.Text = "密碼";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 410);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(453, 41);
            this.txtEmail.TabIndex = 10;
            // 
            // txt地址
            // 
            this.txt地址.Location = new System.Drawing.Point(100, 322);
            this.txt地址.Multiline = true;
            this.txt地址.Name = "txt地址";
            this.txt地址.Size = new System.Drawing.Size(453, 41);
            this.txt地址.TabIndex = 9;
            // 
            // txt手機號碼
            // 
            this.txt手機號碼.Location = new System.Drawing.Point(100, 192);
            this.txt手機號碼.Multiline = true;
            this.txt手機號碼.Name = "txt手機號碼";
            this.txt手機號碼.Size = new System.Drawing.Size(191, 41);
            this.txt手機號碼.TabIndex = 8;
            // 
            // dtp生日
            // 
            this.dtp生日.Location = new System.Drawing.Point(100, 260);
            this.dtp生日.Name = "dtp生日";
            this.dtp生日.Size = new System.Drawing.Size(191, 33);
            this.dtp生日.TabIndex = 7;
            // 
            // txt姓名
            // 
            this.txt姓名.Location = new System.Drawing.Point(100, 125);
            this.txt姓名.Multiline = true;
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(191, 41);
            this.txt姓名.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "生日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "手機號碼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "姓名";
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.RosyBrown;
            this.lblID.Location = new System.Drawing.Point(6, 62);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(285, 24);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(718, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 538);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "會員資料列表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.Location = new System.Drawing.Point(15, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(400, 486);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn資料搜尋
            // 
            this.btn資料搜尋.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料搜尋.Location = new System.Drawing.Point(12, 500);
            this.btn資料搜尋.Name = "btn資料搜尋";
            this.btn資料搜尋.Size = new System.Drawing.Size(109, 45);
            this.btn資料搜尋.TabIndex = 7;
            this.btn資料搜尋.Text = "資料搜尋";
            this.btn資料搜尋.UseVisualStyleBackColor = true;
            this.btn資料搜尋.Click += new System.EventHandler(this.btn資料搜尋_Click);
            // 
            // btn回首頁
            // 
            this.btn回首頁.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn回首頁.Location = new System.Drawing.Point(13, 13);
            this.btn回首頁.Name = "btn回首頁";
            this.btn回首頁.Size = new System.Drawing.Size(93, 35);
            this.btn回首頁.TabIndex = 8;
            this.btn回首頁.Text = "回首頁";
            this.btn回首頁.UseVisualStyleBackColor = true;
            this.btn回首頁.Click += new System.EventHandler(this.btn回首頁_Click);
            // 
            // membermanage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1179, 647);
            this.Controls.Add(this.btn回首頁);
            this.Controls.Add(this.btn資料搜尋);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn清空欄位);
            this.Controls.Add(this.btn刪除會員);
            this.Controls.Add(this.btn修改資料);
            this.Controls.Add(this.btn新增會員);
            this.Controls.Add(this.label1);
            this.Name = "membermanage";
            this.Text = "會員資料管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.membermanage_FormClosing);
            this.Load += new System.EventHandler(this.membermanage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn新增會員;
        private System.Windows.Forms.Button btn修改資料;
        private System.Windows.Forms.Button btn刪除會員;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp生日;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt地址;
        private System.Windows.Forms.TextBox txt手機號碼;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn資料搜尋;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Label lbl密碼;
        private System.Windows.Forms.Button btn回首頁;
    }
}