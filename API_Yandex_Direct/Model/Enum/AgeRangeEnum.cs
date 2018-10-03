using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    /// <summary>
    /// Возрастная группа пользователя: одно из значений AGE_0_17, AGE_18_24, AGE_25_34, AGE_35_44, AGE_45_54 или AGE_55.
    /// Значение AGE_45 устарело, рекомендуется создать отдельные корректировки для возрастных групп AGE_45_54 и AGE_55.
    /// Если параметр не указан, подразумевается любой возраст.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AgeRangeEnum { AGE_0_17, AGE_18_24, AGE_25_34, AGE_35_44, AGE_45, AGE_45_54, AGE_55 }
}
