using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeviceTypeEnum
    {
        /// <summary>
        /// смартфоны
        /// </summary>
        DEVICE_TYPE_MOBILE,
        /// <summary>
        /// планшеты
        /// </summary>
        DEVICE_TYPE_TABLET
    }
}
