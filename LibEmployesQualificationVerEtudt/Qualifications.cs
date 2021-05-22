using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEmployesQualificationVerEtudt
{
    public class Qualification
    {
        private int code;
        private string libelle;

        public int getcode()
        { return this.code; }

        public string getlibelle()
        {
            return this.libelle;
        }
         public Qualification(int codeQ,string libelle)
        {
            this.libelle = libelle;
            this.code = codeQ;
        }
        public Qualification() { }
        public override string ToString()
        {
            string s = $"{this.code} - {this.libelle}";
            return s;
        }


    }
}


