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

namespace test_XMLPM
{
    /// <summary>
    /// Programme de teste de la persistance XMl
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(new Stub.Stub());
            manager.ChargeDonnées();
            manager.Pers = new XmlPM.XmlPM(); // necessite de metre Pers avec un setter public 
            manager.SauvegardeDonnées();
        }
    }
}
