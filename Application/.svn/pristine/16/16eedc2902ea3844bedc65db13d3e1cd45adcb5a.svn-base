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
    [DataContract]
    public class Dishes : INotifyPropertyChanged, IComparable<Dishes>
    {
        //On set bien toutes les propriétés en PropertyChanged afin que tout.
        //Aussi on spécifie le dataContract et les dataMemmbers pour qu'ils soient pris en compte dans la sérialization.
        private String _Name;
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

        private String _Categ;
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

        private String _Recipe;
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

        private Uri _Pathimg;
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

        [DataMember(Name = "Ing", Order = 4)]
        public ObservableCollection<Ingredients> Ing { get; set; }

        [DataMember(Name = "Outils", Order = 5)]
        public ObservableCollection<Tools> Outils { get; set; }

        protected void OnPropertyChanged(string name)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        //Constructeur de base.
        public Dishes(String name, String cate, String Rec, Uri pathimg)
        {
            this.Name = name;
            this.Categ = cate;
            this.Recipe = Rec;
            this.Pathimg = pathimg;

            Ing = new ObservableCollection<Ingredients>();
            Outils = new ObservableCollection<Tools>();
        }

        //Constructeur facilitant la création de plats dans l'application.
        public Dishes(String name, String cat, String Rec, Uri pathimg, ObservableCollection<Ingredients> Ing, ObservableCollection<Tools> Outils)
        {
            this.Name = name;
            this.Categ = cat;
            this.Recipe = Rec;
            this.Pathimg = pathimg;
            this.Ing = Ing;
            this.Outils = Outils;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //Ajoute un ingrédient ingr dans l'obsevable collection.
        public void addIngredients(Ingredients ingr)
        {
                Ing.Add(ingr);
        }

        //Supprime un ingrédient ingr dans l'observable collection.
        public void removeIngredients(Ingredients ingr)
        {
            Ing.Remove(ingr);
        }

        //Ajoute un outil t dans l'obsevable collection.
        public void addTools(Tools t)
        {
            Outils.Add(t);
        }

        //Supprime un outil t dans l'observable collection.
        public void removeTools(Tools t)
        {
            Outils.Remove(t);
        }

        public override string ToString()
        {
            return "- " + Name + "- " + Categ;
        }

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

        public override int GetHashCode()
        {
            return 1;
        }

        public int CompareTo(Dishes obj)
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
