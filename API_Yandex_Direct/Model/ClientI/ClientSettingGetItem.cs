using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.ClientI
{

    /// <summary>
    /// Настройки рекламодателя, допускающие только значения YES или NO.
    /// </summary>
    [DataContract]
    public class ClientSettingGetItem
    {
        /// <summary>
        ///   Имя настройки
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ClientSettingGetEnum Option { get; set; }

        /// <summary>
        /// Значение настройки.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public YesNoEnum Value { get; set; }
    }
}
