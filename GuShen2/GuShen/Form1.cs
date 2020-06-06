using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuShen {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            initBox();
        }

        private void initBox() {
            List<string> GP = new List<string>();
            //for
        }
        private void txt__TextChanged(object sender, EventArgs e) {
            if (txt_price.Text == "") {
                return;
            }
            decimal price = decimal.Parse(txt_price.Text);
            int num = int.Parse(txt_num.Text);

            lab_total.Text = GetTotal(price, num, 1) + " + " + MyIni.ReadIniData("maimai", "mairu", "0.0") + " = " + GetTotal(price, num, 2);

        }

        private void txt_price_TextChanged(object sender, EventArgs e) {
            if (txt_num.Text == "") {
                return;
            }
            decimal price = decimal.Parse(txt_price.Text);
            int num = int.Parse(txt_num.Text);

            lab_total.Text = GetTotal(price, num, 1) +" + "+ MyIni.ReadIniData("maimai", "mairu", "0.0") +" = "+ GetTotal(price, num, 2);

        }

        private void button1_Click(object sender, EventArgs e) {
            MyData dt = new MyData("JiaoYi");
            string str = dt.GetValve("id", "60330900", "Time");
            DateTime dt1 = Convert.ToDateTime(str);
            DateTime dt2 = DateTime.Now;
            TimeSpan span = dt2.Subtract(dt1);
             int dayDiff = span.Days + 1;
            MessageBox.Show(dayDiff+"");
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        private decimal GetTotal(decimal price,int num,int type) {
            decimal total = price * num * 100;
            //decimal maichu = decimal.Parse(MyIni.ReadIniData("maimai", "maichu", "0.0"));

            if (type == 1) {
                return total;
            } else{
                decimal mairu = decimal.Parse(MyIni.ReadIniData("maimai", "mairu", "0.0"));
                return (total + mairu);
            }
            
        }

        private void txt_Name_TextChanged(object sender, EventArgs e) {
            MyData gp = new MyData("GuPiao");
            if (gp.isHaveData("name", txt_Name.Text)) {
                txt_Id.Text = gp.GetValve("name", txt_Name.Text, "daima");
            }
        }

        private void txt_Id_TextChanged(object sender, EventArgs e) {
            MyData gp = new MyData("GuPiao");
            if (gp.isHaveData("daima", txt_Id.Text)) {
                txt_Name.Text = gp.GetValve("daima", txt_Id.Text, "name");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            //Box_GP.Text = Box_GP.SelectedItem;
            MessageBox.Show(Box_GP.Items[Box_GP.SelectedIndex].ToString());
        }

        private void txt_sousuo_TextChanged(object sender, EventArgs e) {
            if (txt_sousuo.Text == "") {
                return;
            }
            Box_GP.Items.Clear();
            MyData dt = new MyData("GuPiao");
            Func f = new Func();

            List<string> JG = new List<string>();
            List<string> JG_SaiXuan = new List<string>();

            if (f.isChina(txt_sousuo.Text)) {
                JG = dt.GetValve("name");
            }
            if (f.isNum(txt_sousuo.Text)) {
                JG = dt.GetValve("daima");
            }
            if (f.isYingWen(txt_sousuo.Text)) {
                JG = dt.GetValve("ChinesePY");
            }
            //JG_SaiXuan.Add(txt_sousuo.Text);
            foreach (string str in JG) {

                if (txt_sousuo.Text.Length <= str.Length && str.Substring(0, txt_sousuo.Text.Length) == txt_sousuo.Text) {
                    JG_SaiXuan.Add(str);
                }
            }
            Box_GP.Items.AddRange(JG_SaiXuan.ToArray());
            txt_sousuo.Select(txt_sousuo.Text.Length, 0);
            if (Box_GP.Items.Count >= 1) {
                Box_GP.SelectedIndex = 0;
            }
        }
    }
}
