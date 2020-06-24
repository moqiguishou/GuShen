using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gongju {
    class MyData {
        public string Name;
        public string FullName;
        public string[] ZiDuans;
        public string PreFour;
        //public Dictionary<string, string> Data = new Dictionary<string, string>();
        public Dictionary<int, Dictionary<string, string>> AllData = new Dictionary<int, Dictionary<string, string>>();
        public MyData(string Name) {
            this.Name = Name;
            string sPrePath = MyIni.ReadIniData("Path","DataInfoOffice","");
            //string sPrePath = @"../../../data/";
            string Path = sPrePath + Name + ".csv";
            FullName = Path;
            //RedFile(Path);
            RedFilePreFour(Path);
            //FileInfo fi = new FileInfo(Path);
        }
        private void RedFilePreFour(string FullName) {
            FileStream fs = new FileStream(FullName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string str = "";
            str = sr.ReadLine();
            PreFour = PreFour + str+ "\n";
            str = sr.ReadLine();
            PreFour = PreFour + str + "\n";
            str = sr.ReadLine();
            PreFour = PreFour + str + "\n";
            ZiDuans = str.Split(',');//第3行搜集字段
            str = sr.ReadLine();
            PreFour = PreFour+ str;
            //第五行充当默认数值
            str = sr.ReadLine();
            string[] valves = GetValves(str);
            Dictionary<string, string> Data = new Dictionary<string, string>();
            for (int i = 0; i < ZiDuans.Length; i++) {
                Data.Add(ZiDuans[i], valves[i]);
            }
            AllData.Add(0, Data);
            sr.Close();
            fs.Close();
        }

        private string[] GetValves(string str) {
            bool b = false;
            string s = "";
            foreach (char a in str) {
                if (b && a.Equals(",")) {
                    s = s + "@";
                } else {
                    s = s + a;
                }
                if (a.Equals("\"") && !b) {
                    b = true;
                }
                if (a.Equals("\"") && b) {
                    b = false;
                }
            }
            string[] values = s.Split(',');
            for (int i = 0; i < values.Length; i++) {
                values[i] = values[i].Replace("@", ",");
            }
            return values;
        }


        private void RedFile(string FullName) {
            //FileInfo fi = new FileInfo(FullName);
            string str = "";
            FileStream fs = new FileStream(FullName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            str = sr.ReadLine();
            ZiDuans = str.Split(',');
            str = sr.ReadLine();
            int index = 1;
            while ((str = sr.ReadLine()) != null) {
                string[] valves = str.Split(',');
                Dictionary<string, string> Data = new Dictionary<string, string>();
                for (int i = 0; i < ZiDuans.Length; i++) {
                    Data.Add(ZiDuans[i], valves[i]);
                }
                AllData.Add(index, Data);
                index++;
            }
            sr.Close();
            fs.Close();
        }

        public bool isHaveData(string key, string valve) {
            //bool isB = false;
            if (AllData.Count == 0) {
                return false;
            }
            if (!AllData[1].ContainsKey(key)) {
                return false;
            }
            //遍历全部的值
            foreach (KeyValuePair<int, Dictionary<string, string>> kv in AllData) {
                if (kv.Value[key] == valve) {
                    return true;
                }
            }

            return false;
        }

        public string GetValve(string ziduan, string key, string outZiduan) {
            if (AllData.Count == 0 || !AllData[1].ContainsKey(ziduan) || !AllData[1].ContainsKey(outZiduan)) {
                return "";
            }

            foreach (KeyValuePair<int, Dictionary<string, string>> kv in AllData) {
                if (kv.Value[ziduan] == key) {
                    return kv.Value[outZiduan];
                }
            }
            return "";
        }

        public List<string> GetValve(string ziduan) {
            List<string> res = new List<string>();
            if (AllData.Count == 0 || !AllData[1].ContainsKey(ziduan)) {
                return res;
            }

            foreach (KeyValuePair<int, Dictionary<string, string>> kv in AllData) {
                res.Add(kv.Value[ziduan]);
            }
            return res;
        }

        public bool isHave(string ziduan, string v) {
            return false;
        }

        private bool isZiDuan(string ziduan) {
            if (AllData.Count == 0 || !AllData[1].ContainsKey(ziduan)) {
                return false;
            }
            if (AllData[1].ContainsKey(ziduan)) {
                return true;
            }
            return false;
        }

        public void test() {
            string str = "";
            str = str + "name:" + Name + "\n";
            str = str + "ZiDuan:" + " ";
            foreach (string s in ZiDuans) {
                str = str + s + " ";
            }
            str = str + "\n";
            foreach (KeyValuePair<int, Dictionary<string, string>> kv in AllData) {
                foreach (KeyValuePair<string, string> kvv in kv.Value) {
                    str = str + kvv.Value + " ";
                }
                str = str + "\n";
            }
            MessageBox.Show(str);
        }
    }
}
