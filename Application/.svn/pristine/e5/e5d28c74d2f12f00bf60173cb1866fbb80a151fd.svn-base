using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BibliothequeDeClasses
{
    [DataContract]
    public abstract class Composant : INotifyPropertyChanged
    {
        //On set bien toutes les propriétés en PropertyChanged afin que tout.
        //Aussi on spécifie le dataContract et les dataMemmbers pour qu'ils soient pris en compte dans la sérialization.
        [DataMember(Name = "Nom", Order = 0)]
        private string _Nom;
        public string Nom
        {
            get
            {
                return _Nom;
            }
            set
            {
                _Nom = value;
                OnPropertyChanged("Nom");
            }
        }

        private int _Nb;
        [DataMember(Name = "Nb", Order = 1)]
        public int Nb
        {
            get
            {
                return _Nb;
            }
            set
            {
                _Nb = value;
                OnPropertyChanged("Nb");
            }
        }

        protected void OnPropertyChanged(string nb)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nb));

        public Composant(string nom, int nb)
        {
            this.Nom = nom;
            this.Nb = nb;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //Ajoute un plat.
        public abstract void add(Dishes d);

        //Supprime un plat.
        public abstract void delete(Dishes d);
    }
}
