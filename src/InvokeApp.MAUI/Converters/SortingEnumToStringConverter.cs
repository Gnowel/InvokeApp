using InvokeApp.Shared.Enums;
using System.Globalization;

namespace InvokeApp.MAUI.Converters
{
    public class SortingEnumToStringConverters : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            if(value is Sorting sorting)
            {
                return SortingEnumToString(sorting);
            }

            return SortingEnumsToStrings((List<Sorting>)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string sorting)
            {
                return StringToSortingEnum(sorting);
            }
            return StringsToSortingEnums((List<string>)value);
        }

        private List<string> SortingEnumsToStrings(List<Sorting> sorting)
        {
            List<string> result = new ();

            foreach(var item in sorting) 
            {
                result.Add(SortingEnumToString(item));
            }

            return result;
        }

        private List<Sorting> StringsToSortingEnums(List<string> sorting)
        {
            List<Sorting> result = new();

            foreach (var item in sorting)
            {
                result.Add(StringToSortingEnum(item));
            }

            return result;
        }

        private string SortingEnumToString(Sorting sorting)
        {
            switch (sorting)
            {
                case Sorting.New:
                    return "Новинки";
                case Sorting.Expensive:
                    return "Сначала дорогие";
                case Sorting.Cheap:
                    return "Сначала дешевые";
                default:
                    return "Новинки";
            }
        }

        private Sorting StringToSortingEnum(string sorting)
        {
            switch (sorting)
            {
                case "Новинки":
                    return Sorting.New;
                case "Сначала дорогие":
                    return Sorting.Expensive;
                case "Сначала дешевые":
                    return Sorting.Cheap;
                default:
                    return Sorting.New;
            }
        }
    }
}
