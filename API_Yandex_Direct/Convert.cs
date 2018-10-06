using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Yandex_Direct
{
    public class Convert
    {
        /// <summary>
        /// Преобразует значение валюты в значение для API (bit * 1000000)
        /// </summary>
        public static long СurrencyToBit(double bit)
        {
            if (Double.IsNaN(bit)) { return 0L; }
            return (long)(bit * 1000000);
        }
        /// <summary>
        /// Преобразует значение валюты в значение для API(bit * 1000000)
        /// </summary>
        public static long СurrencyToBit(string bit)
        {
            if (bit is null) { return 0L; }
            double bit1 = 0;
            double.TryParse(bit.Replace(".", ","), NumberStyles.Number, CultureInfo.CreateSpecificCulture("ru-Ru"), out bit1);
            return (long)(bit1 * 1000000);
        }
        /// <summary>
        /// Преобразует значение для API в значение валюты (Long / 1000000)
        /// </summary>
        public static double BitToСurrency(long Long) { return (double)Long / 1000000; }


        public static string[] EnumArrayToStringArray(Array EnumList)
        {
            if (EnumList is null) { return new string[] { }; }
            string[] vs = new string[EnumList.Length];
            for (int i = 0; i < EnumList.Length; i++)
            { vs[i] = (EnumList.GetValue(i) as Enum).ToString(); }
            return vs;
        }
    }
}
