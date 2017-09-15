using System;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace BibliothequeDeClasses
{
    public class DishesMaker
    {
        public static IDishes MakeDishes(String name, String cate, String Rec, Uri pathimg)
        {
            if (name.Length < 3)
                throw new FormatException("Nom trop court");
            if(!Regex.IsMatch(name, "[a-zA-Z]"))
                throw new FormatException("Veuillez rentrer des lettres");
            return new Dishes(name, cate, Rec, pathimg);
        }

        public static IDishes MakeDishes(String name, String cat, String Rec, Uri pathimg, ObservableCollection<Ingredients> Ing, ObservableCollection<Tools> Outils)
        {
            return new Dishes(name, cat, Rec, pathimg, Ing, Outils);
        }
    }
}
