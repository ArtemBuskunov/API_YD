using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    /// <summary>
    /// Тип уведомления:
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EmailSubscriptionEnum {
        /// <summary>
        /// новости Директа и рекомендации.
        /// </summary>
        RECEIVE_RECOMMENDATIONS,
        /// <summary>
        /// уведомления по кампаниям, обслуживаемым персональным менеджером.
        /// </summary>
        TRACK_MANAGED_CAMPAIGNS,
        /// <summary>
        /// предупреждения о перемещении объявлений на более низкие позиции относительно тех, которые обеспечивали ставки на момент установки.
        /// </summary>
        TRACK_POSITION_CHANGES
    }

}
