using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GuShen {
    class Func {

        //Regex regChina = new Regex("^bai[^\x00-\xFF]");//^[A-Za-z]+$
        Regex regNum = new Regex("^[0-9]");
        Regex regYingWen = new Regex("^[a-zA-Z]");
        Regex regChina = new Regex("^[^\x00-\xFF]");
        Regex regEnglish = new Regex("^[a-zA-Z]");

        public bool isNum(string s) {
            if (regNum.IsMatch(s)) {
                return true;
            }
            return false;
        }

        public bool isYingWen(string s) {
            if (regYingWen.IsMatch(s)) {
                return true;
            }
            return false;
        }

        public bool isChina(string s) {
            if (regChina.IsMatch(s)) {
                return true;
            }
            return false;
        }
    }
}
