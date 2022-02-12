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
    /// Classe de recherche par ingrédient, 
    /// sert à trouver un liste de cocktail correspondant au mot clé (par nom d'ingrédient du cocktail) 
    /// Stratégie concrète de rechere => implémentation de l'interface IRecherche 
    /// </summary>
    public class RechIng : IRecherche
    {
        public IEnumerable<Cocktail> Recherche(string motCle, ObservableCollection<Cocktail> AllCocktails)
        {
            List<Cocktail> CocktailTrouvé = new List<Cocktail>();
            bool trouve;
            foreach (Cocktail c in AllCocktails)
            {
                trouve = false;
                foreach (Recette r in c.LesRecettes)
                {
                    foreach (Ingredient i in r.LesIngredients)
                    {
                        if (i.Nom.ToUpper().Contains(motCle.ToUpper()))
                        {
                            CocktailTrouvé.Add(c);
                            trouve = true;
                            break;
                        }
                        
                    }
                    if(trouve) break;

                }
            }
            return CocktailTrouvé;

        }

    }
}
