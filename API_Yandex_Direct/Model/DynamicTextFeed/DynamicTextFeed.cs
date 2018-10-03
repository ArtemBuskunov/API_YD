using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.DynamicTextFeed
{
    /// <summary>
    /// Параметры группы динамических объявлений, для которых источником данных является фид.  
    /// </summary>
    [DataContract]
    public class DynamicTextFeed
    {
        /// <summary>
        /// Идентификатор фида.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Тип источника данных.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public SourceTypeGetEnum SourceType { get; set; }

        /// <summary>
        /// Статус генерации динамических объявлений
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public SourceProcessingStatusEnum SourceProcessingStatus { get; set; }        
    }

}
