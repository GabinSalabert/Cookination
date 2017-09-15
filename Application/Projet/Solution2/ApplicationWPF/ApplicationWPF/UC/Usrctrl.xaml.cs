using BibliothequeDeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplication1;

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour Usrctrl.xaml.
    /// </summary>
    public partial class Usrctrl : UserControl
    {
        /// <summary>
        ///  Déclaration d'une DependencyProperty
        /// </summary>
        public static readonly DependencyProperty ListBox = DependencyProperty.Register("MyListBox", typeof(ListBox), typeof(Usrctrl));

        /// <summary>
        /// DependencyProperty sur la listbox de la mainWindow.
        /// </summary>
        public ListBox MyListBox
        {
            get
            {
                return GetValue(ListBox) as ListBox;
            }
            set
            {
                SetValue(ListBox, value);
            }
        }

        /// <summary>
        /// Logique d'interaction pour WindowEdit.xaml.
        /// </summary>
        public Usrctrl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Logique d'interaction pour WindowEdit.xaml.
        /// </summary>
        /// <remarks> Si le click est sur le bouton ajouter des outils, alors les labels sont initialisés correctement et la fenêtre d'ajout s'ouvre. </remarks>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddTI d = new AddTI();
            d.label.Content = "Tool :";
            d.lab.Content = "Saisissez votre outil :";
            d.ShowDialog();
        }

        /// <summary>
        /// Logique d'interaction pour WindowEdit.xaml.
        /// </summary>
        /// <remarks> Si le click est sur le bouton supprimer des outils, l'outil est supprimé. </remarks>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ((Dishes)MyListBox.SelectedItem).Outils.Remove((Tools)T.SelectedItem);
        }

        /// <summary>
        /// Logique d'interaction pour WindowEdit.xaml.
        /// </summary>
        /// <remarks>Si le clique est sur le bouton ajouter des ingrédients, alors les labels sont initialisés correctement et la fenêtre d'ajout s'ouvre.</remarks>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddTI d = new AddTI();
            d.label.Content = "Ingredient :";
            d.lab.Content = "Saisissez votre ingrédient :";
            d.ShowDialog();
        }

        /// <summary>
        /// Logique d'interaction pour WindowEdit.xaml.
        /// </summary>
        /// <remarks>Si le clique est sur le bouton supprimer des ingrédients, l'ingrédient est supprimé.</remarks>
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ((Dishes)MyListBox.SelectedItem).Ing.Remove((Ingredients)I.SelectedItem);
        }
    }
}
