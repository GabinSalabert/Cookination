using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BibliothequeDeClasses;

namespace BibliothequeDeClasses
{
    public class Stub
    {
        public static DishesGlob LoadDishes()
        {
            //On instancie l'observable collection de plat. Puis on crée toutes les instances de plats, d'outils et d'ingrédients afin de les lui ajouter.
            //Ce stub sera chargé par défaut si aucun fichier XML n'est trouvé dans %appdata%.
            ObservableCollection<Dishes> list = new ObservableCollection<Dishes>();

            Dishes first = new Dishes("Carpaccio Melon-Comcombre", "Régime", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("Pictures/Carpaccio.jpg", UriKind.RelativeOrAbsolute));
            Dishes second = new Dishes("Hachis Parmentier", "Rapides", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("Pictures/Hachis.jpg", UriKind.RelativeOrAbsolute));
            Dishes third = new Dishes("Tajine", "Etranger", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("Pictures/Tajine.jpeg", UriKind.RelativeOrAbsolute));
            Dishes fourth = new Dishes("Risotto au pesto et petits pois", "Nutritionnel", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("Pictures/Risotto.jpg", UriKind.RelativeOrAbsolute));
            Dishes fifth = new Dishes("Salade de pâtes au thon", "Prise de masse", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("Pictures/PatesThon.jpg", UriKind.RelativeOrAbsolute));
            Dishes sixth = new Dishes("Filet de cabillau en papillote", "Léger", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("Pictures/Cabillaud.jpeg", UriKind.RelativeOrAbsolute));
            Dishes seventh = new Dishes("Spaghettis bolognaises", "Plaisir", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("Pictures/Spaghettis.jpg", UriKind.RelativeOrAbsolute));
            Dishes eighth = new Dishes("Galettes de légumes", "Légumes", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("Pictures/Galettes.jpeg", UriKind.RelativeOrAbsolute));
            Dishes ninth = new Dishes("Poulet laqué au miel", "Sucré-Salé", "Faire chauffer le four.\nAjouter 3 grammes de sucre puis 300g de farine.\nMettre le tout au four et laisser cuire a 200 degrés.", new Uri("Pictures/Poulet.jpg", UriKind.RelativeOrAbsolute));
            Dishes eleventh = new Dishes("Serpent", "Bio", "Vider le serpent.\nAjouter 42 grammes de sucre puis 1024g de farine.\nGarnissez avec un zeste BONUS de citron et laisser cuire a 666 degrés.", new Uri("Pictures/Serp.jpg", UriKind.RelativeOrAbsolute));

            first.Ing.Add(new Ingredients("Sel", 4));
            first.Ing.Add(new Ingredients("Poivre", 12));
            first.Ing.Add(new Ingredients("Huile", 8));
            first.Ing.Add(new Ingredients("Miel+", 1));
            first.Outils.Add(new Tools("Moule", 666));
            first.Outils.Add(new Tools("Four", 5));
            first.Outils.Add(new Tools("Mixeur", 2));
            first.Outils.Add(new Tools("Cactus", 18));

            second.Ing.Add(new Ingredients("Sel", 2));
            second.Ing.Add(new Ingredients("Carottes", 10));
            second.Ing.Add(new Ingredients("Olives", 4));
            second.Outils.Add(new Tools("Poele", 1));
            second.Outils.Add(new Tools("Casserole", 2));

            third.Ing.Add(new Ingredients("Chocolat", 4));
            third.Outils.Add(new Tools("edézd", 666));
            third.Outils.Add(new Tools("Four", 5));
            third.Outils.Add(new Tools("Mixeur", 2));

            fourth.Ing.Add(new Ingredients("Sel", 2));
            fourth.Ing.Add(new Ingredients("Carottes", 10));
            fourth.Ing.Add(new Ingredients("Olives", 4));
            fourth.Outils.Add(new Tools("Poele", 1));
            fourth.Outils.Add(new Tools("Casserole", 2));

            fifth.Ing.Add(new Ingredients("Sel", 2));
            fifth.Ing.Add(new Ingredients("Carottes", 10));
            fifth.Ing.Add(new Ingredients("Olives", 4));
            fifth.Outils.Add(new Tools("Poele", 1));
            fifth.Outils.Add(new Tools("Casserole", 2));

            sixth.Ing.Add(new Ingredients("Sel", 2));
            sixth.Ing.Add(new Ingredients("Carottes", 10));
            sixth.Ing.Add(new Ingredients("Olives", 4));
            sixth.Outils.Add(new Tools("Poele", 1));
            sixth.Outils.Add(new Tools("Casserole", 2));

            seventh.Ing.Add(new Ingredients("Sel", 2));
            seventh.Ing.Add(new Ingredients("Carottes", 10));
            seventh.Ing.Add(new Ingredients("Olives", 4));
            seventh.Outils.Add(new Tools("Poele", 1));
            seventh.Outils.Add(new Tools("Casserole", 2));

            eighth.Ing.Add(new Ingredients("Sel", 2));
            eighth.Ing.Add(new Ingredients("Carottes", 10));
            eighth.Ing.Add(new Ingredients("Olives", 4));
            eighth.Outils.Add(new Tools("Poele", 1));
            eighth.Outils.Add(new Tools("Casserole", 2));

            ninth.Ing.Add(new Ingredients("Sel", 2));
            ninth.Ing.Add(new Ingredients("Carottes", 10));
            ninth.Ing.Add(new Ingredients("Olives", 4));
            ninth.Outils.Add(new Tools("Poele", 1));
            ninth.Outils.Add(new Tools("Casserole", 2));

            eleventh.Ing.Add(new Ingredients("Egg", 2));
            eleventh.Ing.Add(new Ingredients("Ter", 4));
            eleventh.Ing.Add(new Ingredients("Eas", 6));
            eleventh.Outils.Add(new Tools("Fingers", 8));
            eleventh.Outils.Add(new Tools("Brain", 10));
            eleventh.Outils.Add(new Tools("Keyboard", 12));

            list.Add(first);
            list.Add(second);
            list.Add(third);
            list.Add(fourth);
            list.Add(fifth);
            list.Add(sixth);
            list.Add(seventh);
            list.Add(eighth);
            list.Add(ninth);
            list.Add(eleventh);


            return new DishesGlob(list);
        }
    }
}
