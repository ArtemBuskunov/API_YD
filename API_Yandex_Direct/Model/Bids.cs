using API_Yandex_Direct.Model.BidsI;
using API_Yandex_Direct.Model.Enum;
using API_Yandex_Direct.Model.Infrastructure;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model
{
    [DataContract]
    public class Bids
    {
        /// <summary>
        /// Идентификатор кампании, к которой относится ключевая фраза. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long CampaignId { get; set; }

        /// <summary>
        /// Идентификатор группы объявлений, к которой относится ключевая фраза.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long AdGroupId { get; set; }

        /// <summary>
        /// Идентификатор ключевой фразы.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long KeywordId { get; set; }


        /// <summary>
        /// Статус возможности показов группы объявлений. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ServingStatusEnum ServingStatus { get; set; }

        /// <summary>
        /// Ставка на поиске.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Bid { get; set; }

        /// <summary>
        /// Ставка в сетях.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long ContextBid { get; set; }

        /// <summary>
        /// Приоритет фразы.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public PriorityEnum? StrategyPriority { get; set; }

        /// <summary>
        /// Массив минимальных ставок за все позиции в спецразмещении и в блоке гарантированных показов.
        /// <para>Примечание. Если в группе объявлений мало показов (значение RARELY_SERVED параметра ServingStatus), параметр не возвращается.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long[] CompetitorsBids { get; set; }

        /// <summary>
        /// Минимальные ставки за позиции показа для данной фразы на поиске.
        /// <para>Примечание. Если в группе объявлений мало показов (значение RARELY_SERVED параметра ServingStatus), параметр не возвращается.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public SearchPrices[] SearchPrices { get; set; }

        /// <summary>
        /// Ставки для данной фразы, позволяющие достичь охвата различных долей аудитории сетей (прогноз). Служат ориентиром при подборе ставок.
        /// <para>Примечание. Если в группе объявлений мало показов (значение RARELY_SERVED параметра ServingStatus) или в кампании выбрана стратегия показа в сетях SERVING_OFF или NETWORK_DEFAULT, возвращается null (nil).</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ContextCoverage ContextCoverage { get; set; }

        /// <summary>
        /// Минимальная ставка, установленная для рекламодателя, при которой возможен показ на поиске.
        /// <para>Примечание. Если в группе объявлений мало показов (значение RARELY_SERVED параметра ServingStatus), возвращается null (nil).</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long? MinSearchPrice { get; set; }

        /// <summary>
        /// Текущая цена клика на поиске. Эта цена может быть списана при клике по объявлению на странице результатов поиска (по запросу, точно соответствующему ключевой фразе). Подробнее см. в разделе Расчет цены клика помощи Директа.
        /// <para>Примечание. Если в группе объявлений мало показов (значение RARELY_SERVED параметра ServingStatus), возвращается null (nil).</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long? CurrentSearchPrice { get; set; }

        /// <summary>
        /// Результаты торгов по фразе.
        /// <para>Примечание. Если в группе объявлений мало показов (значение RARELY_SERVED параметра ServingStatus), параметр не возвращается.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public AuctionBidItem[] AuctionBids { get; set; }

    }
}
