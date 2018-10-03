using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    /// <summary>
    /// Параметр Status отражает обобщенный результат модерации ключевых фраз. Ключевые фразы отправляются на модерацию автоматически, когда на модерацию отправляется одно из объявлений группы.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Группа создана и еще не отправлена на модерацию.
        /// </summary>
        DRAFT,
        /// <summary>
        /// Группа находится на модерации.
        /// </summary>
        MODERATION,
        /// <summary>
        /// Группа допущена к показам автоматически, но будет дополнительно проверена модератором.
        /// </summary>
        PREACCEPTED,
        /// <summary>
        /// Хотя бы одна фраза группы принята модерацией (некоторые могли быть отклонены).
        /// </summary>
        ACCEPTED,
        /// <summary>
        /// Все фразы отклонены.
        /// </summary>
        REJECTED
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusEnumK
    {
        /// <summary>
        /// Новая фраза: еще не отправлена на модерацию или находится на модерации.
        ///<para>Если в кампании есть хотя бы одно объявление, которое активно или отправлено на модерацию, новые фразы отправляются на модерацию автоматически.</para> 
        /// </summary>
        DRAFT,
        /// <summary>
        ///  Фраза принята модерацией.
        /// </summary>
        ACCEPTED,
        /// <summary>
        ///  Фраза отклонена модерацией.
        /// </summary>
        REJECTED,
        /// <summary>
        ///  Неизвестный статус. Используется для обеспечения обратной совместимости и отображения статусов, не поддерживаемых в данной версии API.
        /// </summary>
        UNKNOWN
    }
}
