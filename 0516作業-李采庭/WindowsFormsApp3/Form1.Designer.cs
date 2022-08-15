
namespace WindowsFormsApp3
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
            this.lbl冷飲店訂購單 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.lbl品項總價 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt訂購人電話 = new System.Windows.Forms.TextBox();
            this.txt杯數 = new System.Windows.Forms.TextBox();
            this.btn加入訂購單 = new System.Windows.Forms.Button();
            this.btn查看訂購單 = new System.Windows.Forms.Button();
            this.lBox冷飲品項 = new System.Windows.Forms.ListBox();
            this.cBox甜度 = new System.Windows.Forms.ComboBox();
            this.cBox冰塊 = new System.Windows.Forms.ComboBox();
            this.cBox配料 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl冷飲店訂購單
            // 
            this.lbl冷飲店訂購單.AutoSize = true;
            this.lbl冷飲店訂購單.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl冷飲店訂購單.Location = new System.Drawing.Point(222, 32);
            this.lbl冷飲店訂購單.Name = "lbl冷飲店訂購單";
            this.lbl冷飲店訂購單.Size = new System.Drawing.Size(138, 26);
            this.lbl冷飲店訂購單.TabIndex = 0;
            this.lbl冷飲店訂購單.Text = "冷飲店訂購單";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(28, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "訂購人手機號碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(28, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "冷飲品項";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(355, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "甜度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(355, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "冰塊";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(355, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "配料";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(28, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "數量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(255, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "單價";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(438, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "品項總價";
            // 
            // lbl單價
            // 
            this.lbl單價.AutoSize = true;
            this.lbl單價.BackColor = System.Drawing.Color.BurlyWood;
            this.lbl單價.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.Location = new System.Drawing.Point(263, 483);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(46, 26);
            this.lbl單價.TabIndex = 9;
            this.lbl單價.Text = "0元";
            // 
            // lbl品項總價
            // 
            this.lbl品項總價.AutoSize = true;
            this.lbl品項總價.BackColor = System.Drawing.Color.BurlyWood;
            this.lbl品項總價.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl品項總價.Location = new System.Drawing.Point(459, 483);
            this.lbl品項總價.Name = "lbl品項總價";
            this.lbl品項總價.Size = new System.Drawing.Size(46, 26);
            this.lbl品項總價.TabIndex = 10;
            this.lbl品項總價.Text = "0元";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Bisque;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(94, 483);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 26);
            this.label11.TabIndex = 11;
            this.label11.Text = "杯";
            // 
            // txt訂購人電話
            // 
            this.txt訂購人電話.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂購人電話.Location = new System.Drawing.Point(33, 106);
            this.txt訂購人電話.Multiline = true;
            this.txt訂購人電話.Name = "txt訂購人電話";
            this.txt訂購人電話.Size = new System.Drawing.Size(240, 45);
            this.txt訂購人電話.TabIndex = 12;
            // 
            // txt杯數
            // 
            this.txt杯數.Location = new System.Drawing.Point(33, 477);
            this.txt杯數.Multiline = true;
            this.txt杯數.Name = "txt杯數";
            this.txt杯數.Size = new System.Drawing.Size(55, 32);
            this.txt杯數.TabIndex = 13;
            this.txt杯數.TextChanged += new System.EventHandler(this.txt杯數_TextChanged);
            this.txt杯數.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt杯數_KeyPress);
            // 
            // btn加入訂購單
            // 
            this.btn加入訂購單.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入訂購單.Location = new System.Drawing.Point(72, 545);
            this.btn加入訂購單.Name = "btn加入訂購單";
            this.btn加入訂購單.Size = new System.Drawing.Size(163, 57);
            this.btn加入訂購單.TabIndex = 14;
            this.btn加入訂購單.Text = "加入訂購單";
            this.btn加入訂購單.UseVisualStyleBackColor = true;
            this.btn加入訂購單.Click += new System.EventHandler(this.btn加入訂購單_Click);
            // 
            // btn查看訂購單
            // 
            this.btn查看訂購單.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查看訂購單.Location = new System.Drawing.Point(342, 545);
            this.btn查看訂購單.Name = "btn查看訂購單";
            this.btn查看訂購單.Size = new System.Drawing.Size(163, 57);
            this.btn查看訂購單.TabIndex = 15;
            this.btn查看訂購單.Text = "查看訂購單";
            this.btn查看訂購單.UseVisualStyleBackColor = true;
            this.btn查看訂購單.Click += new System.EventHandler(this.btn查看訂購單_Click);
            // 
            // lBox冷飲品項
            // 
            this.lBox冷飲品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBox冷飲品項.FormattingEnabled = true;
            this.lBox冷飲品項.ItemHeight = 21;
            this.lBox冷飲品項.Location = new System.Drawing.Point(33, 183);
            this.lBox冷飲品項.Name = "lBox冷飲品項";
            this.lBox冷飲品項.Size = new System.Drawing.Size(289, 235);
            this.lBox冷飲品項.TabIndex = 16;
            this.lBox冷飲品項.SelectedIndexChanged += new System.EventHandler(this.lBox冷飲品項_SelectedIndexChanged);
            // 
            // cBox甜度
            // 
            this.cBox甜度.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBox甜度.FormattingEnabled = true;
            this.cBox甜度.Location = new System.Drawing.Point(415, 244);
            this.cBox甜度.Name = "cBox甜度";
            this.cBox甜度.Size = new System.Drawing.Size(121, 29);
            this.cBox甜度.TabIndex = 17;
            this.cBox甜度.SelectedIndexChanged += new System.EventHandler(this.cBox甜度_SelectedIndexChanged);
            // 
            // cBox冰塊
            // 
            this.cBox冰塊.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBox冰塊.FormattingEnabled = true;
            this.cBox冰塊.Location = new System.Drawing.Point(415, 294);
            this.cBox冰塊.Name = "cBox冰塊";
            this.cBox冰塊.Size = new System.Drawing.Size(121, 29);
            this.cBox冰塊.TabIndex = 18;
            this.cBox冰塊.SelectedIndexChanged += new System.EventHandler(this.cBox冰塊_SelectedIndexChanged);
            // 
            // cBox配料
            // 
            this.cBox配料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBox配料.FormattingEnabled = true;
            this.cBox配料.Location = new System.Drawing.Point(415, 347);
            this.cBox配料.Name = "cBox配料";
            this.cBox配料.Size = new System.Drawing.Size(121, 29);
            this.cBox配料.TabIndex = 19;
            this.cBox配料.SelectedIndexChanged += new System.EventHandler(this.cBox配料_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(156, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 26);
            this.label10.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(600, 645);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cBox配料);
            this.Controls.Add(this.cBox冰塊);
            this.Controls.Add(this.cBox甜度);
            this.Controls.Add(this.lBox冷飲品項);
            this.Controls.Add(this.btn查看訂購單);
            this.Controls.Add(this.btn加入訂購單);
            this.Controls.Add(this.txt杯數);
            this.Controls.Add(this.txt訂購人電話);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl品項總價);
            this.Controls.Add(this.lbl單價);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl冷飲店訂購單);
            this.Name = "Form1";
            this.Text = "冷飲店訂購單";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl冷飲店訂購單;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.Label lbl品項總價;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt訂購人電話;
        private System.Windows.Forms.TextBox txt杯數;
        private System.Windows.Forms.Button btn加入訂購單;
        private System.Windows.Forms.Button btn查看訂購單;
        private System.Windows.Forms.ListBox lBox冷飲品項;
        private System.Windows.Forms.ComboBox cBox甜度;
        private System.Windows.Forms.ComboBox cBox冰塊;
        private System.Windows.Forms.ComboBox cBox配料;
        private System.Windows.Forms.Label label10;
    }
}

