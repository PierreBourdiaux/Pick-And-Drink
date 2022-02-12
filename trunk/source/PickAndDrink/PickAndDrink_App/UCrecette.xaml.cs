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
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
    /// Logique d'interaction pour UCrecette.xaml
    /// </summary>
    public partial class UCrecette : UserControl
    {
        //On recupère le manager de App
        public Manager Man => (App.Current as App).Manager;

        //On recupère le navigateur de App
        public Navigator Navigator => (App.Current as App).Navigator;

     

        public UCrecette()
        {
            InitializeComponent();
            DataContext = Man;
            
        }

        //demande de modification du cocktail 
      
        private void Button_Click_Modif(object sender, RoutedEventArgs e)
        {
            if (Man.CreaCocktailROC.Contains(Man.CocktailSélectionné)) //test si le cocktail est une création 
            {
                var modifierCocktailWindow = new ModifierCocktail();
                modifierCocktailWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas autorisé à modifier un cocktail que vous n'avez pas créé", "Permissions non accordée");
            }
           
        }

        //demande de suppression d'un cocktail
        private void Button_Click_Supp(object sender, RoutedEventArgs e)
        {


            if (Man.CreaCocktailROC.Contains(Man.CocktailSélectionné)) //test si le cocktail est une création 
            {
                
                Man.SuppCreation(Man.CocktailSélectionné);
                Navigator.NavigateTo(Navigator.PART_FAVANDCREA);

            }
            else
            {
                MessageBox.Show("Vous n'êtes pas autorisé à supprimer un cocktail que vous n'avez pas créé", "Permissions non accordée");
            }
        }

        //changement d'état de favoris 
        private void Fav_Click(object sender, RoutedEventArgs e)
        {
            if (Man.CocktailSélectionné.FavRef.Equals("img/fav.png"))
            {
                Man.SuppFav(Man.CocktailSélectionné);
            }
            else Man.AjoutCocktailFav(Man.CocktailSélectionné);
        }
    }
}
