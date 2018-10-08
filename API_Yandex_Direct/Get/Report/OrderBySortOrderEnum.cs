using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Get.Report
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderBySortOrderEnum : byte
    {

        /// <summary>
        ///  — по возрастанию;
        /// </summary>
        ASCENDING,
        /// <summary>
        ///  — по убыванию.
        /// </summary>
        DESCENDING
    }

}
