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
using System.Linq;
using System.Text;

namespace PickandDrink_Modele
{
    /// <summary>
    /// Classe de recherche par Nom, 
    /// sert à trouver un liste de cocktail correspondant au mot clé (par nom de cocktail) 
    /// Stratégie concrète de rechere => implémentation de l'interface IRecherche 
    /// </summary>
    public class RechNom : IRecherche
    {
        public IEnumerable<Cocktail> Recherche(string motCle, ObservableCollection<Cocktail> AllCocktails)
        {
            IEnumerable<Cocktail> Cocktailcorrespondant = from c in AllCocktails
                                                        where c.Nom.ToUpper().Contains(motCle.ToUpper())
                                                        select c;
            List<Cocktail> CocktailTrouvé = new List<Cocktail>();
            foreach (Cocktail c in Cocktailcorrespondant)
            {
                CocktailTrouvé.Add(c);
            }


            return CocktailTrouvé;
        }
    }
}
