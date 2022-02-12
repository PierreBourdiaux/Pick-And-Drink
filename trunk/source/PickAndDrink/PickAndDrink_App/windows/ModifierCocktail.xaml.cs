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
    /// Logique d'interaction pour ModifierCocktail.xaml
    /// </summary>
    public partial class ModifierCocktail : Window
    {

        public Manager man => (App.Current as App).Manager;

        public Cocktail cocktail { get; private set; }
        public ModifierCocktail()
        {
            InitializeComponent();
            
            var coc = man.CocktailSélectionné;
            cocktail = new Cocktail(coc.Nom, coc.Image);
            DataContext = cocktail;
            foreach (Recette r in coc.LesRecettes)
            {
                cocktail.AjoutRecette(r);
            }
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Modif_Click(object sender, RoutedEventArgs e)
        {
           
            man.ModifCocktail(man.CocktailSélectionné, cocktail);
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
