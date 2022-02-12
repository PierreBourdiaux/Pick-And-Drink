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
    /// Logique d'interaction pour UCBoissonDesc.xaml
    /// </summary>
    public partial class UCBoissonDesc : UserControl
    {
        public UCBoissonDesc()
        {
            InitializeComponent();
        }



        public string Texte
        {
            get { return (string)GetValue(TexteProperty); }
            set { SetValue(TexteProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Texte.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TexteProperty =
            DependencyProperty.Register("Texte", typeof(string), typeof(UCBoissonDesc), new PropertyMetadata("Inconnu"));





        public string ImageName
        {
            get { return (string)GetValue(ImageNameProperty); }
            set { SetValue(ImageNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageNameProperty =
            DependencyProperty.Register("ImageName", typeof(string), typeof(UCBoissonDesc), new PropertyMetadata("Default.png"));



        public int NbRecette
        {
            get { return (int)GetValue(NbRecetteProperty); }
            set { SetValue(NbRecetteProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NbRecette.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NbRecetteProperty =
            DependencyProperty.Register("NbRecette", typeof(int), typeof(UCBoissonDesc), new PropertyMetadata(1));





    }
}
