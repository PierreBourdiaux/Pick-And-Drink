using PickandDrink_Modele;
using System;
using System.Collections.Generic;
using System.Text;

namespace executable
{
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

        public static void AfficheSelection(Manager man)
        {
            Console.WriteLine("============================================================================");
            Console.WriteLine("============================================================================");
            Console.WriteLine("============================================================================");
            Console.WriteLine("============================================================================");
            Console.Write(man.CocktailSélectionné);
        }


    }
}
