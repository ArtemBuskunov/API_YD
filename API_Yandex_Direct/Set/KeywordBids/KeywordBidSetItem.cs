using API_Yandex_Direct.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace API_Yandex_Direct.Set.KeywordBids
{
    [DataContract]
    public class KeywordBidSetItem
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
        /// <para> Хотя бы один из параметров SearchBid, NetworkBid, StrategyPriority</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long SearchBid { get; set; }

        /// <summary>
        /// Ставка в сетях, умноженная на 1 000 000. Целое число. Только для ручной стратегии с независимым управлением ставками в сетях.
        /// <para> Указывается в валюте рекламодателя.Ограничения приведены на странице Минимальный и максимальный размер цены за клик.</para>
        /// <para> Хотя бы один из параметров SearchBid, NetworkBid, StrategyPriority</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long NetworkBid { get; set; }

        /// <summary>
        /// Приоритет фразы: LOW, NORMAL или HIGH. Только для автоматической стратегии.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public PriorityEnum StrategyPriority { get; set; }

    }
}
