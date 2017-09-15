using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace BibliothequeDeClasses 
{
    /// <summary>
    /// Cette classe contient une collection de tous les Dishes.
    /// </summary>    
    [DataContract]
    public class DishesGlob
    {
        /// <summary>
        /// Déclare une observable collection de plats.
        /// </summary> 
        [DataMember(Name = "mDishes", Order = 0)]
        public ObservableCollection<IDishes> mDishesG { get; set; }

        /// <summary>
        /// Instancie un DishesGlob à partir d'un IEnumerable et une observable collection de plats..
        /// </summary>            
        public DishesGlob(IEnumerable<IDishes> dishes)
        {
            mDishesG = new ObservableCollection<IDishes>(dishes);
        }

        /// <summary>
        /// Instancie un DishesGlob prenant en paramètre une observable collection de plats.
        /// </summary>  
        public DishesGlob(ObservableCollection<IDishes> mDishesG)
        {
            this.mDishesG = mDishesG;
        }


        /// <summary>
        /// requêtes Linq permettant de rechercher dans la liste de plats de différentes façons.
        /// </summary>  
        public DishesGlob Filter(string carac, string input)
        {
            switch (carac)
            {
                case "Name":
                    return new DishesGlob(mDishesG.Where(x => Regex.IsMatch(x.Name, input, RegexOptions.IgnoreCase)));
                case "":
                    return null;
                default: return new DishesGlob(mDishesG.Where(x => Regex.IsMatch(x.Categ, carac, RegexOptions.IgnoreCase)));
            }
        }


        /// <summary>
        /// Instancie un DishesGlob à partir d'un IEnumerable et une observable collection de plats..
        /// </summary>  
        public DishesGlob SortD()
        {
            return new DishesGlob(mDishesG.OrderBy(i => i));
        }
    }
}
