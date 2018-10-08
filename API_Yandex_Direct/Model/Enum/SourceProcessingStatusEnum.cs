using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SourceProcessingStatusEnum : byte
    {
        /// <summary>
        ///  генерация объявлений не завершена
        /// </summary>
        UNPROCESSED,
        /// <summary>
        /// объявления созданы
        /// </summary>
        PROCESSED,
        /// <summary>
        /// не удалось создать ни одного объявления
        /// </summary>
        EMPTY_RESULT
    }
}
