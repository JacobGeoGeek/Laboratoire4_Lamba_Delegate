using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratoire4
{
    public partial class Form1 : Form
    {
        delegate double Formule(double pVitesse, double pMasse);
        List<Personne> listedePersonne = new List<Personne>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {

            Formule Emc2 = AvecDelegateRetournEnergie;
            txtEnergie.Text = Emc2(double.Parse(txtVitesse.Text), double.Parse(txtMasseKg.Text)).ToString();

        }
        static double AvecDelegateRetournEnergie(double pV, double pM)
        {
        
           
                return pM * Math.Pow(pV, 2);
          

        }

        private void btnMethodeAnonyme_Click(object sender, EventArgs e)
        {
            Formule Emc2 = delegate (double pV, double pM)
           {
             
               
                   return pM * Math.Pow(pV, 2);
              
           };
            txtEnergie.Text = Emc2(double.Parse(txtVitesse.Text), double.Parse(txtMasseKg.Text)).ToString();
        }

        private void btnLamda_Click(object sender, EventArgs e)
        {
            Formule Emc2 = (xV,xM) => xM * Math.Pow(xV,2); //NB que le Energie n'est pas utiliser dans l'expression
      
            txtEnergie.Text = Emc2(double.Parse(txtVitesse.Text), double.Parse(txtMasseKg.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Func<double,double,double> Energie = (xV,xM) => xM * Math.Pow(xV, 2);
            txtEnergie.Text = Energie(double.Parse(txtVitesse.Text), double.Parse(txtMasseKg.Text)).ToString();
        }

        private void btnVersListeOriginal_Click(object sender, EventArgs e)
        {
            Personne x = new Personne(txtNom.Text, txtPrenom.Text, int.Parse(txtNo.Text), txtDepartement.Text, double.Parse(txtSalaire.Text));
            listedePersonne.Add(x);

            listBoxPersonne.Items.Clear();
            listBoxPersonne.Items.AddRange(listedePersonne.ToArray());

            txtNom.Clear();
            txtPrenom.Clear();
            txtNo.Clear();
            txtDepartement.Clear();
            txtSalaire.Clear();

        }

        private void btnInfoLINQ_Click(object sender, EventArgs e)
        {
            //avec linq
            var Q6 = from x in listedePersonne
                          where x.Departement == "Informatique"
                          select x;

            listBoxResults.Items.Clear();
            listBoxResults.Items.AddRange(Q6.ToArray());


        }

        private void btnbtnInfoLambda_Click(object sender, EventArgs e)
        {
            var q7 = listedePersonne.FindAll(x => x.Departement == "Informatique");
            listBoxResults.Items.Clear();
            listBoxResults.Items.AddRange(q7.ToArray());
        }

        private void btnInfoLINQNomPrenom_Click(object sender, EventArgs e)
        {
            var Q8 = from x in listedePersonne
                     where x.Departement == "Informatique"
                     select new { Nom = x.Nom, Prenom = x.Prenom };

            listBoxResults.Items.Clear();
            listBoxResults.Items.AddRange(Q8.ToArray());

        }

        private void btnNombreEmploye_Click(object sender, EventArgs e)
        {
            var Q9 = (from x in listedePersonne select x).Count(x => x.Departement== "Informatique");
            listBoxResults.Items.Clear();
            listBoxResults.Items.Add(Q9);


        }

        private void btnMoyenneSalaire_Click(object sender, EventArgs e)
        {
            var Q9 = listedePersonne.Where(x => x.Departement == "Informatique" && x.Salaire > 3000).Average(x=>x.Salaire);
            listBoxResults.Items.Clear();
            listBoxResults.Items.Add(Q9);
        }
    }
}
