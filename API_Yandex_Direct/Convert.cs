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
        public long СurrencyToBit(double bit) { return (long)(bit * 1000000); }
        /// <summary>
        /// Преобразует значение валюты в значение для API(bit * 1000000)
        /// </summary>
        public long СurrencyToBit(string bit)
        {
            double bit1 = 0;
            double.TryParse(bit.Replace(".", ","), NumberStyles.Number, CultureInfo.CreateSpecificCulture("ru-Ru"), out bit1);
            return (long)(bit1 * 1000000);
        }
        /// <summary>
        /// Преобразует значение для API в значение валюты (Long / 1000000)
        /// </summary>
        public double BitToСurrency(long Long) { return (double)Long / 1000000; }

    }
}
