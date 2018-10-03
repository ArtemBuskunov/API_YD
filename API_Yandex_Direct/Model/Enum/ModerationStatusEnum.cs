using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ModerationStatusEnum
    {
        /// <summary>
        /// принята модерацией
        /// </summary>
        ACCEPTED,
        /// <summary>
        /// находится на модерации
        /// </summary>
        MODERATION,
        /// <summary>
        /// отклонена
        /// </summary>
        REJECTED
    }
}
