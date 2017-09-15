using System;

namespace BibliothequeDeClasses
{
    /// <summary>
    /// Classe IngredientsMaker, permettant de générer des ingrédients.
    /// </summary> 
    public class IngredientsMaker
    {
        /// <summary>
        /// Retourne l'instanciation d'un nouvel ingrédient.
        /// </summary> 
        public static Ingredients MakeIngredients(String nom, int nb)
        {
            return new Ingredients(nom, nb);
        }
    }
}
