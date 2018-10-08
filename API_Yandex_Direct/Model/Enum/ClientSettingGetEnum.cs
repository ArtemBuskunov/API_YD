using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    /// <summary>
    ///   Имя настройки
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClientSettingGetEnum : byte
    {
        /// <summary>
        /// автоматически исправлять ошибки и опечатки.
        /// </summary>
        CORRECT_TYPOS_AUTOMATICALLY,
        /// <summary>
        /// показывать рейтинг магазина в объявлениях.
        /// </summary>
        DISPLAY_STORE_RATING,
        /// <summary>
        /// подключен общий счет.
        /// </summary>
        SHARED_ACCOUNT_ENABLED
    }

}
