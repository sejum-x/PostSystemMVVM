using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using PostSystemMVVM.Model;

namespace PostSystemMVVM.Convertors
{

    public class ImagePathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (PaymentStatus) value;
            var uri = new Uri($"D:/nulp/term 5/kpz/PostSystemMVVM/PostSystemMVVM/Images/PaymentStatus/{status}.png");
            return new BitmapImage(uri); 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}