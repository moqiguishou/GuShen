namespace GuShen {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_Id = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lab_Price = new System.Windows.Forms.Label();
            this.lab_num = new System.Windows.Forms.Label();
            this.lab_total = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.Box_GP = new System.Windows.Forms.ComboBox();
            this.txt_sousuo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(69, 40);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 21);
            this.txt_Name.TabIndex = 0;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(14, 43);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(41, 12);
            this.lab_Name.TabIndex = 1;
            this.lab_Name.Text = "股票名";
            // 
            // lab_Id
            // 
            this.lab_Id.AutoSize = true;
            this.lab_Id.Location = new System.Drawing.Point(175, 49);
            this.lab_Id.Name = "lab_Id";
            this.lab_Id.Size = new System.Drawing.Size(29, 12);
            this.lab_Id.TabIndex = 2;
            this.lab_Id.Text = "代号";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(210, 43);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 21);
            this.txt_Id.TabIndex = 3;
            this.txt_Id.TextChanged += new System.EventHandler(this.txt_Id_TextChanged);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(410, 43);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 21);
            this.txt_price.TabIndex = 4;
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "买入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_Price
            // 
            this.lab_Price.AutoSize = true;
            this.lab_Price.Location = new System.Drawing.Point(349, 49);
            this.lab_Price.Name = "lab_Price";
            this.lab_Price.Size = new System.Drawing.Size(29, 12);
            this.lab_Price.TabIndex = 6;
            this.lab_Price.Text = "价格";
            // 
            // lab_num
            // 
            this.lab_num.AutoSize = true;
            this.lab_num.Location = new System.Drawing.Point(536, 49);
            this.lab_num.Name = "lab_num";
            this.lab_num.Size = new System.Drawing.Size(53, 12);
            this.lab_num.TabIndex = 7;
            this.lab_num.Text = "买入数量";
            // 
            // lab_total
            // 
            this.lab_total.AutoSize = true;
            this.lab_total.Location = new System.Drawing.Point(678, 49);
            this.lab_total.Name = "lab_total";
            this.lab_total.Size = new System.Drawing.Size(29, 12);
            this.lab_total.TabIndex = 8;
            this.lab_total.Text = "总价";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(595, 43);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(53, 21);
            this.txt_num.TabIndex = 9;
            this.txt_num.TextChanged += new System.EventHandler(this.txt__TextChanged);
            // 
            // Box_GP
            // 
            this.Box_GP.FormattingEnabled = true;
            this.Box_GP.Location = new System.Drawing.Point(16, 203);
            this.Box_GP.Name = "Box_GP";
            this.Box_GP.Size = new System.Drawing.Size(121, 20);
            this.Box_GP.TabIndex = 10;
            this.Box_GP.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            //this.Box_GP.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // txt_sousuo
            // 
            this.txt_sousuo.Location = new System.Drawing.Point(155, 202);
            this.txt_sousuo.Name = "txt_sousuo";
            this.txt_sousuo.Size = new System.Drawing.Size(100, 21);
            this.txt_sousuo.TabIndex = 11;
            this.txt_sousuo.TextChanged += new System.EventHandler(this.txt_sousuo_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.txt_sousuo);
            this.Controls.Add(this.Box_GP);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lab_total);
            this.Controls.Add(this.lab_num);
            this.Controls.Add(this.lab_Price);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lab_Id);
            this.Controls.Add(this.lab_Name);
            this.Controls.Add(this.txt_Name);
            this.Name = "Form1";
            this.Text = "股神的故事";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_Id;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lab_Price;
        private System.Windows.Forms.Label lab_num;
        private System.Windows.Forms.Label lab_total;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.ComboBox Box_GP;
        private System.Windows.Forms.TextBox txt_sousuo;
    }
}

