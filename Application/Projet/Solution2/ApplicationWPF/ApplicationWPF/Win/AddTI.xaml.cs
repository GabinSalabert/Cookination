using BibliothequeDeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    ///<summary>
    ///Logique d'interaction pour AddTI.xaml
    ///</summary>
    public partial class AddTI : Window
    {
        ///<summary>
        ///Ouverture de la fenêtre.
        ///</summary>
        public AddTI()
        {
            InitializeComponent();
        }

        ///<summary>
        ///Vérifie que la saisie correspond bien à des digit.
        ///</summary>
        private void num_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
            if (num.BorderBrush == Brushes.Red)
            {
                num.BorderBrush = Brushes.DimGray;
            }
        }

        ///<summary>
        ///Vérifie que les champs sont bien remplies. Si ce n'est pas le cas les border passent en rouge. Ajoute le nouvel élement dans la liste correspondante.
        ///</summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textbox.Text))
                {
                    textbox.BorderBrush = Brushes.Red;
                    throw new NullReferenceException();
                }
                if (string.IsNullOrEmpty(num.Text))
                {
                    num.BorderBrush = Brushes.Red;
                    throw new NullReferenceException();
                }
                if ((string)label.Content == "Tool :")
                    ((Dishes)((((MainWindow)Application.Current.MainWindow).listBox).SelectedItem)).Outils.Add(ToolsMaker.MakeTools(textbox.Text, Int32.Parse(num.Text)));
                else if((string)label.Content == "Ingredient :")
                    ((Dishes)((((MainWindow)Application.Current.MainWindow).listBox).SelectedItem)).Ing.Add(IngredientsMaker.MakeIngredients(textbox.Text, Int32.Parse(num.Text)));
                Close();
            }
            catch (Exception)
            {
                Er.Visibility = Visibility.Visible;
            }
        }

        ///<summary>
        ///Si le champ était vide et que du texte est saisie alors la border est reset.
        ///</summary>
        private void textbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (textbox.BorderBrush == Brushes.Red)
                textbox.BorderBrush = Brushes.DimGray;
        }
    }
}
