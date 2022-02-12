//  ================
//  \     Pick     /
//   \    AND     /
//    \   Drink  /      Auteur : Pierre BOURDIAUX 
//     \        /       Date   : 12/06/2021
//      \      /        Projet tuteuré S2 DUT informatique 
//       \    /         IUT Clermont Auvergne - Site Aubière
//        \  /
//         ||
//         ||
//         ||
//         ||
//         ||
//  IIIIIIIIIIIIIIIII

using PickAndDrink;
using PickAndDrink_App.utils;
using PickandDrink_Modele;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PickAndDrink_App.windows
{
    /// <summary>
    /// Logique d'interaction pour AjouterCocktail.xaml
    /// </summary>
    public partial class AjouterCocktail : Window
    {
        public Manager man => (App.Current as App).Manager;

        public Cocktail cocktail { get; private set; }
        public Recette r { get; private set; }

        public List<Ingredient> ing { get; private set; }
        public List<Etape> etapes { get; private set; }
        
        public AjouterCocktail()
        {
            InitializeComponent();
            DataContext = this;
            var coc = new Cocktail("");
            cocktail = new Cocktail(coc.Nom, coc.Image);
            r = new Recette("", -1, -1, "", Niveau.Inconnu);
            ing = new List<Ingredient>();
            for(int i =0; i<5; i++)
            {
                ing.Add(new Ingredient());
            }

            etapes = new List<Etape>();
            for (int i = 0; i < 10; i++)
            {
                etapes.Add(new Etape(i + 1, "Détails de l'étape"));
            }


        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Ajout_Click(object sender, RoutedEventArgs e)
        {
            foreach (Ingredient i in ing) r.AjoutIngredient(i);
            foreach (Etape etape in etapes) r.AjoutEtape(etape.Num, etape.Desc);
            cocktail.AjoutRecette(r);
            man.AjoutCocktailCrea(cocktail);
            man.CocktailSélectionné = cocktail;
            Close();
        }

        private void Parcourir_Click(object sender, RoutedEventArgs e)
        {
            string filename = FolderBrowserImages.ChoixImage();
            if (string.IsNullOrWhiteSpace(filename)) return;
            cocktail.Image = filename;
        }
    }
}
