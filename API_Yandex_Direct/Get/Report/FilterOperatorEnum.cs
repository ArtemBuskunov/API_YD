using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Get.Report
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FilterOperatorEnum
    {

        /// <summary>
        ///  — значение поля равно значению из Values;
        /// </summary>
        EQUALS,
        /// <summary>
        ///  — значение поля не равно значению из Values;
        /// </summary>
        NOT_EQUALS,
        /// <summary>
        ///  — значение поля равно любому значению из Values;
        /// </summary>
        IN,
        /// <summary>
        /// — значение поля не равно ни одному значению из Values;
        /// </summary>
        NOT_IN,
        /// <summary>
        ///  — значение поля меньше значения из Values;
        /// </summary>
        LESS_THAN,
        /// <summary>
        ///  — значение поля больше значения из Values;
        /// </summary>
        GREATER_THAN,
        /// <summary>
        ///  — значение поля начинается с значения из Values;
        /// </summary>
        STARTS_WITH_IGNORE_CASE,
        /// <summary>
        ///  — значение поля не начинается с значения из Values;
        /// </summary>
        DOES_NOT_START_WITH_IGNORE_CASE,
        /// <summary>
        ///  — значение поля начинается с любого из значений, указанных в Values;
        /// </summary>
        STARTS_WITH_ANY_IGNORE_CASE,
        /// <summary>
        ///  — значение поля не начинается ни с одного из значений, указанных в Values.
        /// </summary>
        DOES_NOT_START_WITH_ALL_IGNORE_CASE
    }
}
