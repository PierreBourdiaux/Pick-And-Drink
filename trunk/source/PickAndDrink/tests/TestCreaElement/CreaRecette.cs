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
using System.Collections.Generic;
using System.Text;

namespace TestCreaElement
{
    /// <summary>
    /// Classe de teste de création de recettes
    /// </summary>
    class CreaRecette
    {
        /*Test de tout les constructeurs de recette*/

        public Recette testRecette1 = new Recette("Diabolo fraise", 0, 150, "boisson rafraichissante",Niveau.Facile );
        public Recette testRecette2 = new Recette("Diabolo fraise", "boisson rafraichissante", Niveau.Facile );
        public Recette testRecette3 = new Recette("Diabolo fraise", "boisson rafraichissante" );
        public Recette testRecette4 = new Recette("Diabolo fraise");
        public CreaRecette()
        {
            Ingredient sirop = new Ingredient("sirop de fraise", 3,TypeUnite.Ml);
            Ingredient limonade = new Ingredient("limonade", 35,TypeUnite.Ml);
            testRecette1.AjoutIngredient(sirop);
            testRecette1.AjoutIngredient(limonade);
            testRecette2.AjoutIngredient(sirop);
            testRecette2.AjoutIngredient(limonade);
            testRecette3.AjoutIngredient(sirop);
            testRecette3.AjoutIngredient(limonade);
            testRecette4.AjoutIngredient(sirop);
            testRecette4.AjoutIngredient(limonade);

            
            testRecette1.AjoutEtape(1, "mettez le sirop au fond d'un verre");
            testRecette1.AjoutEtape(2, "completez avec la limonade");
            testRecette2.AjoutEtape(1, "mettez le sirop au fond d'un verre");
            testRecette2.AjoutEtape(2, "completez avec la limonade");
            testRecette3.AjoutEtape(1, "mettez le sirop au fond d'un verre");
            testRecette3.AjoutEtape(2, "completez avec la limonade");
            testRecette4.AjoutEtape(1, "mettez le sirop au fond d'un verre");
            testRecette4.AjoutEtape(2, "completez avec la limonade");

        }

        public void afficheRecettes()
        {
            Console.WriteLine("Affichage des Recettes de test");
            Console.WriteLine("Recette 1 :");
            Console.WriteLine(testRecette1);
            Console.WriteLine("Recette 2 :");
            Console.WriteLine(testRecette2);
            Console.WriteLine("Recette 3 :");
            Console.WriteLine(testRecette3);
            Console.WriteLine("Recette 4 :");
            Console.WriteLine(testRecette4);
        }
    }
}
