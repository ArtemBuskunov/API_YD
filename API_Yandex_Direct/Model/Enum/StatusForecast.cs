using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusForecast : byte
    {
        /// <summary>
        /// — отчет сформирован;
        /// </summary>
        Done,
        /// <summary>
        /// — отчет формируется;
        /// </summary>
        Pending,
        /// <summary>
        /// — сформировать отчет не удалось.
        /// </summary>
        Failed
    }
}
