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
using PickAndDrink_App.windows;
using PickandDrink_Modele;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //on recupère le manager de App
        public Manager Man => (App.Current as App).Manager;

        //on recupère le navigateur de App
        public Navigator Navigator => (App.Current as App).Navigator;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        
        // click de création d'un cocktail
        private void Crea_Click(object sender, RoutedEventArgs e)
        {

            var ajouterCocktail = new AjouterCocktail();
            ajouterCocktail.ShowDialog();
        }

        //click pour aller a la page des favoris et création
        private void FavAndCrea_Click(object sender, RoutedEventArgs e)
        {
            Man.CocktailSélectionné= null;
            Navigator.NavigateTo(Navigator.PART_FAVANDCREA);
        }

        // click pour le lancement de la recherche 
        private void Recherche_Click(object sender, RoutedEventArgs e)
        {
            Man.CocktailSélectionné = null;
            Navigator.NavigateTo(Navigator.PART_RECHERCHE);
        }

        // affichage du detail du cocktail souhaité lors du changement de selection dans la listBox 
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.PART_RECETTE);
        }

        // click sauvegarder et quitter 
        private void WQ_Click(object sender, RoutedEventArgs e)
        {
            Man.SauvegardeDonnées();
            Close();
        }
    }
}
