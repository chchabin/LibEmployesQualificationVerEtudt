using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibEmployesQualificationVerEtudt;


namespace WFormEmployesQualification
{
    public partial class Form1 : Form
    {
        Entreprise entp = new Entreprise("maPetiteAffaire");
        public Form1()
        {
            InitializeComponent();
            label10.Text = entp.getNom(); 
        }
        #region fonctions utiles
        /// <summary>
        /// Affiche les qualifications dans les combobox
        /// </summary>
        private void AfficheQualification()
        {
            foreach (Qualification q in entp.getLesQualification())
            {
                comboBox1.Items.Add(q.getlibelle());
            }

        }
        /// <summary>
        /// Efface les qualifications dans les combobox
        /// </summary>
        private void EffacerQualification()
        {
            comboBox2.Items.Clear();
        }
        /// <summary>
        /// Donne la qualification correspondant au libellé passé en paramètre
        /// ex : GetQualification("informaticien") retourne l'objet qualification correspondant
        /// </summary>
        /// <param name="libelle"></param>
        /// <returns>objet qualification</returns>
        private Qualification GetQualification(string libelle)
        {
            Qualification q = new Qualification();


            return q;
        }
        /// <summary>
        /// Charge le listebox de tous les nom d'employés correpondant à la qualification passée en libellé
        /// ex : qfficheEmploye("informaticien") retourne Sionne et Vavite dans le listBox
        /// </summary>
        /// <param name="libelle"></param>
        private void afficheEmploye(string libelle)
        {

        }
        #endregion
        #region Gestion des évènements
        /// <summary>
        /// Evenement clique sur ajouter une qualification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            EffacerQualification();
            Qualification q = new Qualification(Convert.ToInt32(textBox1.Text), textBox2.Text);
            label9.Text = q.ToString();
            entp.ajoutUneQualification(q);
            AfficheQualification();
        }
        /*
         * 1 - Ajouter l'évènement clique sur ajouter un employé
         * 2 - Ajouter l'évènement Selected item index changed sur la selection du combobox de groupe entreprise
         */
        #endregion
    }
}
