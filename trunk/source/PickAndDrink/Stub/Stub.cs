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
using System.Diagnostics;

namespace Stub
{
    /// <summary>
    /// Classe Stub permettant de charger des données pour effectuer des testes 
    /// Stratégie concrète de IPersManager 
    /// </summary>
    public class Stub : IPersManager
    {
        private List<Cocktail> AllCocktail = new List<Cocktail>();

        private List<Cocktail> FavCocktail = new List<Cocktail>();

        private List<Cocktail> CreaCocktail = new List<Cocktail>();

        // Chargement des cocktails 
        public (IEnumerable<Cocktail> , IEnumerable<Cocktail> , IEnumerable<Cocktail>) Chargement()
        {

            AllCocktail.Clear();
            FavCocktail.Clear();
            CreaCocktail.Clear();

            Ingredient Rhum = new Ingredient("rhum", 4, TypeUnite.Cl);
            Ingredient Menthe = new Ingredient("menthe", 6, TypeUnite.Unite);
            Ingredient EauG = new Ingredient("eau gazeuse", 1, TypeUnite.Unite);
            Ingredient SiropSucre = new Ingredient("Sirop de sucre de canne", 2, TypeUnite.Cl);
            Ingredient CitronVert = new Ingredient("Citron vert", (float)0.5, TypeUnite.Unite);
            Ingredient Glaçons = new Ingredient("Glaçons", 10, TypeUnite.Unite);
            Recette r1 = new Recette("Mojito ", (float)37.5, 175, "le meilleur cocktail du monde", Niveau.Facile);
            
            r1.AjoutIngredient(Menthe);
            r1.AjoutIngredient(Rhum);
            r1.AjoutIngredient(EauG);
            r1.AjoutIngredient(SiropSucre);
            r1.AjoutIngredient(CitronVert);
            r1.AjoutIngredient(Glaçons);
            r1.AjoutEtape(1, "Pillez les glaçons");
            r1.AjoutEtape(2, "Déposez la menthe juste au fond du verre. ");
            r1.AjoutEtape(3, "Coupez le citron en deux puis chaque demi citron en 6 morceaux. ");
            r1.AjoutEtape(4, "Ajoutez les 6 morceaux de citron dans chaque verre (1/2 citron). ");
            r1.AjoutEtape(5, "Ajoutez le sirop de sucre de canne.");
            r1.AjoutEtape(6, "Ecrasez le citron avec un pilon spécial cocktail.");
            r1.AjoutEtape(7, "Ajoutez la glace pilée en laissant 2 cm de libre. Plus il y a de glace, moins elle fondra rapidement. ");
            r1.AjoutEtape(8, "Ajoutez le rhum. ");
            r1.AjoutEtape(9, "Complétez avec l'eau gazeuse. ");
            r1.AjoutEtape(10, "Mélangez le cocktail afin que les saveur se mêlent.");
            r1.AjoutEtape(11, "Le mojito se sert avec deux pailles qui vont permettre de mélanger le cocktail au fur et à mesure de la dégustation. ");
            Cocktail c1 = new Cocktail("Mojito", "Mojito.png");
            c1.AjoutRecette(r1);
            AllCocktail.Add(c1);
            //FavCocktail.Add(c1);



            Recette r2 = new Recette("Virgin Mojito", (float)0, 175, "le meilleur cocktail du monde mais sans alcool", Niveau.Facile);
            r2.AjoutIngredient(Menthe);
            r2.AjoutIngredient(EauG);
            r2.AjoutIngredient(SiropSucre);
            r2.AjoutIngredient(CitronVert);
            r2.AjoutIngredient(Glaçons);

            r2.AjoutEtape(1, "Pillez les glaçons");
            r2.AjoutEtape(2, "Déposez la menthe juste au fond du verre. ");
            r2.AjoutEtape(3, "Coupez le citron en deux puis chaque demi citron en 6 morceaux. ");
            r2.AjoutEtape(4, "Ajoutez les 6 morceaux de citron dans chaque verre (1/2 citron). ");
            r2.AjoutEtape(5, "Ajoutez le sirop de sucre de canne.");
            r2.AjoutEtape(6, "Ecrasez le citron avec un pilon spécial cocktail.");
            r2.AjoutEtape(7, "Ajoutez la glace pilée en laissant 2 cm de libre. Plus il y a de glace, moins elle fondra rapidement. ");
            r2.AjoutEtape(8, "Complétez avec l'eau gazeuse. ");
            r2.AjoutEtape(9, "Mélangez le cocktail afin que les saveur se mêlent.");
            r2.AjoutEtape(10, "Le mojito se sert avec deux pailles qui vont permettre de mélanger le cocktail au fur et à mesure de la dégustation. ");
            c1.AjoutRecette(r2);

            Cocktail crea = new Cocktail("Le perso");
            Recette maRecette = new Recette("le perso", (float)33.5, 150, "création maison !!, parfait pour une soirée sur la plage, avec des amis ou la famille !", Niveau.Moyen);
            maRecette.AjoutIngredient(new Ingredient("vodka", 4, TypeUnite.Cl));
            maRecette.AjoutIngredient(new Ingredient("sirop de fraise", 1, TypeUnite.Cl));
            maRecette.AjoutIngredient(new Ingredient("sucre", 5, TypeUnite.G));
            maRecette.AjoutIngredient(new Ingredient("jus ananas", 4, TypeUnite.Cl));
            maRecette.AjoutEtape(1, "prennez un verre");
            maRecette.AjoutEtape(2, "versez la vodka dans le verre ");
            maRecette.AjoutEtape(3, " y ajouter le sucre");
            maRecette.AjoutEtape(4, " ajoutez y le jus d'ananas");
            maRecette.AjoutEtape(5, "versez délicatement le sirop, bonne dégustation");
            crea.AjoutRecette(maRecette);

            AllCocktail.Add(crea);
            CreaCocktail.Add(crea);
            FavCocktail.Add(crea);

            Cocktail SOB = new Cocktail("Sex on the beach", "Sexbeach.png");
            Recette SOBrec = new Recette("Sex on the beach", (float)17.5, 160, "Une recette rafraîchissante et sucrée", Niveau.Facile);
            SOBrec.AjoutIngredient(new Ingredient("vodka", 3, TypeUnite.Cl));
            SOBrec.AjoutIngredient(new Ingredient("liqueur de pêche", 3, TypeUnite.Cl));
            SOBrec.AjoutIngredient(new Ingredient("Jus d'ananas", 6, TypeUnite.Cl));
            SOBrec.AjoutIngredient(new Ingredient("Jus de cramberry", 10, TypeUnite.Cl));
            SOBrec.AjoutEtape(1, "Mettez les ingrédients avec quelques glaçons dans un shaker, secouez et versez sur des glaçons dans un verre à long drink.");
            SOBrec.AjoutEtape(2, "secouez et versez sur des glaçons dans un verre à long drink.");
            SOBrec.AjoutEtape(3, "versez sur des glaçons dans un verre à long drink.");
            SOB.AjoutRecette(SOBrec);
            AllCocktail.Add(SOB);
            FavCocktail.Add(SOB);

            Cocktail Margarita= new Cocktail("Margarita", "Margarita.jpg");
            Recette magr1 = new Recette("Marguarita", (float)35, 140 , "La Margarita est un cocktail à base de tequila, inventé par des Américains au Mexique.", Niveau.Facile);
            magr1.AjoutIngredient(new Ingredient("Tequila", 60, TypeUnite.Ml));
            magr1.AjoutIngredient(new Ingredient("citron vert", 30, TypeUnite.Ml));
            magr1.AjoutIngredient(new Ingredient("Cointreau", 30, TypeUnite.Ml));
            magr1.AjoutEtape(1,"frotter le rebord d'un verre avec le citron vert");
            magr1.AjoutEtape(2,"melanger tout les ingrédient avec des glaçons");
            magr1.AjoutEtape(3,"versez dans un verre à cocktail");
            Margarita.AjoutRecette(magr1);
            AllCocktail.Add(Margarita);
            FavCocktail.Add(Margarita);


            Cocktail PinaColada = new Cocktail("Piña Colada", "PinaColada.png");
            Recette p1 = new Recette("Piña Colada", (float)44, 174 ,"Inventé à Porto Rico, ce subtil mélange d'ananas, rhum et coco a fait le tour du monde et séduit toujours les convives. ", Niveau.Moyen);
            p1.AjoutIngredient(new Ingredient("Rhum blanc", 4, TypeUnite.Cl));
            p1.AjoutIngredient(new Ingredient("Rhum ambré", 2, TypeUnite.Cl));
            p1.AjoutIngredient(new Ingredient("Jus d'ananas", 12, TypeUnite.Cl));
            p1.AjoutIngredient(new Ingredient("Lait de coco", 4, TypeUnite.Cl));
            p1.AjoutEtape(1, "Dans un blender (mixer), versez les ingrédients avec 5 ou 6 glaçons et mixez le tout. C'est prêt ! Versez dans le verre et dégustez. Peut aussi se réaliser au shaker si c'est juste pour une personne.");
            p1.AjoutEtape(2, "Servir dans un verre de type \"verre à vin\".");
            p1.AjoutEtape(3, "Décorer avec un morceau d'ananas et une cerise confite.");
            PinaColada.AjoutRecette(p1);
            Recette p2 = new Recette("Piña Colada Royal", (float)44, 174, "Inventé à Porto Rico, ce subtil mélange d'ananas, rhum et coco a fait le tour du monde et séduit toujours les convives. ", Niveau.Facile);
            p2.AjoutIngredient(new Ingredient("Rhum blanc", 6, TypeUnite.Cl));
            p2.AjoutIngredient(new Ingredient("Crème fraîche liquide", 1, TypeUnite.CaSoupe));
            p2.AjoutIngredient(new Ingredient("Sirop d'ananas", 3, TypeUnite.Cl));
            p2.AjoutIngredient(new Ingredient("Sirop de noix de coco", 3, TypeUnite.Cl));
            p2.AjoutEtape(1, "Mixez les ingrédients avec beaucoup de glaçons. Servez.");
            p2.AjoutEtape(2, "Servir dans un verre de type \"verre à dégustation\".");
            PinaColada.AjoutRecette(p2);
            AllCocktail.Add(PinaColada);

            Cocktail spritz = new Cocktail("Spritz", "Spritz.png");
            Recette s1 = new Recette("Spritz", (float)12, 120, "Le spritz est un cocktail alcoolisé largement consommé en apéritif dans les grandes villes de la Vénétie et du Frioul-Vénétie Julienne, et également répandu dans toute l'Italie", Niveau.Facile);
            s1.AjoutIngredient(new Ingredient("Apérol ou Campari", 10, TypeUnite.Cl));
            s1.AjoutIngredient(new Ingredient("Prosecco", 20, TypeUnite.Cl));
            s1.AjoutIngredient(new Ingredient("Eau pétillante", 5, TypeUnite.Cl));
            s1.AjoutIngredient(new Ingredient("Rondelle d'orange", 1, TypeUnite.Unite));
            s1.AjoutEtape(1, "Prenez un verre mieux à pied, mettez en premier 3 ou 4 glaçons et une demi rondelle d’orange.");
            s1.AjoutEtape(2, "Versez ensuite l'Apérol ou de Campari.");
            s1.AjoutEtape(3, "Puis le Prosecco et enfin un trait d’eau gazeuse.");
            s1.AjoutEtape(4, "Plongez une cuillère au fond du verre pour faire remonter délicatement l’Apérol ou le Campari. Un bon mélange sans perdre les bulles permettra à votre Spritz d’être mieux équilibré.");
            spritz.AjoutRecette(s1);
            AllCocktail.Add(spritz);

            Cocktail Lsc = new Cocktail("Le Soleil Couchant");
            Recette lsc1 = new Recette("Le soleil couchant");
            lsc1.AjoutIngredient(new Ingredient("Malibu", 6 , TypeUnite.Cl));
            lsc1.AjoutIngredient(new Ingredient("Jus d'ananas",12 , TypeUnite.Cl));
            lsc1.AjoutIngredient(new Ingredient("Sirop de grenadine", 2, TypeUnite.Cl));
            lsc1.AjoutIngredient(new Ingredient("Eau pétillante", 10, TypeUnite.Cl));
            lsc1.AjoutEtape(1, "Mettre quelques glaçons dans un verre a cocktail.");
            lsc1.AjoutEtape(2, "Y ajouter le Malibu et le jus d'ananas.");
            lsc1.AjoutEtape(3, "Puis verser doucement le sirop dans le verre.");
            lsc1.AjoutEtape(4, "Compléter avec l'eau gazeuse.");
            Lsc.AjoutRecette(lsc1);
            AllCocktail.Add(Lsc);
            CreaCocktail.Add(Lsc);

            Cocktail BlueLag = new Cocktail("Blue Lagoon", "Cocktail-blue-lagoon.png");
            Recette BL1 = new Recette("Blue Lagoon", (float)37.5, 168, "Le Blue Lagoon est un cocktail à base de vodka, de curaçao bleu et de jus de citron. Il est aussi appelé le « lagon bleu » par sa traduction. Il fut créé par Andy MacElhone au Harry's New York Bar à Paris, en 1960.", Niveau.Facile);
            BL1.AjoutIngredient(new Ingredient("Vodka", 4, TypeUnite.Cl));
            BL1.AjoutIngredient(new Ingredient("Curaçao bleu", 3, TypeUnite.Cl));
            BL1.AjoutIngredient(new Ingredient("Jus de citron", 2, TypeUnite.Cl));
            BL1.AjoutEtape(1, "Pressez le jus d'un demi-citron, ajoutez dans le shaker avec les autres ingrédients et des glaçons.");
            BL1.AjoutEtape(2, "Frappez puis versez dans le verre en filtrant.");
            BL1.AjoutEtape(3, "Servir dans un verre de type \"verre à martini\"");
            BlueLag.AjoutRecette(BL1);
            AllCocktail.Add(BlueLag);
            FavCocktail.Add(BlueLag);


            return (AllCocktail, FavCocktail, CreaCocktail);
        }

        //L'enregistrement est là mais ne fait rien car c'est un stub 
        public void Enregistrement(IEnumerable<Cocktail> AllCocktail, IEnumerable<Cocktail> FavCocktail, IEnumerable<Cocktail> CreaCoctkail) {
            Debug.WriteLine("sauvegarde demandé");
        }
    }
}


/*
 ************************ STUB TEMPLATE ******************************************************
 * Cocktail ** = new Cocktail("", "");
            Recette ** = new Recette("", (float), , "", Niveau.Moyen);
            **.AjoutIngredient(new Ingredient());
            **.AjoutEtape();
            **.AjoutRecette(**);
 
 */