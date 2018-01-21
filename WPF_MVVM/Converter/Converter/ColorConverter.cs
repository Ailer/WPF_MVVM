using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Converter
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Color)
            {
                Color color = (Color)value;

                switch (color)
                {
                    case Color.Red:
                        return new SolidColorBrush(Colors.Red);
                    case Color.Blue:
                        return new SolidColorBrush(Colors.Blue);
                    case Color.Green:
                        return new SolidColorBrush(Colors.Green);
                    case Color.Yellow:
                        return new SolidColorBrush(Colors.Yellow);
                    default:
                        return new SolidColorBrush(Colors.Black);
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
