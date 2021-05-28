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
            // Lire les qualification dans la liste des qualifications dans l'entreprise
            // Trouver la qualification correspondant à la variable libelle
            // Copier cet eobjet dans q
            return q;
        }
        /// <summary>
        /// Charge le listebox de tous les nom d'employés correpondant à la qualification passée en libellé
        /// ex : qfficheEmploye("informaticien") retourne Sionne et Vavite dans le listBox
        /// </summary>
        /// <param name="libelle"></param>
        private void afficheEmploye(string libelle)
        {
            // Appeler la méthode qui donne la liste des employés pour le libellé passé en paramètre
            // Ajouter chacun des éléments de la liste dans l'objet listBox (cela fonctionne comme le comboBox)
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
            EffacerQualification(); // Vide le combobox de ses données 
            // Instanciation de l'objet qualification à partir des objets textBox
            Qualification q = new Qualification(Convert.ToInt32(textBox1.Text), textBox2.Text); 
            label9.Text = q.ToString(); // Afficher oes données dans le label
            entp.ajoutUneQualification(q); // Ajouter une qualification dans l'objet entreprise
            AfficheQualification(); // Remplir le comboBox
        }
        /*
         * 1 - Ajouter l'évènement clique sur le bouton ajouter un employé (faire un double clique sur le bouton)
         * 1.1 - Instanciation de l'objet employé à partir des objets textBox
         * 1.2 - Récupération de la qualification dans le comboBox (Quelque chose comme n°combobox.SelectedItem.ToString())
         * 1.3 - Avec la méthode GetQualification (que vous finirez) obtenoir l'objet qualification
         * 1.4 - Ajoutez cette qualification à l'objet employé
         * 1.5 - Ajouter l'objet employé dans l'objet entreprise
         * 2 - Ajouter l'évènement Selected item index changed sur la selection du combobox de groupe entreprise
         * 2.1 - Récupération de la qualification dans le comboBox
         * 2.2 - Appeler la méthode afficheEmploye pour la valeur choisie
         * 3 - Effacer les données de tous les comboBix et pas un seul.
         * 4 - Effacer les données déjà saisies lorsque l'utilisateur clique sur un bouton.
         * 5 - Ordoner la saisie lorsque l'utilisateur utilise le bouton tabulation du clavier.
         */
        #endregion
    }
}
