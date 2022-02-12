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
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PickandDrink_Modele
{
    public class Manager : INotifyPropertyChanged 
    {
            
        /// <summary>
        /// Facade du modèle, classe Manager, c'est elle qui intéragie avec l'application
        /// </summary>


        //Cocktail qui est séléctionné pour la description des recette de ce dernier 
        public Cocktail CocktailSélectionné 
        {
            get=> cocktailSélectionné;
            set
            {
                if (cocktailSélectionné != value)
                {
                    cocktailSélectionné = value;
                    OnPropertyChanged(nameof(cocktailSélectionné));
                }
            }
        }

        private Cocktail cocktailSélectionné;

        //Liste de tous les cocktail 
       
        private ObservableCollection<Cocktail> allCocktail = new ObservableCollection<Cocktail>();

        //Liste de tous les cocktail Favoris
        private ObservableCollection<Cocktail> favCocktail = new ObservableCollection<Cocktail>();

        //Liste de toutes les crétaions

        private ObservableCollection<Cocktail> creaCocktail = new ObservableCollection<Cocktail>();

        // événement pour l'actualisation de la vue de l'application
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
            =>PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            
        

        public ReadOnlyObservableCollection<Cocktail> AllCocktailROC {get; private set; }
        public ReadOnlyObservableCollection<Cocktail> FavCocktailROC { get; private set; }
        public ReadOnlyObservableCollection<Cocktail> CreaCocktailROC { get; private set; }

        public IPersManager Pers { get; private set; }

        //mot clé binder à la textbox de l'application
        public string Motcle
        {
            get => motcle;

            set
            {
                if (string.IsNullOrEmpty(value)) motcle = "";
                else motcle = value;
            }
        }
        private string motcle="";

        //condition de la rechere, lié a une combobox de l'app
        public string Condition
        {
            get => condition;

            set
            {
                if (value.Contains("Nom")) condition = "Nom";
                else if (value.Contains("Ing")) condition = "Ingrédient";
                else if (value.Contains("Deg")) condition = "Degré d'alcool";
                else condition = "Nom";
            }
        }
        private string condition = "Nom";


        // constructeur de Manager, injéction de dépendance pour la persistance
        public Manager( IPersManager persistance)
        {
            Pers = persistance;
            ChargeDonnées();

        }


        //méthode de chargement des données grâce a la persistance injécté
        public void ChargeDonnées()
        {
            (var all, var fav, var crea)= Pers.Chargement();
            allCocktail.Clear();
            foreach(Cocktail c in all)
            {
                allCocktail.Add(c);
            }
            favCocktail.Clear();
            foreach (Cocktail c in fav)
            {
                AjoutCocktailFav(c);
            }

            creaCocktail.Clear();
            foreach (Cocktail c in crea)
            {
                creaCocktail.Add(c);
            }

            this.triList();
            CocktailSélectionné = allCocktail[0];
            int max = 0;
            foreach(Cocktail c in allCocktail)
            {
                if (c.UID > max) max = c.UID;
            }
            cocktailSélectionné.LoadUID(max);
            

        }

        //methode d'ajout de cocktail 
        public void AjoutCocktail(Cocktail c)
        {
            allCocktail.Add(c);
            
        }

        //methode d'ajout d'un cocktail dans les favoris
        public void AjoutCocktailFav(Cocktail c)
        {
            favCocktail.Add(c);
            c.FavRef = "img/fav.png";
            
        }

        //methode d'ajout de cocktail dans les création (et donc dans la liste  de tous les cocktails)
        public void AjoutCocktailCrea(Cocktail c)
        {
            creaCocktail.Add(c);
            allCocktail.Add(c);
            
        }

        //methode de suppression d'une crétaion
        public void SuppCreation(Cocktail c)
        {
            if (creaCocktail.Contains(c))
            {
                creaCocktail.Remove(c);
                allCocktail.Remove(c);
                if (favCocktail.Contains(c))
                {
                    SuppFav(c);
                    favCocktail.Remove(c);
                }
                
            }

        }

        //suppression d'un cocktail des favoris
        public void SuppFav(Cocktail c)
        {
            if (favCocktail.Contains(c)) 
            {
                favCocktail.Remove(c);
                c.FavRef = "img/notfav.png";
            }
                
        }

        //méthode de recherche de cocktail (injection de dépendance de la condition de recherche)
        public IEnumerable<Cocktail> RechercheCocktail(string motCle, IRecherche recherche)
        { 

                return recherche?.Recherche(motCle, allCocktail);
        }

        //méthode de tri des trois list, utilisé lors du chargement des données 
        private void triList()
        {
            allCocktail = Tri.tri(allCocktail);
            AllCocktailROC = new ReadOnlyObservableCollection<Cocktail>(allCocktail);
            favCocktail = Tri.tri(favCocktail);
            FavCocktailROC = new ReadOnlyObservableCollection<Cocktail>(favCocktail);
            creaCocktail = Tri.tri(creaCocktail);
            CreaCocktailROC = new ReadOnlyObservableCollection<Cocktail>(creaCocktail);

        }

        //méthode de modification d'un cocktail
        public Cocktail ModifCocktail(Cocktail oldC, Cocktail newC)
        {
            Type typeCocktail = typeof(Cocktail);
            var cocktailProperties = typeCocktail.GetProperties(); // on récopère les propriété d'un cocktail
            
            foreach(var property in cocktailProperties.Where(ppty => ppty.CanWrite)) // pour chaque propriété d'un cocktail
            {                                                                        // on les copies dans le cocktail 
                property.SetValue(oldC, property.GetValue(newC));                    // qui avait les ancienne propriété
            }

            return oldC;
        }
        
        //méthode de sauvegarde des données grâce a la persistance passé lors de l'instanciation du Manager
        public void SauvegardeDonnées()
        {
            Pers.Enregistrement(allCocktail, favCocktail, creaCocktail);
        }
        
        

    }
}
