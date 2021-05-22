using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEmployesQualificationVerEtudt
{
    public class Employe
    {
        private string numSecu;
        private string nom;
        private string prenom;
        private Qualification q;

        public string getNumSecu()
        {
            return this.numSecu;
        }
        public string getPrenom()
        {
            return this.prenom;
        }
        public string getNom()
        {
            return this.nom;
        }
        public void setQualification(Qualification q)
        {
            this.q = q;

        }
        public string getQualification()
        {
            return this.q.getlibelle();
        }
        
        public Employe(string noSecu, string n, string p)
        {
            this.numSecu = noSecu;
            this.nom = n;
            this.prenom = p;
        }
        public override string ToString()
        {
            string s = $"numsecu : {this.numSecu}\nnom {this.nom}\nprenom : {this.prenom}\nA pour qualification : {this.q.ToString()}";

            return s;
            
        }
    }
}
