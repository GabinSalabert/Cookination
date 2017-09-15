using BibliothequeDeClasses;
using Stub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /// <summary>
    ///Permet à la vue de ne pas gérer des instances du modèle.
    /// </summary>
    public class DishesGlobFacade
    {
        /// <summary>
        /// Propriété static d'une observable collection de plats.
        /// </summary>
        public static DishesGlob AllDishes { get; set; }

        /// <summary>
        /// Chargement des données dans l'OC.
        /// </summary>
        public static void LoadD()
        {
            AllDishes = ReferenceEquals(PersistDishes.Deserialize(), null) ? Stubb.LoadDishes() : PersistDishes.Deserialize();
        }
    }
}
