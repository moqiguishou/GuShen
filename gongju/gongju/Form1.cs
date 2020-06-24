using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gongju {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            string path = MyIni.ReadIniData("Common", "path", "-1");
            lab_path.Text = path;
        }

        private void btn_ChangePath_Click(object sender, EventArgs e) {
            //OpenFileDialog dialog = new OpenFileDialog();
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Description = "请选择文件夹";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                string file = dialog.SelectedPath;
                lab_path.Text = file;
                MyIni.WriteIniData("Common", "path", file);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            Form_Task fTask = new Form_Task();
            fTask.setLuaName(this.sTaskname.Text);
            fTask.Show();
        }
    }
}

