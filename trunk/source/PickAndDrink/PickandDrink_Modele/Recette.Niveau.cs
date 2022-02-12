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
using System.Collections.Generic;
using System.Text;

namespace PickandDrink_Modele
{
    /// <summary>
    /// enumération des difficulté d'un recette de cocktail ( par defaut inconnu )
    /// </summary>
        public enum Niveau
        {
            Inconnu =0,     //0000000
            Facile=1,       //0000001
            Moyen = 2,      //0000010
            Difficile = 3   //0000011
    }
}
