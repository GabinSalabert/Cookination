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
using WpfApplication1;
using System.Collections.ObjectModel;

namespace ApplicationWPF
{
    /// <summary>
    /// Logique d'interaction pour WindowEdit.xaml
    /// </summary>
    public partial class WindowEdit : Window
    {
        ///<summary>
        ///Chemin de l'image.
        ///</summary>
        private String pathim { get; set; }

        ///<summary>
        ///Propriété de la listbox dans la mainWindow.
        ///</summary>
        public ListBox MyListBox { get; set; }

        ///<summary>
        ///Ouverture de la fenêtre.
        ///</summary>
        public WindowEdit()
        {
            InitializeComponent();
        }

        ///<summary>
        ///Bouton qui ferme la fenêtre de modification, set les données et replace la mainWindow.
        ///</summary>
        private void click_btnFinish(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).Left = 500;
            Close();
        }

        ///<summary>
        ///Ouvre une fenêtre de dialogue permettant de parcourrir et sélectionner un/les fichiers de son pc.
        ///Le path de l'image est récupéré dans une variable.
        ///</summary>
        private void click_btnBrowse(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog()
            {
                InitialDirectory = "c:\\",
                Filter = "All files (*.*)|*.*"
            };

            if (dlg.ShowDialog() == true)
            {
                pathim = dlg.FileName;
                this.Im.Text = pathim;
            }            
        }

        ///<summary>
        ///Replace la mainWindow lors de la fermeture et désélectionne le plat dans la liste.
        ///</summary>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MyListBox.SelectedIndex = -1;
            ((MainWindow)Application.Current.MainWindow).Left = 500;
        }
    }
}
