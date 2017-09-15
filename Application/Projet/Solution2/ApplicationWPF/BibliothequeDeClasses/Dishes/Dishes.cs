using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace BibliothequeDeClasses
{
    /// <summary>
    /// Classe Dishes qui implémente l'interface IDishes pour empêcher l'instanciation en dehors du modèle ainsi que INotifyPropertyChanged.
    /// </summary> 
    [DataContract]
    public class Dishes : INotifyPropertyChanged, IDishes
    {
        /// <summary>
        /// Déclare une string correspondant au nom du plat pour la NPC.
        /// </summary> 
        private String _Name;

        /// <summary>
        /// Déclare une propriété correspondant au nom du plat.
        /// DataMember crée sur la propriété.
        /// </summary> 
        [DataMember(Name = "Name", Order = 0)]
        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Déclare une string correspondant à la catégorie du plat pour la NPC.
        /// </summary> 
        private String _Categ;


        /// <summary>
        /// Déclare une propriété correspondant à la catégorie du plat.
        /// DataMember crée sur la propriété.
        /// </summary>
        [DataMember(Name = "Categ", Order = 1)]
        public String Categ
        {
            get
            {
                return _Categ;
            }
            set
            {
                _Categ = value;
                OnPropertyChanged("Categ");
            }
        }

        /// <summary>
        /// Déclare une propriété correspondant à la recette du plat pour la NPC.
        /// </summary> 
        private String _Recipe;

        /// <summary>
        /// Déclare une propriété correspondant à la recette du plat.
        /// DataMember crée sur la propriété.
        /// </summary> 
        [DataMember(Name = "Recipe", Order = 2)]
        public String Recipe
        {
            get
            {
                return _Recipe;
            }
            set
            {
                _Recipe = value;
                OnPropertyChanged("Recipe");
            }
        }

        /// <summary>
        /// Déclare une propriété correspondant au chemin de l'image du plat pour la NPC.
        /// </summary> 
        private Uri _Pathimg;

        /// <summary>
        /// Déclare une propriété correspondant au chemin de l'image du plat.
        /// DataMember crée sur la propriété.
        /// </summary> 
        [DataMember(Name = "Pathimg", Order = 3)]
        public Uri Pathimg
        {
            get
            {
                return _Pathimg;
            }
            set
            {
                _Pathimg = value;
                OnPropertyChanged("Pathimg");
            }
        }

        /// <summary>
        /// Déclare une observable collection correspondant à la liste d'ingrédients du plat.
        /// DataMember crée sur la propriété.
        /// </summary> 
        [DataMember(Name = "Ing", Order = 4)]
        public ObservableCollection<Ingredients> Ing { get; set; }

        /// <summary>
        /// Déclare une une observable collection correspondant à la liste d'outils du plat.
        /// DataMember crée sur la propriété.
        /// </summary> 
        [DataMember(Name = "Outils", Order = 5)]
        public ObservableCollection<Tools> Outils { get; set; }

        /// <summary>
        /// Méthode protected OnPropertyChanged, prenant en paramètre une string. Lance l'event de changement de la variable en paramètre.
        /// </summary> 
        protected void OnPropertyChanged(string name)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        /// <summary>
        /// Constructeur par défaut, de base.
        /// </summary> 
        internal Dishes(String name, String cate, String Rec, Uri pathimg)
        {
            this.Name = name;
            this.Categ = cate;
            this.Recipe = Rec;
            this.Pathimg = pathimg;

            Ing = new ObservableCollection<Ingredients>();
            Outils = new ObservableCollection<Tools>();
        }

        /// <summary>
        /// Constructeur simplifié prenant en paramètre directement les listes d'outils et d'ingrédients.
        /// </summary> 
        internal Dishes(String name, String cat, String Rec, Uri pathimg, ObservableCollection<Ingredients> Ing, ObservableCollection<Tools> Outils)
        {
            this.Name = name;
            this.Categ = cat;
            this.Recipe = Rec;
            this.Pathimg = pathimg;
            this.Ing = Ing;
            this.Outils = Outils;
        }

        /// <summary>
        /// Evenement de changement de la variable.
        /// </summary> 
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Méthode qui ajoute un ingrédient ingr à la liste.
        /// </summary> 
        public void addIngredients(Ingredients ingr)
        {
                Ing.Add(ingr);
        }

        /// <summary>
        /// Méthode qui supprime un ingrédient ingr de la liste.
        /// </summary> 
        public void removeIngredients(Ingredients ingr)
        {
            Ing.Remove(ingr);
        }

        /// <summary>
        /// Méthode qui ajoute un outil t à la liste.
        /// </summary> 
        public void addTools(Tools t)
        {
            Outils.Add(t);
        }

        /// <summary>
        /// Méthode qui supprime un outil t de la liste.
        /// </summary> 
        public void removeTools(Tools t)
        {
            Outils.Remove(t);
        }

        /// <summary>
        /// Retourne la chaîne de caractère de l'objet comme souhaité.
        /// </summary> 
        public override string ToString()
        {
            return "- " + Name + " - " + Categ;
        }

        /// <summary>
        /// Redéfinition de la méthode Equals dans le cadre des plats avec un objet o en paramètre.
        /// </summary> 
        public override bool Equals(object o)
        {
            if (o == null)
            {
                return false;
            }
            if (!(o is Dishes))
            {
                return false;
            }
            return Equals((Dishes)o);
        }

        /// <summary>
        /// Redéfinition de la méthode Equals dans le cadre des plats avec un Dishes other en paramètre.
        /// </summary> 
        public bool Equals(Dishes other)
        {
            if ((object)other == null)
            {
                if ((object)this == null)
                {
                    return true;
                }
                return false;
            }
            return (this.Name.Equals(other.Name) && this.Categ.Equals(other.Categ));
        }

        /// <summary>
        /// Redéfinition de la méthode GetHashCode() dans le cadre des observable collection.
        /// </summary> 
        public override int GetHashCode()
        {
            return 1;
        }

        /// <summary>
        /// Définition de la méthode CompareTo car implémenté dans l'interface IDishes.
        /// </summary> 
        public int CompareTo(IDishes obj)
        {
            int comp = Name.CompareTo(obj.Name);
            if(comp != 0)
            {
                return comp;
            }

            return Categ.CompareTo(obj.Categ);
        }
    }
}
