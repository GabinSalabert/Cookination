using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BibliothequeDeClasses
{
    /// <summary>
    /// Classe Ingrédients, qui hérite de Composant.
    /// </summary> 
    [DataContract]
    public class Ingredients : Composant
    {
        /// <summary>
        ///On spécifie bien que le constructeur a pour base celui de la classe abstraite.
        /// </summary> 
        internal Ingredients(string nom, int nb) :base(nom, nb){}

        /// <summary>
        ///Ajoute un ingrédient au plat d.
        /// </summary> 
        public override void add(Dishes d)
        {
            d.addIngredients(this);
        }

        /// <summary>
        ///Supprime un ingrédient au plat d.
        /// </summary> 
        public override void delete(Dishes d)
        {
            d.removeIngredients(this);
        }

        /// <summary>
        /// Retourne la chaîne de caractère de l'objet comme souhaité.
        /// </summary> 
        public override string ToString()
        {
            return "- " + Nom + "- " + Nb;
        }

        /// <summary>
        /// Redéfinition de la méthode Equals dans le cadre des ingrédients avec un objet o en paramètre.
        /// </summary> 
        public override bool Equals(object o)
        {
            if (!(o is Ingredients))
            {
                return false;
            }
            return Equals((Ingredients)o);
        }

        /// <summary>
        /// Redéfinition de la méthode Equals dans le cadre des ingrédients avec un ingrédient other en paramètre.
        /// </summary> 
        public bool Equals(Ingredients other)
        {
            if ((object)other == null)
            {
                if ((object)this == null)
                {
                    return true;
                }
                return false;
            }
            return (this.Nom.Equals(other.Nom) && this.Nb.Equals(other.Nb));
        }

        /// <summary>
        /// Redéfinition de la méthode GetHashCode() dans le cadre des observable collection.
        /// </summary> 
        public override int GetHashCode()
        {
            return Nb;
        }

    } 
}
