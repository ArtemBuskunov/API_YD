using System.Runtime.Serialization;

namespace API_Yandex_Direct.ApiConnect.Infrastructure
{
    /// <summary>
    /// Ошибки выполнения запроса
    /// </summary>
    [DataContract]
    public class GetResultError
    {
        [DataMember]
        public Model.Campaign[] Campaigns { get; set; }

        /// <summary>
        /// Порядковый номер последнего возвращенного объекта. Передается в случае, если количество объектов в ответе было ограничено лимитом. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long LimitedBy { get; set; }

        /// <summary>
        /// Уникальный идентификатор запроса, присвоенный сервером API Директа.Также передается в HTTP-заголовке RequestId.
        /// </summary>
        [DataMember(Name = "request_id")]
        public string Request_id { get; set; }

        /// <summary>
        /// Числовой код ошибки.
        /// </summary>
        [DataMember(Name = "error_code")]
        public int Error_code { get; set; }

        /// <summary>
        /// Текст сообщения об ошибке.
        /// </summary>
        [DataMember(Name = "error_string")]
        public string Error_string { get; set; }

        /// <summary>
        /// Подробное описание ошибки.
        /// </summary>
        [DataMember(Name = "error_detail")]
        public string Error_detail { get; set; }

    }

}
