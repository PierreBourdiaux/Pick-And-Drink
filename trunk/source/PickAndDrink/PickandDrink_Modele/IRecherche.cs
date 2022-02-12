
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
using System.Collections.ObjectModel;
using System.Text;

namespace PickandDrink_Modele
{
    /// <summary>
    /// Stratégie abstraite de recherche, interface à implenter dans les stratégie concrètes
    /// </summary>
    public interface IRecherche
    {
        public IEnumerable<Cocktail> Recherche(string motCle, ObservableCollection<Cocktail> AllCocktails);
    }
}
