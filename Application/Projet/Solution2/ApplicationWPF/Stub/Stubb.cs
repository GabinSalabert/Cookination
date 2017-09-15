using BibliothequeDeClasses;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Stub
{
    /// <summary>
    /// Mon stub.
    /// </summary>
    public class Stubb
    {
        /// <summary>
        /// Méthode qui charge les données dans une OC.
        /// </summary>
        public static DishesGlob LoadDishes()
        {
            /// <summary>
            /// On instancie l'observable collection de plat. Puis on crée toutes les instances de plats, d'outils et d'ingrédients afin de les lui ajouter.
            /// Ce stub sera chargé par défaut si aucun fichier XML n'est trouvé dans %appdata%.
            /// </summary>
            ObservableCollection<IDishes> list = new ObservableCollection<IDishes>()
            {
                DishesMaker.MakeDishes("Carpaccio Melon-Comcombre", "Régime", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("../Pictures/Carpaccio.jpg", UriKind.RelativeOrAbsolute)),
                DishesMaker.MakeDishes("Hachis Parmentier", "Rapides", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("../Pictures/Hachis.jpg", UriKind.RelativeOrAbsolute)),
                DishesMaker.MakeDishes("Tajine", "Etranger", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("../Pictures/Tajine.jpeg", UriKind.RelativeOrAbsolute)),
                DishesMaker.MakeDishes("Risotto au pesto et petits pois", "Nutritionnel", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("../Pictures/Risotto.jpg", UriKind.RelativeOrAbsolute)),
                DishesMaker.MakeDishes("Salade de pâtes au thon", "Prise de masse", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("../Pictures/PatesThon.jpg", UriKind.RelativeOrAbsolute)),
                DishesMaker.MakeDishes("Filet de cabillau en papillote", "Léger", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("../Pictures/Cabillaud.jpeg", UriKind.RelativeOrAbsolute)),
                DishesMaker.MakeDishes("Spaghettis bolognaises", "Plaisir", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("../Pictures/Spaghettis.jpg", UriKind.RelativeOrAbsolute)),
                DishesMaker.MakeDishes("Galettes de légumes", "Légumes", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("../Pictures/Galettes.jpeg", UriKind.RelativeOrAbsolute)),
                DishesMaker.MakeDishes("Poulet laqué au miel", "Sucré-Salé", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("../Pictures/Poulet.jpg", UriKind.RelativeOrAbsolute)),
                DishesMaker.MakeDishes("Serpent", "Bio", "Vider le serpent.\nAjouter 42 grammes de sucre puis 1024g de farine.\nGarnissez avec un zeste BONUS de citron et laisser cuire a 666 degrés.", new Uri("../Pictures/Serp.jpg", UriKind.RelativeOrAbsolute))
        };

            list.ElementAt(0).Ing = new ObservableCollection<Ingredients>()
            {
                IngredientsMaker.MakeIngredients("Sel", 4),
                IngredientsMaker.MakeIngredients("Poivre", 12),
                IngredientsMaker.MakeIngredients("Miel+", 1)
            };
            list.ElementAt(0).Outils = new ObservableCollection<Tools>()
            {
                ToolsMaker.MakeTools("Moule", 666),
                ToolsMaker.MakeTools("Four", 5),
                ToolsMaker.MakeTools("Mixeur", 2),
                ToolsMaker.MakeTools("Cactus", 18),
            };

            list.ElementAt(1).Ing = new ObservableCollection<Ingredients>()
            {
                IngredientsMaker.MakeIngredients("Sel", 2),
                IngredientsMaker.MakeIngredients("Carottes", 10),
                IngredientsMaker.MakeIngredients("Olives", 4)
            };
            list.ElementAt(1).Outils = new ObservableCollection<Tools>()
            {
                ToolsMaker.MakeTools("Poele", 1),
                ToolsMaker.MakeTools("Casserole", 2)
            };

            list.ElementAt(2).Ing = new ObservableCollection<Ingredients>()
            {
                IngredientsMaker.MakeIngredients("Chocolat", 4)
            };
            list.ElementAt(2).Outils = new ObservableCollection<Tools>()
            {
               ToolsMaker.MakeTools("edézd", 666),
               ToolsMaker.MakeTools("Four", 5),
               ToolsMaker.MakeTools("Mixeur", 2)
            };

            list.ElementAt(3).Ing = new ObservableCollection<Ingredients>()
            {
                IngredientsMaker.MakeIngredients("Sel", 2),
                IngredientsMaker.MakeIngredients("Carottes", 10),
                IngredientsMaker.MakeIngredients("Olives", 4)
            };
            list.ElementAt(3).Outils = new ObservableCollection<Tools>()
            {
                ToolsMaker.MakeTools("Poele", 1),
                ToolsMaker.MakeTools("Casserole", 2)
            };

            list.ElementAt(4).Ing = new ObservableCollection<Ingredients>()
            {
                IngredientsMaker.MakeIngredients("Sel", 2),
                IngredientsMaker.MakeIngredients("Carottes", 10),
                IngredientsMaker.MakeIngredients("Olives", 4)
            };
            list.ElementAt(4).Outils = new ObservableCollection<Tools>()
            {
                ToolsMaker.MakeTools("Poele", 1),
                ToolsMaker.MakeTools("Casserole", 2)
            };

            list.ElementAt(5).Ing = new ObservableCollection<Ingredients>()
            {
                IngredientsMaker.MakeIngredients("Sel", 2),
                IngredientsMaker.MakeIngredients("Carottes", 10),
                IngredientsMaker.MakeIngredients("Olives", 4)
            };
            list.ElementAt(5).Outils = new ObservableCollection<Tools>()
            {
                ToolsMaker.MakeTools("Poele", 1),
                ToolsMaker.MakeTools("Casserole", 2)
            };

            list.ElementAt(6).Ing = new ObservableCollection<Ingredients>()
            {
                IngredientsMaker.MakeIngredients("Sel", 2),
                IngredientsMaker.MakeIngredients("Carottes", 10),
                IngredientsMaker.MakeIngredients("Olives", 4)
            };
            list.ElementAt(7).Outils = new ObservableCollection<Tools>()
            {
                ToolsMaker.MakeTools("Poele", 1),
                ToolsMaker.MakeTools("Casserole", 2)
            };

            list.ElementAt(7).Ing = new ObservableCollection<Ingredients>()
            {
                IngredientsMaker.MakeIngredients("Sel", 2),
                IngredientsMaker.MakeIngredients("Carottes", 10),
                IngredientsMaker.MakeIngredients("Olives", 4)
            };
            list.ElementAt(8).Outils = new ObservableCollection<Tools>()
            {
                ToolsMaker.MakeTools("Poele", 1),
                ToolsMaker.MakeTools("Casserole", 2)
            };

            list.ElementAt(8).Ing = new ObservableCollection<Ingredients>()
            {
                IngredientsMaker.MakeIngredients("Sel", 2),
                IngredientsMaker.MakeIngredients("Carottes", 10),
                IngredientsMaker.MakeIngredients("Olives", 4)
            };
            list.ElementAt(6).Outils = new ObservableCollection<Tools>()
            {
                ToolsMaker.MakeTools("Poele", 1),
                ToolsMaker.MakeTools("Casserole", 2)
            };

            list.ElementAt(9).Ing = new ObservableCollection<Ingredients>()
            {
                IngredientsMaker.MakeIngredients("Egg", 2),
                IngredientsMaker.MakeIngredients("Ter", 4),
                IngredientsMaker.MakeIngredients("Eas", 6)
            };
            list.ElementAt(9).Outils = new ObservableCollection<Tools>()
            {
                ToolsMaker.MakeTools("Fingers", 8),
                ToolsMaker.MakeTools("Brain", 10),
                ToolsMaker.MakeTools("Keyboard", 12)
            };

            return new DishesGlob(list);
        }
    }
}
