using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BibliothequeDeClasses;
using Facade;
using static System.Console;

namespace ApplicationConsole
{
    /// <summary>
    /// Logique d'interaction pour WindowEdit.xaml.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Tests unitaires.
        /// </summary>
        static void Main(string[] args)
        {
            DishesGlobFacade.LoadD();

            IDishes myDishes = DishesMaker.MakeDishes("Carpaccio Melon-Comcombre", "Régime", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("../Pictures/Carpaccio.jpg", UriKind.RelativeOrAbsolute));

            Ingredients ing = IngredientsMaker.MakeIngredients("Sel", 4);

            Tools tl = ToolsMaker.MakeTools("Moule", 666);

            WriteLine(myDishes);

            WriteLine(ing);

            WriteLine(tl);

        }
    } 
}
