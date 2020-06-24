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
    public partial class Form_Task : Form {
        private string TaskNameLua;
        private string TaskType;
        private Dictionary<int, TaskInfo> tTaskinfo = new Dictionary<int, TaskInfo>();
        private int index = 0;
        public Form_Task() {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e) {
            string path = MyIni.ReadIniData("Common", "path", "-1");
            if (path.Equals("-1")) {
                return;
            }
            //lua
            string luaNamePre = MyIni.ReadIniData("TaskType", TaskType, "1");
            string fullName = path + "\\..\\lua\\[" + luaNamePre + "]" + TaskNameLua + ".lua";
            File.WriteAllText(fullName,"",Encoding.UTF8);
            //csv

            string csvFullName = luaNamePre + "\\++TaskInfo.csv";

            MessageBox.Show("成功");
        }

        public void setLuaName(string name) {
            TaskNameLua = name;
        }

        private void sTaskType_TextChanged(object sender, EventArgs e) {
            TaskType = sTaskType.Text;
        }

        private void btn_AddTask_Click(object sender, EventArgs e) {
            TaskInfo task = new TaskInfo(sTaskName.Text, sTaskIntention.Text, sTaskid.Text, sTaskType.Text, sStarttype.Text, sMapid.Text, sLuaType.Text, sNpcGroup.Text, seffect.Text, sMark.Text);
            index = index + 1;
            tTaskinfo.Add(index,task);
            lab_JiShu.Text = index.ToString();
        }
    }
}
