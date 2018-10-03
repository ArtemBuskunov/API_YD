using System.Runtime.Serialization;

namespace API_Yandex_Direct.ApiConnect.Infrastructure
{
    [DataContract]
    class GetResult
    {
        [DataMember(Name = "result")]
        public Result5 Result { get; set; }

        [DataMember(Name = "error")]
        public GetResultError Error { get; set; }
    }
}
