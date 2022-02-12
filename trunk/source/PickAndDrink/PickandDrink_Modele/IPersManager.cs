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
    /// Stratégie abstraite de Persistance, interface à implenter dans les stratégie concrètes
    /// </summary>
    public interface IPersManager
    {
        public (IEnumerable<Cocktail>, IEnumerable<Cocktail>, IEnumerable<Cocktail>) Chargement();
        public void Enregistrement(IEnumerable<Cocktail> AllCocktail, IEnumerable<Cocktail> FavCocktail, IEnumerable<Cocktail> CreaCoctkail);
    }
}
