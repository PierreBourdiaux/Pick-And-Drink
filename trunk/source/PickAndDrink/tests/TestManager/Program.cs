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
using TestCreaElement;
using TestStub;

namespace TestManager
{
    /// <summary>
    /// Programme de test du Manager 
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {

            Manager MonManager = new Manager(new Stub.Stub());
            MonManager.ChargeDonnées();
            Afficheur.AfficheTout(MonManager);

            var res = MonManager.RechercheCocktail("le perso", new RechNom());
            foreach (Cocktail c in res) MonManager.AjoutCocktailFav(c);
            Afficheur.AfficheTout(MonManager);
            

            
        }

        Cocktail CreaCocktailTest()
        {
           Cocktail c1 = new Cocktail("diabolo fraise", "diabolof.jpg");
           Recette testRecette = new Recette("Diabolo fraise");
           Ingredient sirop = new Ingredient("sirop de fraise", 3, TypeUnite.Ml);
           Ingredient limonade = new Ingredient("limonade", 35, TypeUnite.Ml);
            testRecette.AjoutIngredient(sirop);
            testRecette.AjoutIngredient(limonade);
            testRecette.AjoutEtape(1, "mettez le sirop au fond d'un verre");
            testRecette.AjoutEtape(2, "completez avec la limonade");
            return c1;
        }
            

    }
}

