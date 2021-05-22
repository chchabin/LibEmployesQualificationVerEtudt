using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEmployesQualificationVerEtudt
{
    public class Entreprise
    {
        private String nom;
        private List<Employe> lesEmployes;
        private List<Qualification> lesQualifications;
      
        public Entreprise (String nom){
            this.nom = nom;
            this.lesEmployes = new List<Employe>();
            this.lesQualifications = new List<Qualification>();

         }
        public string getNom()
        {
            return this.nom;
        }
        public List<Qualification> getLesQualification()
        {
            return this.lesQualifications;
        }
        public void ajouterEmploye(Employe e)
        {
            lesEmployes.Add(e);
        }
        public int nbEmployes()
        {
            return lesEmployes.Count;
        }
        public void ajouterQualification(String unLibelleQualification,int unCodeQualification )
        {
            Qualification q = new Qualification(unCodeQualification,unLibelleQualification );
            lesQualifications.Add(q);
        }
        public void ajoutUneQualification(Qualification q)
        {
            lesQualifications.Add(q);
        }
        public List<Employe> GetEmployesdequalification(string unlibellequalification)
        {
            List<Employe> qualification = new List<Employe>();
            foreach(Employe unEmploye in lesEmployes)
            {
                if (unEmploye.getQualification().Equals(unlibellequalification))
                {
                    qualification.Add(unEmploye);
                }
            }
            return qualification;
        }


    }
}
