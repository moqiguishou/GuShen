using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuShen {
    class MyData {
        public string Name;
        public string[] ZiDuans;
        //public Dictionary<string, string> Data = new Dictionary<string, string>();
        public Dictionary<int, Dictionary<string,string>> AllData = new Dictionary<int, Dictionary<string, string>>();
        public MyData(string Name) {
            this.Name = Name;
            string sPrePath = @"../../../data/";
            string Path = sPrePath + Name + ".csv";
            RedFile(Path);
            //FileInfo fi = new FileInfo(Path);
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

        public string GetValve(string ziduan,string key,string outZiduan) {
            if (AllData.Count == 0|| !AllData[1].ContainsKey(ziduan) || !AllData[1].ContainsKey(outZiduan)) {
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

        public void test() {
            string str = "";
            str = str+ "name:" + Name + "\n";
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
