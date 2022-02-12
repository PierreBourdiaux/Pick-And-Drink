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

using PickandDrink_Modele;
using System;

namespace TestStub
{

    /// <summary>
    /// différente methode d'affichage, utile pour le test du  stub 
    /// </summary>
    public static class Afficheur
    {
        public static void AfficheCoctail(Manager man)
        {
            Console.WriteLine("*************************LISTE DE TOUS LES COCKTAILS : *************************\n\n");
            foreach (Cocktail c in man.AllCocktailROC) Console.WriteLine(c);
            Console.WriteLine("============================================================================");
            Console.WriteLine("============================================================================");
        }
        public static void AfficheCoctailFav(Manager man)
        {
            Console.WriteLine("*************************LISTE DE TOUS LES COCKTAILS FAVORIS : *************************\n\n");
            foreach (Cocktail c in man.FavCocktailROC) Console.WriteLine(c);
            Console.WriteLine("============================================================================");
            Console.WriteLine("============================================================================");
        }

        public static void AfficheCoctailCrea(Manager man)
        {
            Console.WriteLine("*************************LISTE DE TOUS LES COCKTAILS CREES: *************************\n\n");
            foreach (Cocktail c in man.CreaCocktailROC) Console.WriteLine(c);
            Console.WriteLine("============================================================================");
            Console.WriteLine("============================================================================");
        }

        public static void AfficheTout(Manager man)
        {
            AfficheCoctail(man);
            AfficheCoctailCrea(man);
            AfficheCoctailFav(man);
        }


    }
}
