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
    /// Programme destiné a tester le stub de l'application
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Manager MonManager = new Manager(new Stub.Stub());
            MonManager.ChargeDonnées();
            Afficheur.AfficheCoctail(MonManager);
            Afficheur.AfficheCoctailFav(MonManager);
            Afficheur.AfficheCoctailCrea(MonManager);

        }
    }
}
