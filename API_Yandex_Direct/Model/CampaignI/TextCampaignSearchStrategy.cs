using API_Yandex_Direct.Model.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.CampaignI
{
    [DataContract]
    public class TextCampaignSearchStrategy
    {
        /// <summary>
        ///  Стратегия показа на поиске.Нет
        /// </summary>
        [DataMember]
        [JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
        public TextCampaignSearchStrategyTypeEnum BiddingStrategyType { get; set; }

        /// <summary>
        ///  Параметры стратегии Недельный бюджет (максимум кликов).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public StrategyMaximumClicks WbMaximumClicks { get; set; }

        /// <summary>
        /// Параметры стратегии Недельный бюджет (максимальная конверсия).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public StrategyMaximumConversionRate WbMaximumConversionRate { get; set; }

        /// <summary>
        ///  Параметры стратегии Средняя цена клика.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public StrategyAverageCpc AverageCpc { get; set; }

        /// <summary>
        ///  Параметры стратегии Средняя цена конверсии.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public StrategyAverageCpa AverageCpa { get; set; }

        /// <summary>
        ///  	Параметры стратегии Средняя рентабельность инвестиций.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public StrategyAverageRoi AverageRoi { get; set; }

        /// <summary>
        ///  	Параметры стратегии Средняя рентабельность инвестиций.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public StrategyWeeklyClickPackage WeeklyClickPackage { get; set; }

    }
}
