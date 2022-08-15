
namespace _0530期中作業
{
    partial class menu
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
            this.lBoxmenu = new System.Windows.Forms.ListBox();
            this.btn回首頁 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(254, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "鹽水雞MENU";
            // 
            // lBoxmenu
            // 
            this.lBoxmenu.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBoxmenu.FormattingEnabled = true;
            this.lBoxmenu.ItemHeight = 26;
            this.lBoxmenu.Location = new System.Drawing.Point(85, 139);
            this.lBoxmenu.Name = "lBoxmenu";
            this.lBoxmenu.Size = new System.Drawing.Size(623, 446);
            this.lBoxmenu.TabIndex = 1;
            this.lBoxmenu.SelectedIndexChanged += new System.EventHandler(this.lBoxmenu_SelectedIndexChanged);
            // 
            // btn回首頁
            // 
            this.btn回首頁.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn回首頁.Location = new System.Drawing.Point(22, 26);
            this.btn回首頁.Name = "btn回首頁";
            this.btn回首頁.Size = new System.Drawing.Size(74, 32);
            this.btn回首頁.TabIndex = 2;
            this.btn回首頁.Text = "回首頁";
            this.btn回首頁.UseVisualStyleBackColor = true;
            this.btn回首頁.Click += new System.EventHandler(this.btn回首頁_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.btn回首頁);
            this.Controls.Add(this.lBoxmenu);
            this.Controls.Add(this.label1);
            this.Name = "menu";
            this.Text = "菜單";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_FormClosing);
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBoxmenu;
        private System.Windows.Forms.Button btn回首頁;
    }
}