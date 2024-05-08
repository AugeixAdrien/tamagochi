using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamagochi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void jouer_Click(object sender, EventArgs e)
        {
            tamagochiJoueur.Jouer();
            UpdateDisplay();
        }

        private void nourrir_Click(object sender, EventArgs e)
        {
            tamagochiJoueur.Nourrir();
            UpdateDisplay();
        }

        private void gronder_Click(object sender, EventArgs e)
        {
            tamagochiJoueur.Gronder();
            UpdateDisplay();
        }

        private void travailler_Click(object sender, EventArgs e)
        {
            tamagochiJoueur.Travailler();
            UpdateDisplay();
        }

        private void dormir_Click(object sender, EventArgs e)
        {
            tamagochiJoueur.Dormir();
            UpdateDisplay();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
        
        Tamagochi tamagochiJoueur = new Tamagochi();
        
        private void UpdateDisplay()
        {
            // récupère les statistiques du tamagochi et les met dans des variables locales
            // met à jour les labels avec les variables locales en regardant à quel niveau de satisfaction correspond la satisfaction du tamagochi
            // tout les 10 points de satisfaction, le tamagochi gagne un niveau (satisfait, très satisfait), s'il est en dessous de 10 il est compté comme pas satisfait
            // tout les 10 points de taille le tamagochi gagne un niveau (très petit, petit, moyen, gros, très gros)
            // si le tamagochi est mort, affiche un message et désactive les boutons
            
            int satisfactionVar = tamagochiJoueur.GetSatisfaction();
            int tailleVar = tamagochiJoueur.GetTaille();
            
            if (satisfactionVar < 10)
            {
                satisfaction.Text = "Pas satisfait";
            }
            else if (satisfactionVar < 20)
            {
                satisfaction.Text = "Satisfait";
            }
            else
            {
                satisfaction.Text = "Très satisfait";
            }
            
            if (tailleVar < 10)
            {
                taille.Text = "Très petit";
            }
            else if (tailleVar < 20)
            {
                taille.Text = "Petit";
            }
            else if (tailleVar < 30)
            {
                taille.Text = "Moyen";
            }
            else if (tailleVar < 40)
            {
                taille.Text = "Gros";
            }
            else
            {
                taille.Text = "Très gros";
            }
            
            if (tamagochiJoueur.EstVivant() == false)
            {
                MessageBox.Show("Il est mort. Désolé.");
                jouer.Enabled = false;
                nourrir.Enabled = false;
                gronder.Enabled = false;
                travailler.Enabled = false;
                dormir.Enabled = false;
            }
            Console.WriteLine(tamagochiJoueur.GetSatisfaction());
        }
    }
}