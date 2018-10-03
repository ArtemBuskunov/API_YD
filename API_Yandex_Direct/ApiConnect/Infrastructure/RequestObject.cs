using System.Runtime.Serialization;

namespace API_Yandex_Direct.ApiConnect.Infrastructure
{
    [DataContract]
    public class RequestObjectV5
    {
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public string Method { get; set; }

        [DataMember(Name = "params", EmitDefaultValue = false)]
        public dynamic Params { get; set; }

    }

    [DataContract]
    public class RequestObjectV4
    {

        [DataMember(Name = "method")]
        public string Method { get; set; }

        [DataMember(Name = "param", EmitDefaultValue = false)]
        public dynamic Param { get; set; }

        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }
    }
}
