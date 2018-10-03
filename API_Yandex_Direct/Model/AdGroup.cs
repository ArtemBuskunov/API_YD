using API_Yandex_Direct.Model.Enum;
using API_Yandex_Direct.Model.Infrastructure;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model
{

    /// <summary>
    /// Группа объявлений представляет собой набор объявлений и единые для этих объявлений условия показа.
    /// <para> Не более 1000 групп в кампании.</para>
    /// <para>Тип группы должен соответствовать типу кампании.</para>
    /// <para>Никакие операции с группами в архивной кампании невозможны.</para>
    /// </summary>
    [DataContract]
    public class AdGroup
    {
        /// <summary>
        /// Идентификатор группы объявлений.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Название группы.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Идентификатор кампании.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long CampaignId { get; set; }

        /// <summary>
        /// Идентификаторы регионов, для которых показы включены или выключены.
        /// <para> Идентификатор 0 — показывать во всех регионах.</para>
        /// <para> Минус перед идентификатором региона — выключить показы в данном регионе.Например[1, -219] — показывать для Москвы и Московской области, кроме Черноголовки.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long[] RegionIds { get; set; }

        /// <summary>
        /// Идентификаторы регионов, в которых объявления не будут показаны в связи с законодательными ограничениями.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public longItems? RestrictedRegionIds { get; set; }

        /// <summary>
        /// Минус-фразы, общие для всех ключевых фраз группы объявлений.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public StringItems? NegativeKeywords { get; set; }

        /// <summary>
        /// GET-параметры для отслеживания источников переходов на сайт, которые добавляются в ссылку всех объявлений группы (не более 1024 символов). Могут содержать подстановочные переменные.
        /// <para> Например: from=direct&ad={ad_id}</para>
        /// <para> Параметр можно указать для группы любого типа, однако в настоящее время он используется только для групп динамических объявлений. Для других типов групп указанные GET-параметры в ссылку не добавляются.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string TrackingParams { get; set; }

        /// <summary>
        /// Статус группы. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Статус возможности показов группы. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ServingStatusEnum ServingStatus { get; set; }

        /// <summary>
        /// Тип группы объявлений.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public AdGroupTypesEnum Type { get; set; }

        /// <summary>
        /// Подтип группы объявлений. Для групп с типом, отличным от DYNAMIC_TEXT_AD_GROUP, возвращается значение NONE.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public AdGroupSubtypeEnum Subtype { get; set; }

        /// <summary>
        /// Параметры группы для рекламы мобильных приложений. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public MobileApp.MobileApp MobileAppAdGroup { get; set; }

        /// <summary>
        /// Параметры группы динамических объявлений, для которых источником данных является сайт.  
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DynamicText.DynamicText DynamicTextAdGroup { get; set; }

        /// <summary>
        /// Параметры группы динамических объявлений, для которых источником данных является фид.  
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DynamicTextFeed.DynamicTextFeed DynamicTextFeedAdGroup { get; set; }
    }
}
