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
using System.Windows.Shapes;
using BibliothequeDeClasses;
using ApplicationConsole;
using ApplicationWPF;
using Facade;

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class WindowDelete : Window
    {
        ///<summary>
        ///Propriété de la listbox dans la mainWindow.
        ///</summary>
        public ListBox MyListBox { get; set; }

        ///<summary>
        ///Ouverture de la fenêtre.
        ///</summary>
        public WindowDelete()
        {
            InitializeComponent();
        }

        ///<summary>
        ///Ferme la fenêtre et annule la modification.
        ///</summary>
        private void click_btnNon(object sender, RoutedEventArgs e)
        {
            Close();
        }

        ///<summary>
        ///Remove le plat sélectionné dans le modèle.
        ///</summary>
        private void click_btnOui(object sender, RoutedEventArgs e)
        {
            DishesGlobFacade.AllDishes.mDishesG.Remove((Dishes)((((MainWindow)Application.Current.MainWindow).listBox).SelectedItem));
            Close();
        }

        ///<summary>
        ///Si le plat n'a pas été supprimé alors il est automatiquement désélectionné.
        ///</summary>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MyListBox.SelectedIndex = -1;
        }
    }
}
