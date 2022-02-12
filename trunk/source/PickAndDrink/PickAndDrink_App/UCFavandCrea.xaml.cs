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
    /// Logique d'interaction pour UCFavandCrea.xaml
    /// </summary>
    public partial class UCFavandCrea : UserControl
    {

        public Manager Man => (App.Current as App).Manager;

        public Navigator Navigator => (App.Current as App).Navigator;
        public UCFavandCrea()
        {
            InitializeComponent();
            DataContext = Man;
        }

        // affichage du detail du cocktail souhaité lors du changement de selection dans la listBox 
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.PART_RECETTE);
        }
    }
}
