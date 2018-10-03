using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.Infrastructure
{
    [DataContract]
    public struct longItems
    {
        [DataMember(EmitDefaultValue = false)]
        public long[] Items { get; set; }
    }
}
