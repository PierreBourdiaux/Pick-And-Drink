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

namespace TestRecherche
{

    /// <summary>
    /// Programme de teste sur les recherche de cocktail
    /// </summary>
    class Program
    {
        enum TypesRecherche : byte
        {
            DegAlc,
            Ing,
            Nom
        }

        static Dictionary<TypesRecherche, Func<IRecherche>> factoryIRecherche = new Dictionary<TypesRecherche, Func<IRecherche>>()
        {
            [TypesRecherche.DegAlc] = () => new RechDegAlc(),
            [TypesRecherche.Ing] = () => new RechIng(),
            [TypesRecherche.Nom] = () => new RechNom(),
        };
        static void Main(string[] args)
        {
            Manager MonManager = new Manager(new Stub.Stub());
            MonManager.ChargeDonnées();

            Console.WriteLine("===================================== test recherche par degres d'alcool =======================================");
            var resDeg = MonManager.RechercheCocktail("37,5", factoryIRecherche[TypesRecherche.DegAlc]());
            foreach (Cocktail c in resDeg) Console.WriteLine(c);

            Console.WriteLine("===================================== test recherche par ingrédient =======================================");
            var resIng = MonManager.RechercheCocktail("vod", new RechIng());
            foreach (Cocktail c in resIng) Console.WriteLine(c);

            Console.WriteLine("====================================== test recherche par nom ======================================");
            var resNom = MonManager.RechercheCocktail("Margarita", new RechNom());
            foreach (Cocktail c in resNom) Console.WriteLine(c);
        }
    }
}
