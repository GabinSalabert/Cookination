using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour WindowEdit.xaml
    /// </summary>
    public class Converter : IValueConverter
    {
        /// <summary>
        /// Convertion d'une SolidColorBrush en Brushes.
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            SolidColorBrush black = new SolidColorBrush(Color.FromRgb(21, 21, 21));

            switch ((string)parameter)
            {
                case "color": return (((SolidColorBrush)value).Color) == black.Color ? Brushes.White : black;
                default: return null;
            }
        }

        /// <summary>
        /// Retourne à l'état précédent.
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
