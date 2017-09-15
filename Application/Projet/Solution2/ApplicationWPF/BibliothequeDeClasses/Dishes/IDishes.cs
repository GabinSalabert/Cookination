using System;
using System.Collections.ObjectModel;
namespace BibliothequeDeClasses
{
    /// <summary>
    /// Interface implémentée par Dishes pour empêcher l'instanciation en dehors du modèle et qui implémente elle même IComparable.
    /// </summary> 
    public interface IDishes : IComparable<IDishes>
    {
        /// <summary>
        /// Déclare une propriété correspondant au nom du plat.
        /// </summary> 
        String Name { get; set; }

        /// <summary>
        /// Déclare une propriété correspondant à la catégorie du plat.
        /// </summary> 
        String Categ { get; set; }

        /// <summary>
        /// Déclare une propriété correspondant à la recette du plat.
        /// </summary> 
        String Recipe { get; set; }

        /// <summary>
        /// Déclare une propriété correspondant au chemin de l'image du plat.
        /// </summary> 
        Uri Pathimg { get; set; }

        /// <summary>
        /// Déclare une propriété correspondant à la liste d'ingrédient du plat.
        /// </summary> 
        ObservableCollection<Ingredients> Ing { get; set; }

        /// <summary>
        /// Déclare une propriété correspondant à la liste d'outil du plat.
        /// </summary> 
        ObservableCollection<Tools> Outils { get; set; }
    }
}
