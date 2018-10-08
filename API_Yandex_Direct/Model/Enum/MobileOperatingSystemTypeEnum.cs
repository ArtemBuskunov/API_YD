using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MobileOperatingSystemTypeEnum : byte
    {
        /// <summary>
        /// iOS
        /// </summary>
        IOS,
        /// <summary>
        /// Android
        /// </summary>
        ANDROID,
        /// <summary>
        /// данные из магазина приложений еще не получены.
        /// </summary>
        OS_TYPE_UNKNOWN
    }

}
