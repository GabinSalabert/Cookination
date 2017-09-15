using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BibliothequeDeClasses
{
    [DataContract]
    public class Ingredients : Composant
    {
        //On spécifie bien que le constructeur a pour base celui de la classe abstraite.
        public Ingredients(string nom, int nb) :base(nom, nb){}

        //Ajoute un outil au plat d.
        public override void add(Dishes d)
        {
            d.addIngredients(this);
        }

        //Supprime un outil au plat d.
        public override void delete(Dishes d)
        {
            d.removeIngredients(this);
        }

        public override string ToString()
        {
            return "- " + Nom + "- " + Nb;
        }

        public override bool Equals(object o)
        {
            if (!(o is Ingredients))
            {
                return false;
            }
            return Equals((Ingredients)o);
        }

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

        public override int GetHashCode()
        {
            return Nb;
        }

    } 
}
