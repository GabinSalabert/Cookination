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
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using Facade;

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        ///<summary>
        ///Chemin de l'image.
        ///</summary>
        private String pathim { get; set; }

        ///<summary>
        ///Observable collection de champs.
        ///</summary>
        public static ObservableCollection<Field> TabField { get; set; } = new ObservableCollection<Field>();

        ///<summary>
        ///Propriété de la listbox dans la mainWindow.
        ///</summary>
        public ListBox MyListBox { get; set; }

        ///<summary>
        ///Observable collection de champs.
        ///</summary>
        public static ObservableCollection<Field> TabField2 { get; set; } = new ObservableCollection<Field>();

        ///<summary>
        ///Entier j
        ///</summary>
        private int j { get; set; } = 0;

        ///<summary>
        ///Entier i
        ///</summary>
        private int i { get; set; } = 0;

        ///<summary>
        ///Ouverture de la fenêtre.
        ///</summary>
        public WindowAdd()
        {
            InitializeComponent();
        }

        ///<summary>
        ///Ouvre une fenêtre de dialogue permettant de parcourrir et sélectionner un/les fichiers de son pc.
        ///Le path de l'image est récupéré dans une variable.
        ///</summary>
        private void click_btnBrowse(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog()
            {
                Filter = "Image Files(*.png, *.jpg, *.jpeg)| *.png; *.jpg; *.jpeg"
            };

            if(dlg.ShowDialog() == true)
            {
                pathim = dlg.FileName;
                textBox13.Text = dlg.FileName;
            }                
        }

        ///<summary>
        ///Crée un nouveau userControl à chaque fois avec un label devant qui s'incrémente/se désincrémente au fur et à mesure.
        ///Si le compteur n'est pas à 0 et qu'un UC est crée, alors le label indiquant qu'il n'y a plus de field lorsque l'on veut en supprimer un est caché.
        ///</summary>
        private void AddIngs(object sender, RoutedEventArgs e)
        {
            Field field = new Field()
            {
                MyContent = i + " : "                
            };

            if (i >= 0)
            {
                MonLabelErreur2.Visibility = Visibility.Hidden;
            }

            TabField.Add(field);
            MyGrid.Children.Add(field);
            ++i; 
       }

        ///<summary>
        ///Crée un nouveau userControl (Dans le tableau et dans la grid) à chaque fois avec un label devant qui s'incrémente/se désincrémente au fur et à mesure.
        ///Si le compteur n'est pas à 0 et qu'un UC est crée, alors le label indiquant qu'il n'y a plus de field lorsque l'on veut en supprimer un est caché.
        ///</summary>
        private void AddTools(object sender, RoutedEventArgs e)
        {
            Field field = new Field()
            {
                MyContent = j + " : "
            };

            if (j >= 0)
            {
                MonLabelErreur3.Visibility = Visibility.Hidden;
            }

            TabField2.Add(field); 
            MyGrid2.Children.Add(field);
            ++j;
        }

        ///<summary>
        ///Supprime le dernier filed crée. Si le compteur est décrémenté à -1, un label indiquant qu'il n'y a pas de field apparaît.
        ///</summary>
        private void DelTools(object sender, RoutedEventArgs e)
        {
            try
            {

                if (j == 0)
                {
                    MonLabelErreur3.Visibility = Visibility.Hidden;
                }

                if (j != 0)
                {
                    MonLabelErreur3.Visibility = Visibility.Hidden;
                    TabField2.RemoveAt(j - 1);
                    MyGrid2.Children.RemoveAt(j - 1);
                    j--;
                }

                else
                    throw new Exception();
            }

            catch (Exception)
            {
                MonLabelErreur3.Visibility = Visibility.Visible;
            }

        }

        ///<summary>
        ///Supprime le dernier filed crée. Si le compteur est décrémenté à -1, un label indiquant qu'il n'y a pas de field apparaît.
        ///</summary>
        private void DelIngs(object sender, RoutedEventArgs e)
        {
            try
            {
                if (i == 0)
                {
                    MonLabelErreur2.Visibility = Visibility.Hidden;
                }

                if (i != 0)
                {
                    MonLabelErreur2.Visibility = Visibility.Hidden;
                    TabField.RemoveAt(i - 1);
                    MyGrid.Children.RemoveAt(i - 1);
                    i--;
                }

                else
                    throw new Exception();
            }

            catch (Exception)
            {
                MonLabelErreur2.Visibility = Visibility.Visible;
            }
                
        }

        ///<summary>
        ///Valide l'ajoût du plat :
        ///Vérifie si tous les champs sont bien remplies. Si ce n'est pas le cas, un label apparaît.
        ///On parcours une fois le tableau de field pour vérifier si un champ est vide. Si oui on parcours a nouveau afin de mettre les borders en red (Aussi pour des champs précédants non remplies).
        ///On crée un nouveau plat avec toutes les données recueillies dans l'observable collection de plats et on repositionne la fenêtre principale au centre de l'écran. 
        ///</summary>
        private void Validate(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Ingredients> ings = new ObservableCollection<Ingredients>();
            ObservableCollection<Tools> tools = new ObservableCollection<Tools>();

            try
            {
                if (string.IsNullOrEmpty(name.Text))
                {
                    name.BorderBrush = Brushes.Red;
                    throw new NullReferenceException();
                }
                if (string.IsNullOrEmpty(cat.Text))
                {
                    cat.BorderBrush = Brushes.Red;
                    throw new NullReferenceException();
                }
                if (string.IsNullOrEmpty(Rece.Text))
                {
                    Rece.BorderBrush = Brushes.Red;
                    throw new NullReferenceException();
                }
                if (cat.BorderBrush == Brushes.Red)
                {
                    MonLabelErreur4.Visibility = Visibility.Visible;
                    throw new NullReferenceException();
                }

                foreach (Field f in TabField)
                {
                    if (string.IsNullOrEmpty(f.textbox.Text) || string.IsNullOrEmpty(f.num.Text))
                    {
                        
                        foreach (Field fi in TabField)
                            if (string.IsNullOrEmpty(fi.textbox.Text) || string.IsNullOrEmpty(fi.num.Text))
                            {
                                fi.textbox.BorderBrush = Brushes.Red;
                                fi.num.BorderBrush = Brushes.Red;
                            }
                        if (string.IsNullOrEmpty(textBox13.Text))
                            textBox13.BorderBrush = Brushes.Red;
                        if(string.IsNullOrEmpty(name.Text))
                            name.BorderBrush = Brushes.Red;
                        if (string.IsNullOrEmpty(cat.Text))
                            cat.BorderBrush = Brushes.Red;
                        if (string.IsNullOrEmpty(Rece.Text))
                            Rece.BorderBrush = Brushes.Red;

                        foreach (Field fi in TabField2)
                            if (string.IsNullOrEmpty(fi.textbox.Text) || string.IsNullOrEmpty(fi.num.Text))
                            {
                                fi.textbox.BorderBrush = Brushes.Red;
                                fi.num.BorderBrush = Brushes.Red;
                            }

                        throw new NullReferenceException();
                    }
                    ings.Add(IngredientsMaker.MakeIngredients(f.textbox.Text, int.Parse(f.num.Text)));
                }

                foreach (Field f in TabField2)
                {
                    if (string.IsNullOrEmpty(f.textbox.Text) || string.IsNullOrEmpty(f.num.Text))
                    {
                        foreach (Field fi in TabField2)
                            if (string.IsNullOrEmpty(fi.textbox.Text) || string.IsNullOrEmpty(fi.num.Text))
                            {
                                fi.textbox.BorderBrush = Brushes.Red;
                                fi.num.BorderBrush = Brushes.Red;
                            }

                        if (string.IsNullOrEmpty(textBox13.Text))
                            textBox13.BorderBrush = Brushes.Red;
                        if (string.IsNullOrEmpty(name.Text))
                            name.BorderBrush = Brushes.Red;
                        if (string.IsNullOrEmpty(cat.Text))
                            cat.BorderBrush = Brushes.Red;
                        if (string.IsNullOrEmpty(Rece.Text))
                            Rece.BorderBrush = Brushes.Red;

                        foreach (Field fi in TabField)
                            if (string.IsNullOrEmpty(fi.textbox.Text) || string.IsNullOrEmpty(fi.num.Text))
                            {
                                fi.textbox.BorderBrush = Brushes.Red;
                                fi.num.BorderBrush = Brushes.Red;
                            }

                        throw new NullReferenceException();
                    }
                    tools.Add(ToolsMaker.MakeTools(f.textbox.Text, int.Parse(f.num.Text)));
                }

                DishesGlobFacade.AllDishes.mDishesG.Add(DishesMaker.MakeDishes(name.Text, cat.Text, Rece.Text, new Uri(pathim, UriKind.RelativeOrAbsolute), ings, tools));
                ((MainWindow)Application.Current.MainWindow).Left = 500;
                Close();
            }
            catch (Exception)
            {
                MonLabelErreur.Visibility = Visibility.Visible;
            }
        }

        ///<summary>
        ///Repositionne la fenêtre principale au centre de l'écran et ferme la fenêtre d'ajoût.
        ///</summary>
        private void Cancel(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).Left = 500;
            Close();
        }

        ///<summary>
        ///Repositionne la fenêtre principale au centre de l'écran et désélectionne un plat (si sélection) de la liste.
        ///</summary>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).Left = 500;
            MyListBox.SelectedIndex = -1;
        }
        ///<summary>
        ///Si le champ n'était pas remplie mais que du texte est saisie alors la border est reset.
        ///</summary>
        private void textBox13_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox13.BorderBrush == Brushes.Red)
            {
                textBox13.BorderBrush = Brushes.DimGray;
            }
        }

        ///<summary>
        ///Met la textbox en rouge si le texte saisie ne correspond pas à une catégorie autorisée.
        ///Si la saisie est bonne, la border est reset.
        ///</summary>
        private void cat_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (cat.Text != "Régime" && cat.Text != "Bio" && cat.Text != "Etranger" && cat.Text != "Sucré-Salé" && cat.Text != "Rapides" && cat.Text != "Nutritionnel" && cat.Text != "Prise de masse" && cat.Text != "Léger" && cat.Text != "Plaisir" && cat.Text != "Légumes")
                cat.BorderBrush = Brushes.Red;
            else
                cat.BorderBrush = Brushes.DimGray;
        }

        ///<summary>
        ///Permet le retoour à la ligne dans la textbox de la recette (meilleure visibilité).
        ///</summary>
        private void Rece_TextChanged(object sender, TextChangedEventArgs e)
        {
            Rece.AcceptsReturn = true;
        }
    }
}

