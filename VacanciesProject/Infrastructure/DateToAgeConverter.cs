using System;
using System.Globalization;
using System.Windows.Data;

namespace VacanciesProject.Infrastructure
{
    public class DateToAgeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var tmp = (DateTime)value;
            var timeSpan = (DateTime.Now).Subtract(tmp);
            int age = (int)timeSpan.TotalDays / 365;
            return $"{age}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var dateString = (string)value;
            var date = DateTime.Parse(dateString);
            return date;
        }
    }
}
