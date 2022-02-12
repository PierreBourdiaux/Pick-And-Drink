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

using PickAndDrink_App.converters;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PickAndDrink
{
    /// <summary>
    /// Logique d'interaction pour UCrecherche.xaml
    /// </summary>
   
    public partial class UCrecherche : UserControl
    {

        //On récupère le manager de App
        public Manager Man => (App.Current as App).Manager;

        //On récupère le navigateur de App
        public Navigator Navigator => (App.Current as App).Navigator;
        public List<Cocktail> rechCocktails { get; set; }

        
        public UCrecherche()
        {
            InitializeComponent();
            rechCocktails = new List<Cocktail>();
            
            // choix de la recherche 
            if (Man.Condition.Equals("Nom"))
            {
                var coc = Man.RechercheCocktail(Man.Motcle, new RechNom());
                foreach (Cocktail c in coc) rechCocktails.Add(c);

            }
            else if (Man.Condition.Equals("Ingrédient"))
            {
                var coc = Man.RechercheCocktail(Man.Motcle, new RechIng());
                foreach (Cocktail c in coc) rechCocktails.Add(c);
            }
            else if (Man.Condition.Equals("Degré d'alcool"))
            {
                var coc = Man.RechercheCocktail(Man.Motcle, new RechDegAlc());
                foreach (Cocktail c in coc) rechCocktails.Add(c);
            }
            DataContext = this;
        }

        // affichage du detail du cocktail souhaité lors du changement de selection dans la listBox 
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Navigator.NavigateTo(Navigator.PART_RECETTE);
            rechCocktails.Clear();
        }
    }
}
