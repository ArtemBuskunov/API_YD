using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AppAvailabilityStatusEnum
    {
        /// <summary>
        /// доступно
        /// </summary>
        AVAILABLE,
        /// <summary>
        /// недоступно
        /// </summary>
        NOT_AVAILABLE,
        /// <summary>
        /// данные из магазина приложений еще не получены
        /// </summary>
        UNPROCESSED
    }
}
