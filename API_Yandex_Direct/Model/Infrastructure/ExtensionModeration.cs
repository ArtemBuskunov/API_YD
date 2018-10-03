using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.Infrastructure
{
    /// <summary>
    /// Результат модерации иконки мобильного приложения. 
    /// </summary>
    [DataContract]
    public class ExtensionModeration
    {

        /// <summary>
        /// Результат модерации иконки мобильного приложения
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ModerationStatusEnum Status { get; set; }

        /// <summary>
        /// Текстовое пояснение к статусу и/или причины отклонения на модерации.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string StatusClarification { get; set; }
    }
}
