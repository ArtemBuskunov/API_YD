using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    /// <summary>
    /// Параметр Status отражает результат модерации ключевой фразы.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StateEnum
    {
        /// <summary>
        /// Показы объявлений по фразе возможны.
        /// </summary>
        ON,
        /// <summary>
        ///  Показы остановлены владельцем (с помощью метода suspend или в веб-интерфейсе).
        /// </summary>
        SUSPENDED,
        /// <summary>
        /// Фраза еще не отправлена на модерацию или отклонена модерацией.
        /// </summary>
        OFF
    }
}
