using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using BibliothequeDeClasses;
using ApplicationConsole;
using ApplicationWPF;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using System.IO.Compression;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;
using Stub;
using Facade;

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Double imc;
        private int Egg;

        /// <summary>
        ///Ouverture fenêtre principale :
        ///Création d'une exception en cas de problème d'ouverture de la MainWindow. 
        ///Initialisation de la police et de l'évenement si une touche est pressée.
        /// </summary>
        public MainWindow()
        {
            DishesGlobFacade.LoadD();
            InitializeComponent();           
            listBox.DataContext = DishesGlobFacade.AllDishes;
            this.KeyDown += new KeyEventHandler(MainWindow_KeyDown);
        }

        ///<summary>
        ///Easter egg :
        ///Il faut que le plat sélectionné ait pour nom "Serpent" et que l'utilisateur rentre "Bonus" au clavier.
        ///Lancement d'une application codée en Processing (Java) dans un thread à part :
        ///Si le fichier existe, l'application est lancée.
        ///Sinon, on unzip le .zip à l'emplacement souhaité.
        ///</summary>
        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.B && e.Key != Key.O && e.Key != Key.N && e.Key != Key.U && e.Key != Key.S)
                Egg = 0;

            if (e.Key == Key.B)
            {
                Egg += 1;
            }

            if (e.Key == Key.O)
            {
                Egg += 1;
            }

            if (e.Key == Key.N)
            {
                Egg += 1;
            }

            if (e.Key == Key.U)
            {
                Egg += 1;
            }

            if (e.Key == Key.S && Egg == 4 && ((Dishes)listBox.SelectedItem).Name == "Serpent")
            {
                Egg = 0;
                Thread myThread = new Thread(() =>
                {
                    Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
                    if (!Directory.Exists("Snake/MySnake"))
                    {                       
                        Directory.CreateDirectory("Snake/MySnake");
                        ZipFile.ExtractToDirectory("Snake/output.zip", "Snake/MySnake");
                    }

                    ProcessStartInfo processInfo = new ProcessStartInfo();
                    processInfo.FileName = "Snake/MySnake/application.windows64/Snake.exe";
                    processInfo.ErrorDialog = true;
                    processInfo.UseShellExecute = false;
                    processInfo.RedirectStandardOutput = true;
                    processInfo.RedirectStandardError = true;
                    processInfo.WorkingDirectory = Path.GetDirectoryName("Snake/MySnake/application.windows64/Snake.exe");
                    Process proc = Process.Start(processInfo);
                });
                myThread.Start();
            }

        }

        ///<summary>
        ///Toutes les données sont enregistrées dans un fichier xml lorsque la fenêtre principale est fermée.
        ///</summary>
        private void Window_Closed(object sender, EventArgs e)
        {
            PersistDishes.Serialize(DishesGlobFacade.AllDishes);
        }

        ///<summary>
        ///Lorsqu'on clique sur le bouton "+", on décale la fenêtre principale sur la droite et on ouvre la fenêtre d'ajout en modale.
        ///</summary>
        private void click_btnAjoutPlat (object sender, System.EventArgs e)
        {
            WindowAdd fenetre_ajoutPlat = new WindowAdd()
            {
                MyListBox = listBox
            };
            this.Left = 600;
            fenetre_ajoutPlat.ShowDialog();
        }

        ///<summary>
        ///Night/day mode :
        ///Lorsque l'on clique sur le bouton, le background ainsi que les foreground passent du mode sombre à clair et vice versa.
        ///</summary>
        private void click_btnBg(object sender, EventArgs e)
        {
            SolidColorBrush Black = new SolidColorBrush(Color.FromRgb(21, 21, 21));

            if (((SolidColorBrush)Background).Color == Black.Color)
            {
                //Foreground
                Background = Brushes.Gray;
                listBox.Background = Brushes.WhiteSmoke;
                listBox.Foreground = Black;
                pt.Background = Brushes.WhiteSmoke;
                Stats.Foreground = Brushes.Black;
                Check1.Foreground = Black;
                Check2.Foreground = Black;
                c.Foreground = Black;
                Reci.Foreground = Black;
                Slogan.Foreground = Black;
                InnerText.Foreground = Black;
                p.Foreground = Brushes.Black;
                t.Foreground = Brushes.Black;
                Res.Foreground = Brushes.Black;
                Rec.Foreground = Brushes.Black;
                Proposition.Foreground = Brushes.Black;
                checkBox.Foreground = Brushes.Black;
                Imcc.Foreground = Brushes.Black;
                Imcc.Foreground = Brushes.Black;

                //Bordures
                tabControl.BorderBrush = Black;
                listBox.BorderBrush = Black;
                Dishes.BorderBrush = Black;
                tabControl.Background = Brushes.WhiteSmoke;
                General.Background = Brushes.Black;
            }

            else
            {
                //Foreground
                Background = Black;
                Res.Foreground = Brushes.WhiteSmoke;
                Rec.Foreground = Brushes.WhiteSmoke;
                listBox.Background = Brushes.Black;
                listBox.Foreground = Brushes.White;
                pt.Background = Brushes.Black;
                p.Foreground = Brushes.White;
                t.Foreground = Brushes.White;
                Reci.Foreground = Brushes.WhiteSmoke;
                Proposition.Foreground = Brushes.WhiteSmoke;
                checkBox.Foreground = Brushes.White;
                Imcc.Foreground = Brushes.White;
                Imcc.Foreground = Brushes.White;
                Check1.Foreground = Brushes.WhiteSmoke;
                Check2.Foreground = Brushes.WhiteSmoke;
                c.Foreground = Brushes.WhiteSmoke;
                Slogan.Foreground = Brushes.WhiteSmoke;
                InnerText.Foreground = Brushes.WhiteSmoke;

                //Bordures
                tabControl.BorderBrush = Brushes.Orange;
                listBox.BorderBrush = Brushes.Orange;
                Dishes.BorderBrush = Brushes.Orange;
                tabControl.Background = Brushes.Black;
            }
        }

        ///<summary>
        ///Lorsque l'on clique sur le bouton, on ouvre la fenêtre de confirmation de supression.
        ///</summary>
        private void buttonSupprPlat_Click(object sender, RoutedEventArgs e)
        {
            if (!ReferenceEquals(listBox.SelectedItem, null))
            {
                WindowDelete d = new WindowDelete()
                {
                    MyListBox = listBox
                };
                d.ShowDialog();
            }                
        }

        ///<summary>
        ///Lorsque l'on clique sur le bouton, on décale la fenêtre principale sur la droite et on ouvre la fenêtre de modification du plat.
        ///On bind le dataContexte de la fenêtre que l'on ouvre sur le plat sélectionné dans la liste.
        ///</summary>
        private void buttonModifPlat_Click(object sender, RoutedEventArgs e)
        {
            if (!ReferenceEquals(listBox.SelectedItem, null))
            {
                WindowEdit d = new WindowEdit()
                {
                    MyListBox = listBox,
                    DataContext = listBox.SelectedItem
                };               
                this.Left = 800;
                d.ShowDialog();
            }     
        }

        ///<summary>
        ///L'observable collection de plats est triée par ordre alphabétique grâce à une requête Linq.
        ///On reset le binding du dataContexte sur l'observable collection maintenant triée pour la mettre à jour.
        ///</summary>
        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            DishesGlobFacade.AllDishes = DishesGlobFacade.AllDishes.SortD();
            listBox.DataContext = DishesGlobFacade.AllDishes;
        }

        ///<summary>
        ///Lorsqu'un plat est sélectionné dans la liste, si l'utilisateur est sur l'onglet Welcome alors il est automatiquement dirigé sur l'onglet général.
        ///</summary>
        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(tabControl.SelectedIndex == 0)
                tabControl.SelectedIndex = 1;
        }

        ///<summary>
        ///Barre de recherche :
        ///Si "Search with name" est checkée, alors la requête Linq cherchera les noms des plats avec la chaîne rentrée.
        ///Si "Search with categ" est checkée, alors la requête Linq cherchera les plats avec la catégorie sélectionnée dans la combobox..
        ///</summary>
        private void SearchChange(object sender, TextChangedEventArgs e)
        {
            if(Check1.IsChecked == true)
                listBox.DataContext = DishesGlobFacade.AllDishes.Filter("Name", Search2.Text);
            if (Check2.IsChecked == true)
                listBox.DataContext = DishesGlobFacade.AllDishes.Filter(((ComboBoxItem)comboBox.SelectedItem).Content.ToString(), Search2.Text);
        }

        ///<summary>
        ///On appelle la fonction du dessus en passant en paramètre l'item sélectionné de la combobox.
        ///Si l'utilisateur clique sur la chaîne vide de la combo box, le dataContexte est reset sur la collection de plats.
        ///</summary>

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ReferenceEquals(((ComboBoxItem)comboBox.SelectedItem).Content, string.Empty))
                listBox.DataContext = DishesGlobFacade.AllDishes;
            else
                SearchChange(this, new TextChangedEventArgs(e.RoutedEvent, UndoAction.None));            
        }

        ///<summary>
        ///Si la recherche par nom est checké, alors on déchecke la recherche par catégorie et on rend accessible la barre de recherche.
        ///</summary>
        private void Check1_Checked(object sender, RoutedEventArgs e)
        {
            Check2.IsChecked = false;
            Search2.Focusable = true;
        }

        ///<summary>
        ///Si la recherche par catégorie est checké, alors on déchecke la recherche par nom et on rend inaccessible la barre de recherche.
        ///</summary>
        private void Check2_Checked(object sender, RoutedEventArgs e)
        {
            Check1.IsChecked = false;
            Search2.Focusable = false;
        }

        ///<summary>
        ///Calcul de l'IMC :
        ///Si "être un grand sportif est checké", on néglige quelques kilos.
        ///On calcule l'IMC en convertissant le poids et la taille en double. Calcul -> Poids/Taille² (/100 car taille en cm).
        ///Analyse de toute les possibilités d'IMC et en fonction de celles-ci affichage des propositions de catégories.
        ///</summary>
        private void calcul_Click(object sender, RoutedEventArgs e)
        {
            if(checkBox.IsChecked == true)
                imc = (Double.Parse(poids.Text)-20) / (((Double.Parse(taille.Text) / 100) * ((Double.Parse(taille.Text)) / 100)));

            else
                imc = Double.Parse(poids.Text) / (((Double.Parse(taille.Text)/100)*((Double.Parse(taille.Text))/100)));

            Res.Text = ToString();

            if(imc >= 18.5 && imc <= 25)
            {
                Imc.Foreground = Brushes.Green;
                Imc.Visibility = Visibility.Visible;
                Imc.Content = "Vous avez actuellement une corpulence normale";
                Proposition.Text = "Grand-mère, Rapides, Végétarien, Prise de masse, Etrangers...";
            }

            if (imc < 18.5 && imc >= 16.5)
            {
                Imc.Foreground = Brushes.Yellow;
                Imc.Visibility = Visibility.Visible;
                Imc.Content = "Vous avez actuellement une corpulence plutôt maigre.";
                Proposition.Text = "Grand-mère, Rapides, Prise de masse, Etrangers...";
            }

            if (imc < 16.5)
            {
                Imc.Foreground = Brushes.Red;
                Imc.Visibility = Visibility.Visible;
                Imc.Content = "Vous êtes actuellement en dénutrition.";
                Proposition.Text = "Nutritionnel, Prise de masse...";
            }

            if (imc > 25 && imc <= 30)
            {
                Imc.Foreground = Brushes.Yellow;
                Imc.Visibility = Visibility.Visible;
                Imc.Content = "Vous êtes actuellement en léger surpoids.";
                Proposition.Text = "Régime, Rapides, Léger, Légumes...";
            }

            if (imc > 30 && imc <= 35)
            {
                Imc.Foreground = Brushes.Orange;
                Imc.Visibility = Visibility.Visible;
                Imc.Content = "Vous êtes actuellement en obésité modérée.";
                Proposition.Text = "Régime, Léger, Légumes...";
            }

            if (imc > 35 && imc <= 40)
            {
                Imc.Foreground = Brushes.Red;
                Imc.Visibility = Visibility.Visible;
                Imc.Content = "Vous êtes actuellement en obésité sévère.";
                Proposition.Text = "Régime, Léger, Légumes...";
            }

            if (imc > 40)
            {
                Imc.Foreground = Brushes.Red;
                Imc.Visibility = Visibility.Visible;
                Imc.Content = "Vous êtes actuellement en obésité morbide ou massive.";
                Proposition.Text = "HÔPITAL";
            }
        }

        public override string ToString()
            => $"{ imc}";

        ///<summary>
        ///Expression régulière permettant de filtrer seulemement les digit.
        ///</summary>
        private void poids_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        ///<summary>
        ///Expression régulière permettant de filtrer seulemement les digit.
        ///</summary>
        private void taille_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
