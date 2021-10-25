using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace şampiyonlar_ligi
{
    internal class takim
    {
        private string takimismi;
        private string takimulke;

        public takim(string isim,string ulke)
        {
            takimismi = isim;
            takimulke = ulke;
        }
        public string TeamName
        {
            get {  return takimismi; }
            set {  takimismi = value;}
        }
        public string TeamCountry
        {
            get { return takimulke; }
            set {  takimulke = value; }
        }
        public override string ToString()
        {
            return takimismi + "-" + takimulke;
        }
    }
}
