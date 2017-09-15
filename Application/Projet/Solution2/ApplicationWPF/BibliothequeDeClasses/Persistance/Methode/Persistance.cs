using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace BibliothequeDeClasses
{
    /// <summary>
    ///On sauvegarde les données dans un fichier XML grâce aux DataContract.
    /// </summary>
    public abstract class Persistance
    {
        static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Cookination");

        /// <summary>
        ///Permet de créer le fichier si il n'est pas déjà existant à l'endroit souhaité.
        /// </summary>
        public static void SetCurrentDirectory()
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            Directory.SetCurrentDirectory(path);
        }

        /// <summary>
        /// Lis dans le fichier XML ou return null si il n'existe pas.
        /// </summary>
        public static DishesGlob DeserializeDishes(string file, DataContractSerializer Serializer)
        {
            if (!File.Exists("MyDishes.xml"))
                return null;
            using (XmlReader reader = XmlReader.Create(file))
                return (DishesGlob)Serializer.ReadObject(reader);
        }

        /// <summary>
        /// Ecris dans le fichier XML.
        /// </summary>
        public static void SerializeDishes(string file, DataContractSerializer Serializer, DishesGlob AllDishes)
        {
            using (XmlWriter writer = XmlWriter.Create("MyDishes.xml", new XmlWriterSettings() { Indent = true }))
                Serializer.WriteObject(writer, AllDishes);
        }
    }
}
