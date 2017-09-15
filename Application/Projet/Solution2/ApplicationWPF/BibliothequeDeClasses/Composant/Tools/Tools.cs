using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

//Hérite de la classe abstraite "Composants"
namespace BibliothequeDeClasses
{
    /// <summary>
    /// Classe Tools, qui hérite de Composant.
    /// </summary> 
    [DataContract]
    public class Tools : Composant
    {
        /// <summary>
        ///On spécifie bien que le constructeur a pour base celui de la classe abstraite.
        /// </summary> 
        internal Tools(string nom, int nb) :base(nom, nb){ }

        /// <summary>
        ///Ajoute un outil au plat d.
        /// </summary> 
        public override void add(Dishes d)
        {
            d.addTools(this);
        }

        /// <summary>
        ///Supprime un outil au plat d.
        /// </summary> 
        public override void delete(Dishes d)
        {
            d.removeTools(this);
        }

        /// <summary>
        /// Retourne la chaîne de caractère de l'objet comme souhaité.
        /// </summary> 
        public override string ToString()
        {
            return $"- {Nom} {Nb}\n";
        }

        /// <summary>
        /// Redéfinition de la méthode Equals dans le cadre des outils avec un objet o en paramètre.
        /// </summary> 
        public override bool Equals(object o)
        {
            if (!(o is Tools))
            {
                return false;
            }
            return Equals((Tools)o);
        }

        /// <summary>
        /// Redéfinition de la méthode Equals dans le cadre des outils avec un outil other en paramètre.
        /// </summary> 
        public bool Equals(Tools other)
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
