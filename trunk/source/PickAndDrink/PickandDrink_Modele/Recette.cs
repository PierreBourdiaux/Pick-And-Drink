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
using System.Runtime.Serialization;
using System.Text;

namespace PickandDrink_Modele
{

    /// <summary>
    /// Classe représentant une recette d'un cocktail 
    /// </summary>
    [DataContract] /// les recette doivent être persisté 
    public partial class Recette
    {

        // degrès d'alcool de la recette
        [DataMember (EmitDefaultValue = false)]
        public float DegAlc 
        {
            get=>degAlc;
            set 
            {
                if (value < 0) return;
                degAlc = value;
            }
        }
        private float degAlc;

        
        // Nom de la recette (pas forcement le même que le nom du cocktail si il y a plusieurs version)
        //ex : Mojito et Virgin Mojito => version  avec et sans alcool
        [DataMember(EmitDefaultValue = false)]
        public string Nom
        {
            get => nom;

            set
            {
                if (String.IsNullOrEmpty(value)) return;
                nom = value;
            }
        }
        private string nom;


        //nombre de calories dans la recette 
        [DataMember(EmitDefaultValue = false)]
        public int Calorie
        {
            get=>calorie;
            set
            {
                if (value < 0) return;
                calorie = value;
            }
        }
        private int calorie;

        // description de la recette (pas des étapes)
        [DataMember(EmitDefaultValue = false)]
        public string Desc
        { 
            get=>desc;
            set
            {
                if (String.IsNullOrEmpty(value)) return;
                desc = value;
            }
        }
        private string desc;

        // Difficulté de la recette 
        [DataMember(EmitDefaultValue = false)]
        public Niveau Difficulté
        {
            get => difficulté;
            set
            {
                difficulté = value;
            }
        }
        private Niveau difficulté;

        //Liste des étapes dans une sorted list pour que les étapes soit automatiquement dans l'ordre
        private SortedList<int, string> etapes = new SortedList<int, string>();

        [DataMember(EmitDefaultValue = false)]
        public SortedList<int, string> LesEtapes { get; set; }

        

        // Liste des ingrédients necessaire pour la recette
        private ObservableCollection<Ingredient> Ingredients = new ObservableCollection<Ingredient>();


        [DataMember(EmitDefaultValue = false)]
        public ReadOnlyObservableCollection<Ingredient> LesIngredients
        {
            get;
            private set;
        }

       
        // Constructeurs d'une recette en fonction des parametre passé, si pas de valeur => valeur par défaut 
        public Recette(string nom,float DegAlc, int Calorie, string Desc, Niveau dif)
        {
            Nom = nom;
            this.DegAlc = DegAlc;
            this.Calorie = Calorie;
            this.Desc = Desc;
            Difficulté = dif;
            LesIngredients = new ReadOnlyObservableCollection<Ingredient>(Ingredients);
            LesEtapes = new SortedList<int, string>(etapes);

        }

        public Recette(string nom, string Desc, Niveau dif) : this(nom, 0,0,Desc, dif) { }
        public Recette(string nom, string Desc) : this(nom, 0, 0, Desc, Niveau.Inconnu) { }
        public Recette(string nom) : this(nom, 0, 0,"Aucune description renseigné", Niveau.Inconnu) { }


        //ToString qui construit la description de la recette (utile pour les testes)
        public override string ToString()
        {
            StringBuilder Message = new StringBuilder($"{Nom} \n");
            Message.Append($"contient {DegAlc} ° d'alcool\n");
            Message.Append($"contient {Calorie} kcal\n");
            Message.Append($"Description : {Desc}\n");
            Message.Append($"Difficulté : {Difficulté}\n");
            Message.Append($"Ingrédient necessaires :\n");

            foreach (Ingredient i in LesIngredients) Message.Append($"{i}  \n");

            Message.Append( $"Etapes : \n");
            foreach(KeyValuePair<int,string> etape in etapes)
            {
                Message.Append($"Etape {etape.Key} : {etape.Value}\n");
            }
            string mess = Message.ToString();
            return mess;
        }

        // méthode d'ajout d'ingrédient 
        public void AjoutIngredient(Ingredient i)
        {
            if (i.Nom.Equals("Nom") && i.Qte == 0) return; // si la textbox n'a pas été modifié 
            Ingredients.Add(i);
        }

        // méthode d'ajout d'étapes
        public void AjoutEtape(int num, String detail)
        {
            if (detail.Equals("Détails de l'étape")) return; // si la textbox n'a pas été modifié 
            etapes.Add(num, detail);
            LesEtapes = new SortedList<int, string>(etapes);
        }






    }
}
