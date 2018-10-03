using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace API_Yandex_Direct.Create.ForecastReport
{
    [DataContract]
    public class ForecastInfo
    {
        /// <summary>
        /// Массив ключевых фраз, для которых требуется получить прогноз(не более 100 фраз в кодировке UTF-8).
        /// Ключевые фразы могут содержать минус-фразы.Минус-фразу из нескольких слов следует заключить в скобки, например:
        /// холодильник -морозильник -(морозильная камера) -ремонт.
        /// Примечание.Если массив содержит пересекающиеся ключевые фразы, то есть соответствующие одному и тому же поисковому запросу, то прогнозируемый показ и клик может быть отнесен к любой из этих фраз случайным образом.Поэтому прогноз по таким фразам может отличаться от прогноза, полученного по каждой фразе отдельными вызовами метода.См.раздел Устранение пересечений.
        /// </summary>
        [DataMember]
        public string[] Phrases { get; set; }

        /// <summary>
        /// Массив, содержащий идентификаторы рубрик Яндекс.Каталога.Параметр не используется, переданное значение игнорируется.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int[] Categories { get; set; }

        /// <summary>
        ///  Массив, содержащий идентификаторы регионов для составления прогноза.Если не задан, прогноз составляется по всем регионам.
        ///Список регионов получают с помощью метода GetRegions (Live).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int[] GeoID { get; set; }

        /// <summary>
        /// Валюта, в которой должны быть выражены цены клика и суммарные затраты в отчете.
        ///<para>Возможные значения: RUB, CHF, EUR, KZT, TRY, UAH, USD, BYN.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Выводить ли в отчете результаты торгов (массив AuctionBids) — Yes/No.Если не задано, подразумевается No.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string AuctionBids { get; set; }
    }
}
