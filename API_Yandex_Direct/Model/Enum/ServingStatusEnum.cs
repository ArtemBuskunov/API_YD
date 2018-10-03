using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    /// <summary>
    /// Параметр ServingStatus отражает возможность показов по содержащимся в группе условиям показа.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServingStatusEnum
    {
        /// <summary>
        /// Показы возможны.
        /// </summary>
        ELIGIBLE,
        /// <summary>
        /// «Мало показов» — при текущих настройках показы происходят крайне редко. Например, ключевые фразы не встречаются в поисковых запросах пользователей.
        /// </summary>
        RARELY_SERVED
    }
}
