using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    /// <summary>
    /// Имя полномочия
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrivilegeEnum {
        /// <summary>
        /// редактирование кампаний.
        /// </summary>
        EDIT_CAMPAIGNS,
        /// <summary>
        /// управление кампаниями с помощью файлов.
        /// </summary>
        IMPORT_XLS,
        /// <summary>
        /// перенос средств между кампаниями.
        /// </summary>
        TRANSFER_MONEY
    }
}
