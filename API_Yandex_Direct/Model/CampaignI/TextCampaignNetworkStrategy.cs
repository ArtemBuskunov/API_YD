using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.CampaignI
{
    [DataContract]
    public class TextCampaignNetworkStrategy
    {
        /// <summary>
        ///  Стратегия показа на поиске.
        /// </summary>
        [DataMember]
        public TextCampaignNetworkStrategyTypeEnum BiddingStrategyType { get; set; }


        /// <summary>
        ///  Параметры стратегии «Ставка в сети устанавливается в зависимости от ставки на поиск».
        /// </summary>
        [DataMember]
        public StrategyNetworkDefault NetworkDefault { get; set; }

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
