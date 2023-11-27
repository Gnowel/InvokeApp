using InvokeApp.Shared.Enums;
using System.Globalization;

namespace InvokeApp.MAUI.Converters
{
    class IntToConditionStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = (int)value;
            return IntToString(result);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private string IntToString(int value)
        {
            switch (value)
            {
                case 0:
                    return "Другое (см. описание)";
                case 1:
                    return "Для запчастей";
                case 2:
                    return "Б/у";
                case 3:
                    return "Открытая коробка";
                case 4:
                    return "Восстановленные/сертифицированные";
                case 5:
                    return "Новые";
                default:
                    return "Другое (см. описание)";
            }
        }
    }
}
