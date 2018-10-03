using System.Runtime.Serialization;

namespace API_Yandex_Direct.ApiConnect.Infrastructure
{
    public struct ExceptionNotification
    {
        /// <summary>
        ///  Числовой код ошибки или предупреждения.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int Code { get; set; }

        /// <summary>
        /// Текст сообщения об ошибке или предупреждения.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Подробное описание ошибки или предупреждения.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Details { get; set; }
    }
}
