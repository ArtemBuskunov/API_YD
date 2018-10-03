using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.BidsI
{
    /// <summary>
    /// Позиция показа на поиске
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PositionEnum
    {
        /// <summary>
        /// минимальная ставка за 4-ю позицию в гарантии (вход в блок гарантированных показов)
        /// </summary>
        FOOTERBLOCK,
        /// <summary>
        /// минимальная ставка за 1-ю позицию в гарантии
        /// </summary>
        FOOTERFIRST,
        /// <summary>
        /// минимальная ставка за 4-ю позицию в спецразмещении (вход в спецразмещение)
        /// </summary>
        PREMIUMBLOCK,
        /// <summary>
        /// минимальная ставка за 1-ю позицию в спецразмещении
        /// </summary>
        PREMIUMFIRST
    }
}
