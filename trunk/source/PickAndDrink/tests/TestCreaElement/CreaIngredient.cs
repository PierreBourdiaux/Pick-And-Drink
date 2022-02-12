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
    /// Classe de testes de création d'ingrédients
    /// </summary>
    class CreaIngredient
    {
        // teste de tout les constructeurs
        private Ingredient Ingredient1 = new Ingredient("Sirop de fraise", 3, TypeUnite.Ml);
        private Ingredient Ingredient2 = new Ingredient("Glaçons", 3);

        public CreaIngredient() { }

        public void AfficheIng()
        {
            Console.WriteLine("AFFICHAGE DE L'INGREDIENT 1 : ");
            Console.WriteLine(Ingredient1);
            Console.WriteLine("\nAFFICHAGE DE L'INGREDIENT 2 : ");
            Console.WriteLine(Ingredient2);

        }
    }
}
