
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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace PickandDrink_Modele
{

    /// <summary>
    /// Classe Ingredient, contient tous les détails d'un ingrédient 
    /// </summary>
    [DataContract] // doit être persisté 
    public partial class Ingredient : IEquatable<Ingredient>
    {

        
        //Nom de l'ingrédient
        [DataMember(EmitDefaultValue = false)]
        public string Nom
        {
            get => nom;

            set
            {
                if (String.IsNullOrEmpty(value))return;
                
                nom = value;
                OnPropertyChanged();
            }
        }
        private string nom;


        //Quantité de l'ingrédient 
        [DataMember(EmitDefaultValue = false)]
        public float Qte {
            get => qte;

            set
            {
                if (value <= 0)return;
                qte = value;
                OnPropertyChanged();
            }
        }
        private float qte;


        //Unité de l'ingrédient 
        [DataMember(EmitDefaultValue = false)]
        public TypeUnite Unite
        {
            get => unite;
            set
            {
                unite = value;
                OnPropertyChanged();
            }
        }
        private TypeUnite unite;


        // Constructeurs d'un ingrédient en fonction des parametre passé, si pas de valeur => valeur par défaut 

        public Ingredient(string nom, float qte, TypeUnite unite)
        {
            Nom = nom;
            Qte = qte;
            Unite = unite;
        }

        public Ingredient(string nom, float qte) : this(nom, qte, TypeUnite.Unite) { }
        
        public Ingredient() : this("Nom", 0) {}

        //evenement permetant de mettre a jour la vue 
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        // ToString d'un ingrédient, utile pour les tests
        public override string ToString()
        {
            return $"{Nom} : {Qte} {Unite}";
        }


        //methode de test d'égalité de deux ingrédient 
        public override bool Equals(object right)
        {
            //check null
            if (object.ReferenceEquals(right, null))
            {
                return false;
            }

            if (object.ReferenceEquals(this, right))
            {
                return true;
            }

            if (this.GetType() != right.GetType())
            {
                return false;
            }

            return this.Equals(right as Ingredient);
        }

        public bool Equals(Ingredient other) => (this.Nom == other.Nom && this.Qte == this.Qte);

        public override int GetHashCode()
        {
            return HashCode.Combine(Nom);
        }
    }

}


