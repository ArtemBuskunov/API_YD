using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    /// <summary>
    ///  Роль пользователя
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RepresentativeRoleEnum
    {
        /// <summary>
        /// главный представитель рекламодателя.
        /// </summary>
        CHIEF,
        /// <summary>
        /// обычный представитель рекламодателя.
        /// </summary>
        DELEGATE,
        /// <summary>
        /// роль не поддерживается в данной версии API.
        /// </summary>
        UNKNOWN
    }
}
