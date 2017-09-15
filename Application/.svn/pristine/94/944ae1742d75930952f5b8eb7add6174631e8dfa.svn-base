using System;
using System.Runtime.Serialization;

namespace BibliothequeDeClasses
{
    /// <summary>
    /// Classe PersistDishes qui hérite de la classe abstraite Persistance.
    /// </summary>
    public class PersistDishes : Persistance
    {
        /// <summary>
        ///On vérifie que le fichier existe bien sans oublier de set le bon path. Puis on le lis.
        /// </summary> 
        public static DishesGlob Deserialize()
        {
            SetCurrentDirectory();
            return DeserializeDishes("MyDishes.xml", new DataContractSerializer(typeof(DishesGlob), new Type[] { typeof(Dishes), typeof(Ingredients), typeof(Tools) })); 
        }

        /// <summary>
        ///On sauvegarde les données dans un fichier XML.
        /// </summary> 
        public static void Serialize(DishesGlob AllDishes)
        {
            SetCurrentDirectory();
            SerializeDishes("MyDishes.xml", new DataContractSerializer(typeof(DishesGlob), new Type[] { typeof(Dishes), typeof(Ingredients), typeof(Tools) }), AllDishes);
        }
    }
}