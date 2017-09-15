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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ApplicationWPF;

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour Field.xaml
    /// </summary>
    public partial class Field : UserControl
    {
        //Dependency pour le label affiché lors de la création dynamique d'un field. Il doit être incrémenté correctement et instantanément.
        public static readonly new DependencyProperty ContentProperty = DependencyProperty.Register("MyContent", typeof(string), typeof(Field));
        public string MyContent
        {
            get
            {
                return GetValue(ContentProperty).ToString();
            }
            set
            {
                SetValue(ContentProperty, value);
            }
        }

        public Field()
        {
            InitializeComponent();
        }

        //Expression régulière permettant de ne filtrer que les digit pour le nombre d'ingrédients/tools.
        private void Verify(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
            if (num.BorderBrush == Brushes.Red)
            {
                num.BorderBrush = Brushes.DimGray;
            }

        }

        //Si la textbox n'avait pas été remplie (En rouge) mais que du texte est saisie alors bordercolor reset.
        private void Verify2(object sender, TextCompositionEventArgs e)
        {
            if (textbox.BorderBrush == Brushes.Red)
            {
                textbox.BorderBrush = Brushes.DimGray;
            }
        }
    }
}
