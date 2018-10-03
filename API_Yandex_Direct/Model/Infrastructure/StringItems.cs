using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.Infrastructure
{
    [DataContract]
    public struct StringItems
    {
        [DataMember(EmitDefaultValue = false)]
        public string[] Items { get; set; }
    }
}
