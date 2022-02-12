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
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace PickandDrink_Modele
{
    /// <summary>
    /// Classe de Cocktail
    /// </summary>
    [DataContract]
    public class Cocktail : IEquatable<Cocktail>, INotifyPropertyChanged
    {

        // Nom du cocktail
        [DataMember (EmitDefaultValue = false, Order = 0)]
        public string Nom
        {
            get => nom;

            set
            {
                if (String.IsNullOrEmpty(value)) return;
                nom = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Self));
            }
        }
        private string nom;

        // Identifiant unique du cocktail
        public int UID
        {
            get => uid;

        }
        [DataMember(EmitDefaultValue = false, Order = 1)]
        private readonly int uid;

        //Static donc commun a tout les cocktail, à la valeur de l'uid de plus grand 
        //donc lors de la construction d'un cocktail on incrémente cette valeur de 1 => valeur jamais attribué
        public static int UidAttribution { get; set; }  = 0 ;


        // Nom de l'image du cocktail
        [DataMember(EmitDefaultValue = false)]
        public string Image
        {
            get=>image;
            set
            {
                if (String.IsNullOrEmpty(value)) return;
                image = value;
                OnPropertyChanged();

            }
        }
        private string image;

        // Nom de l'image pour le boutton des favoris (soit Fav.png soit NotFav.png) 
        [DataMember(EmitDefaultValue = false)]
        public string FavRef
        {
            get => favRef;
            set
            {
                if (String.IsNullOrEmpty(value)) return;
                favRef = value;
                OnPropertyChanged();

            }
        }
        private string favRef;



        public Cocktail Self => this;

       // Liste de toutes les recettes disponnible pour ce cocktail
        private List<Recette> recettes = new List<Recette>();


        // evenement pour actualiser la vue
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        [DataMember(EmitDefaultValue = false)]
        public ReadOnlyCollection<Recette> LesRecettes
        {
            get;
            private set;
        }

        // Constructeurs d'un Cocktail en fonction des parametre passé, si pas de valeur => valeur par défaut 

        public Cocktail(string nom, string image)
        {
            Nom = nom;
            Image = image;
            LesRecettes = new ReadOnlyCollection<Recette>(recettes);
            FavRef = "img/notfav.png";
            uid = UidAttribution;
            UidAttribution ++ ;
            
        }



        public Cocktail(string nom) : this(nom, "Default.png") {}

        public void AjoutRecette( Recette r)
        {
            if(!(r==null))
            recettes.Add(r);
        }

        //Hash code du cocktail basé sur l'identifiant Unique 
        public override int GetHashCode()
        {
            return UID.GetHashCode();
        }

        //protocole d'égalité d'un cocktail
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

            return this.Equals(right as Cocktail);
        }

        public bool Equals(Cocktail other) => (this.Nom == other.Nom);

        //ToString d'un cocktail, utile lors des testes
        public override string ToString()
        {
            int nbRecette = 0;
            if (recettes != null) nbRecette = recettes.Count();
            StringBuilder Message = new StringBuilder($"Nom du cocktail : {Nom}\nSource image : {Image} \nNombre de recette dispo :{nbRecette} \ndetail des recettes : \n\n");
            if (recettes != null)
                foreach (Recette r in recettes) Message.Append($"{r}\n");
            string mess = Message.ToString();
            return mess;
        }

        //méthode pour changer l'UID minimal
        public void LoadUID(int i)
        {
            UidAttribution = i;
        }
    }

    
    

}

