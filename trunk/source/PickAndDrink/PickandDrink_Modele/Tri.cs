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
using System.Linq;
using System.Collections.ObjectModel;

namespace PickandDrink_Modele
{
    /// <summary>
    /// Classe de tri, 
    /// sert a transformer un liste de cocktail en liste de cocktail trié par nom (ordre alphabétique) 
    /// </summary>
    static class Tri
    {
        public static ObservableCollection<Cocktail> tri(ObservableCollection<Cocktail> ListeCocktail)
        {
            ObservableCollection<Cocktail> NewList = new ObservableCollection<Cocktail>();
            IEnumerable<Cocktail> orderedCoctails = from c in ListeCocktail
                                                    orderby c.Nom.ToUpper()
                                                    select c;

            foreach (Cocktail c in orderedCoctails) NewList.Add(c);
            return NewList;
        }
    }
}
