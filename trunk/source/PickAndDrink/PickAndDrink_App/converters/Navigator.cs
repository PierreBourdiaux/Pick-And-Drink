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

using PickAndDrink;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;

namespace PickAndDrink_App.converters
{

    /// <summary>
    /// Classe Navigator qui fera la navigation entre les partit de fenêtre de l'app
    /// </summary>
    public class Navigator : INotifyPropertyChanged
    {
        public const string PART_FAVANDCREA = "Favoris et création";
        public const string PART_RECHERCHE = "Recherche";
        public const string PART_RECETTE = "Recette";

        public ReadOnlyDictionary<string, Func<UserControl>> WindowParts { get; private set; }
        
        
        // liste des différente fenêtre accessible
        private Dictionary<string, Func<UserControl>> windowParts = new Dictionary<string, Func<UserControl>>()
        {
            
            [PART_RECHERCHE] = () => new UCrecherche(),
            [PART_FAVANDCREA] = () => new UCFavandCrea(),
            [PART_RECETTE] = () => new UCrecette(),

        };

        // Constructeur d'un navigateur 
        public Navigator()
        {
            WindowParts = new ReadOnlyDictionary<string, Func<UserControl>>(windowParts);
            SelectedUserControlCreator = WindowParts.First();
        }

        //Parti de fenêtre séléctionné,  
        public KeyValuePair<string, Func<UserControl>> SelectedUserControlCreator
        {
            get => selectedUserControlCreator;
            set
            {
                if (SelectedUserControlCreator.Equals(value)) return;
                selectedUserControlCreator = value;
                OnProperdtyChanged();
            }
        }
        private KeyValuePair<string, Func<UserControl>> selectedUserControlCreator;

        // evenement pour mettre a joue la vue 
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnProperdtyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        //fonction de navigation
        public void NavigateTo(string windowPartName)
        {
            if (windowParts.ContainsKey(windowPartName))
            {
                SelectedUserControlCreator = WindowParts.Single(kvp => kvp.Key == windowPartName);
            }
        }
    }
}
