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
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace TestCreaElement
{
    /// <summary>
    /// Programme de testes de création de cocktails
    /// </summary>
    class CreaCocktail
    {
        /*test des consrtucteur de cocktail et des methodes*/
        CreaRecette recettes = new CreaRecette();
        public Cocktail c1 = new Cocktail("diabolo fraise", "diabolof.jpg"); // public pour pouvoir les reutiliser par la suite
        public Cocktail c2 = new Cocktail("diabolo fraise");

        public CreaCocktail()
        {
            c1.AjoutRecette(recettes.testRecette1);
            c1.AjoutRecette(recettes.testRecette2);
            c2.AjoutRecette(recettes.testRecette3);
            c2.AjoutRecette(recettes.testRecette4);
        }

        public void afficheCocktail()
        {
            WriteLine("Affichage des Cocktails de test");
            WriteLine("cocktail 1 :");
            WriteLine(c1);
            WriteLine("cocktail 2 :");
            WriteLine(c2);
        }


    }
}
