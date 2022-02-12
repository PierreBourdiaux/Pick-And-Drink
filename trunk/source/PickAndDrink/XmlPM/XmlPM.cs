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
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace XmlPM
{

    /// <summary>
    /// Stratégie concrète de persistance en XML
    /// </summary>
    public class XmlPM : IPersManager
    {
        //chemin relatif du fichier 
        public string FilePath { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "PickAndDrink_XML");
        //nom du fichier 
        public string FileName { get; set; } = "PickAndDrink_Data.xml";

        //combinaison du chemin et du nom du fichier 
        string PersFile => Path.Combine(FilePath, FileName);

        private DataContractSerializer Serializer = new DataContractSerializer(typeof(DataPersist),
                                                             new DataContractSerializerSettings()
                                                             {       
                                                                 PreserveObjectReferences = true
                                                             }) ;

        // methode de deserialisation du fichier de persistance 
        public (IEnumerable<Cocktail>, IEnumerable<Cocktail>, IEnumerable<Cocktail>) Chargement()
        {
            // on verifie si le fichier existe 
            if (!File.Exists(PersFile))
            {
                throw new FileNotFoundException("le fichier de persistance n'existe pas");
                
            }

           

            DataPersist data;

            // on lis le fichier 
            using (Stream s = File.OpenRead(PersFile))
            {
                data = Serializer.ReadObject(s) as DataPersist;
            }

            return (data.allCocktail, data.favCocktail, data.creaCocktail);
        }


        // methode de serialisation des listes de cocktails 
        public void Enregistrement(IEnumerable<Cocktail> AllCocktail, IEnumerable<Cocktail> FavCocktail, IEnumerable<Cocktail> CreaCoctkail)
        {
            // on verifie que le repertoire existe
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }


            DataPersist data = new DataPersist();
            data.allCocktail.AddRange(AllCocktail);
            data.favCocktail.AddRange(FavCocktail);
            data.creaCocktail.AddRange(CreaCoctkail);

            var settings = new XmlWriterSettings()
            {
                Indent = true, // pour que le fichier soit indenté et donc lisible 
                
            };

            // serialisation
            using(TextWriter tw = File.CreateText(PersFile))
            {
                using (XmlWriter writer = XmlWriter.Create(tw, settings))
                {
                    Serializer.WriteObject(writer, data);
                } 
            }

            
        }
    }
}
