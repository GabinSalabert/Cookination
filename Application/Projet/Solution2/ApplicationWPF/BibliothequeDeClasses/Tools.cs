using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

//Hérite de la classe abstraite "Composants"
namespace BibliothequeDeClasses
{
    [DataContract]
    public class Tools : Composant
    {
        //On spécifie bien que le constructeur a pour base celui de la classe abstraite.
        public Tools(string nom, int nb) :base(nom, nb){ }

        //Ajoute un outil au plat d.
        public override void add(Dishes d)
        {
            d.addTools(this);
        }

        //Supprime un outil au plat d.
        public override void delete(Dishes d)
        {
            d.removeTools(this);
        }

        public override string ToString()
        {
            return "- " + Nom + "- " + Nb;
        }

        public override bool Equals(object o)
        {
            if (!(o is Tools))
            {
                return false;
            }
            return Equals((Tools)o);
        }

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

        public override int GetHashCode()
        {
            return Nb;
        }
    }
}
