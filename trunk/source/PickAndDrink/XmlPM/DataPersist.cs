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
using System.Runtime.Serialization;
using System.Text;

namespace XmlPM
{

    /// <summary>
    /// Classe permetant de reunir toutes les données a serialiser 
    /// </summary>
    [DataContract]
    class DataPersist
    {
        [DataMember]
        public List<Cocktail> allCocktail = new List<Cocktail>();

        [DataMember]
        public List<Cocktail> favCocktail = new List<Cocktail>();

        [DataMember]
        public List<Cocktail> creaCocktail = new List<Cocktail>();
    }
}
