using System;
using PickandDrink_Modele;
using Stub;

namespace executable
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager MonManager = new Manager(new Stub.Stub());
            MonManager.ChargeDonnées();
            Afficheur.AfficheCoctail(MonManager);
            Afficheur.AfficheCoctailFav(MonManager);
            Afficheur.AfficheCoctailCrea(MonManager);
            Afficheur.AfficheSelection(MonManager);
            
            

        }

    }
}
