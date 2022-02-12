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
    /// Classe de recherche par Degrès d'alcool, 
    /// sert à trouver un liste de cocktail ayant une recette avec un degrès d'alcool 
    /// entre la valeur demandé et 5° de moin 
    /// (ex si on demande 30 on aura les recette de 25° à 30°)
    /// Stratégie concrète de rechere => implémentation de l'interface IRecherche 
    /// </summary>
    public class RechDegAlc :IRecherche
    {
        public IEnumerable<Cocktail> Recherche(string motCle, ObservableCollection<Cocktail> AllCocktails)
        {
            if (String.IsNullOrEmpty(motCle)) motCle = "0";
            List<Cocktail> CocktailTrouvé = new List<Cocktail>();
            float degAlc = float.Parse(motCle);
            foreach(Cocktail c in AllCocktails)
            {
                foreach(Recette r in c.LesRecettes)
                {
                    if(r.DegAlc<= degAlc && r.DegAlc>degAlc-5)
                    {
                        CocktailTrouvé.Add(c);
                    }
                }
            }
            return CocktailTrouvé;

        }

       
    }
}
