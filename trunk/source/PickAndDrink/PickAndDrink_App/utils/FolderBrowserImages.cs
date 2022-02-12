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

using PickAndDrink_App.converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PickAndDrink_App.utils
{

    /// <summary>
    /// Classe qui permet de faire un File Browser
    /// </summary>
    class  FolderBrowserImages
    {
        // fonction qui permet de faire la fenetre, choisir l'image et retourner le nom 
        public static string ChoixImage()
        {
            // Configure open file dialog box
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures";
            dlg.FileName = "Images"; // Default file name
            dlg.DefaultExt = ".jpg | .png | .gif"; // Default file extension
            dlg.Filter = "All images files (.jpg, .png, .gif)|*.jpg;*.png;*.gif|JPG files (.jpg)|*.jpg|PNG files (.png)|*.png|GIF files (.gif)|*.gif"; // Filter files by extension 

            // Show open file dialog box
            bool? result = dlg.ShowDialog();

            // Process open file dialog box results 
            if (result != true)
            {
                return null;
            }
            // Open document 
            FileInfo fi = new FileInfo(dlg.FileName);
                string filename = fi.Name;
                int i = 0;
                while(File.Exists(System.IO.Path.Combine(String2ImageConverter.ImagesPath,filename))) // sert à ne pas avoir de doublons dans le nom des images
                {
                    filename = $"{fi.Name.Remove(fi.Name.LastIndexOf('.'))}_{i}.{fi.Extension}";
                    i++;
                }
                File.Copy(dlg.FileName, System.IO.Path.Combine(String2ImageConverter.ImagesPath, filename)); // copie de l'image dans le dossier d'image des cocktails 
                return filename;
            
        }
    }
}
