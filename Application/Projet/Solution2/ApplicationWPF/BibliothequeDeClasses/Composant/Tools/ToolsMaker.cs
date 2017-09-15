using System;

namespace BibliothequeDeClasses
{
    /// <summary>
    /// Classe ToolsMaker, permettant de générer des outils.
    /// </summary> 
    public class ToolsMaker
    {
        /// <summary>
        /// Retourne l'instanciation d'un nouvel outil.
        /// </summary> 
        public static Tools MakeTools(String nom, int nb)
        {
            return new Tools(nom, nb);
        }
    }
}
