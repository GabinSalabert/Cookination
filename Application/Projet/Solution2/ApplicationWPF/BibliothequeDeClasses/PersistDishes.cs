using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Reflection;

namespace BibliothequeDeClasses
{
    public class PersistDishes
    {
        static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Cookination");

        //Permet de créer le fichier si il n'est pas déjà existant à l'endroit souhaité.
        //Je set aussi le CurrentDirectory dans le fichier %appdata% de chaque utilisateurs.
        public static void SetCurrentDirectory(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            Directory.SetCurrentDirectory(path);            
        }

        //On vérifie que le fichier existe bien sans oublier de set le bon path. Puis on le lis.
        public static DishesGlob Deserialize()
        {
            SetCurrentDirectory(path);
            if (!File.Exists("MyDishes.xml"))
                return null;
            var Serializer = new DataContractSerializer(typeof(DishesGlob));
            using (XmlReader reader = XmlReader.Create("MyDishes.xml"))
            {
                Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
                return (DishesGlob)Serializer.ReadObject(reader);
            }
        }

        //On sauvegarde les données dans un fichier XML.
        public static void Serialize(DishesGlob AllDishes)
        {
            SetCurrentDirectory(path);
            var Serializer = new DataContractSerializer(typeof(DishesGlob));
            using (XmlWriter writer = XmlWriter.Create("MyDishes.xml", new XmlWriterSettings() { Indent = true }))
                Serializer.WriteObject(writer, AllDishes);
        }
    }
}