using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Set.Bids
{
    /// <summary>
    ///
    /// <para> Внимание! Параметры CampaignId, AdGroupId и KeywordId являются взаимоисключающими. В одном запросе можно указывать только один из этих параметров.</para>
    /// <para> Хотя бы один из параметров Bid, ContextBid, StrategyPriority</para>
    /// </summary>
    [DataContract]
    public class BidSetItem
    {
        /// <summary>
        /// дентификатор кампании.Указывается, если требуется назначить единую ставку/приоритет для всех фраз кампании.Либо CampaignId, либо AdGroupId, либо KeywordId
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long CampaignId { get; set; }

        /// <summary>
        ///  Идентификатор группы объявлений.Указывается, если требуется назначить единую ставку/приоритет для всех фраз группы.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long AdGroupId { get; set; }

        /// <summary>
        /// Идентификатор фразы.Указывается, если требуется назначить ставку/приоритет для отдельной фразы.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long KeywordId { get; set; }

        /// <summary>
        /// Ставка на поиске, умноженная на 1 000 000. Целое число. Только для ручной стратегии.
        /// <para> Указывается в валюте рекламодателя.Ограничения приведены на странице Минимальный и максимальный размер цены за клик.</para>
        /// <para> Хотя бы один из параметров Bid, ContextBid, StrategyPriority</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Bid { get; set; }

        /// <summary>
        /// Ставка в сетях, умноженная на 1 000 000. Целое число. Только для ручной стратегии с независимым управлением ставками в сетях.
        /// <para>    Указывается в валюте рекламодателя.Ограничения приведены на странице Минимальный и максимальный размер цены за клик.</para>
        /// <para>    Внимание! Показ графического объявления возможен только при условии, что ставка не ниже минимальной ставки для объявления с включенным в него изображением.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long ContextBid { get; set; }

        /// <summary>
        /// Приоритет фразы: LOW, NORMAL или HIGH. Только для автоматической стратегии.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public PriorityEnum StrategyPriority { get; set; }

    }
}
