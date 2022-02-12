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

namespace TestCreaElement
{

    /// <summary>
    /// Programme de test de création d'élément => Ingrédient, Recette et Cocktail
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============Programme de test de création des differents éléments========================");
            Console.WriteLine("*********creation d'un ingerdient et affichage avec 'toString'**********");
            CreaIngredient testIngredient = new CreaIngredient();
            testIngredient.AfficheIng();

            Console.WriteLine("*********creation de recettes et affichage avec 'toString'**********");
            CreaRecette testRecette = new CreaRecette();
            testRecette.afficheRecettes();

            Console.WriteLine("*********creation de Cocktail et affichage avec 'toString'**********");
            CreaCocktail testCocktail = new CreaCocktail();
            testCocktail.afficheCocktail();
        }
    }
}
