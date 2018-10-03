using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.Infrastructure
{

    /// <summary>
    /// Ограничения на значения параметров.
    /// </summary>
    [DataContract]
    public class ConstantsItem
    {
        /// <summary>
        /// Наименование ограничения.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Значение ограничения.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Value { get; set; }
    }
}
