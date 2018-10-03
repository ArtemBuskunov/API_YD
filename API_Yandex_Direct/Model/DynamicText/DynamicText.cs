using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.DynamicText
{
    /// <summary>
    /// Параметры группы динамических объявлений, для которых источником данных является сайт.  
    /// </summary>
    [DataContract]
    public class DynamicText
    {
        /// <summary>
        /// Доменное имя сайта, для которого требуется сгенерировать динамические объявления (не более 100 символов). Протокол указывать не нужно.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string DomainUrl { get; set; }

        /// <summary>
        /// Статус генерации динамических объявлений:
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public SourceProcessingStatusEnum DomainUrlProcessingStatus { get; set; }
    }

}
