using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BibliothequeDeClasses
{
    /// <summary>
    /// Classe abstraite Composant, implémentant INotifyPropertyChanged.
    /// </summary>
    [DataContract]
    public abstract class Composant : INotifyPropertyChanged
    {
        /// <summary>
        /// Déclare une string correspondant au nom du composant pour la NPC.
        /// </summary> 
        private string _Nom;

        /// <summary>
        /// Déclare une string correspondant au nom du composant.
        /// On précise le DataMember pour la sérialization.
        /// </summary> 
        [DataMember(Name = "Nom", Order = 0)]
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

        /// <summary>
        /// Déclare un int correspondant au nb de composants pour la NPC.
        /// </summary>
        private int _Nb;

        /// <summary>
        /// Déclare un int correspondant au nb de composants.
        /// On précise le DataMember pour la sérialization.
        /// </summary> 
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

        /// <summary>
        /// Méthode protected OnPropertyChanged, prenant en paramètre une string. Lance l'event de changement de la variable en paramètre.
        /// </summary> 
        protected void OnPropertyChanged(string nb)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nb));

        /// <summary>
        /// Constructeur par défaut, de base.
        /// </summary> 
        internal Composant(string nom, int nb)
        {
            this.Nom = nom;
            this.Nb = nb;
        }

        /// <summary>
        /// Evenement de changement de la variable.
        /// </summary> 
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Méthode qui ajoute un plat d à la liste.
        /// </summary> 
        public abstract void add(Dishes d);

        /// <summary>
        /// Méthode qui supprime un plat d de la liste.
        /// </summary> 
        public abstract void delete(Dishes d);
    }
}
