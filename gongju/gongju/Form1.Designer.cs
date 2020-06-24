namespace gongju {
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
            this.lab_path = new System.Windows.Forms.Label();
            this.btn_ChangePath = new System.Windows.Forms.Button();
            this.btn_CreateTask = new System.Windows.Forms.Button();
            this.sTaskname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab_path
            // 
            this.lab_path.AutoSize = true;
            this.lab_path.Location = new System.Drawing.Point(36, 20);
            this.lab_path.Name = "lab_path";
            this.lab_path.Size = new System.Drawing.Size(65, 12);
            this.lab_path.TabIndex = 0;
            this.lab_path.Text = "整合包路径";
            // 
            // btn_ChangePath
            // 
            this.btn_ChangePath.Location = new System.Drawing.Point(38, 35);
            this.btn_ChangePath.Name = "btn_ChangePath";
            this.btn_ChangePath.Size = new System.Drawing.Size(75, 23);
            this.btn_ChangePath.TabIndex = 1;
            this.btn_ChangePath.Text = "更换路径";
            this.btn_ChangePath.UseVisualStyleBackColor = true;
            this.btn_ChangePath.Click += new System.EventHandler(this.btn_ChangePath_Click);
            // 
            // btn_CreateTask
            // 
            this.btn_CreateTask.Location = new System.Drawing.Point(72, 92);
            this.btn_CreateTask.Name = "btn_CreateTask";
            this.btn_CreateTask.Size = new System.Drawing.Size(75, 23);
            this.btn_CreateTask.TabIndex = 2;
            this.btn_CreateTask.Text = "创建任务";
            this.btn_CreateTask.UseVisualStyleBackColor = true;
            this.btn_CreateTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // sTaskname
            // 
            this.sTaskname.Location = new System.Drawing.Point(171, 92);
            this.sTaskname.Name = "sTaskname";
            this.sTaskname.Size = new System.Drawing.Size(100, 21);
            this.sTaskname.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sTaskname);
            this.Controls.Add(this.btn_CreateTask);
            this.Controls.Add(this.btn_ChangePath);
            this.Controls.Add(this.lab_path);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_path;
        private System.Windows.Forms.Button btn_ChangePath;
        private System.Windows.Forms.Button btn_CreateTask;
        private System.Windows.Forms.TextBox sTaskname;
    }
}

