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
    /// Classe étapes, utilisé pour la création d'un cocktail
    /// </summary>
    public class Etape
    {

        // numéro de l'étape
        public int Num
        {
            get => num;

            set
            {
                if (value <= 0) return;
                else num = value;
            }
        }
        private int num;

        //Description de l'étape
        public string Desc
        {
            get => desc;
            set
            {
                if (String.IsNullOrEmpty(value)) return;
                desc = value;
            }
        }
        private string desc;


        //constructeur d'une étape
        public Etape(int noEtape, string descEtape)
        {
            Num = noEtape;
            Desc = descEtape;
        }

        
        public override string ToString()
        {
            return $"Etape {Num} : {Desc}";
        }
    }
}
