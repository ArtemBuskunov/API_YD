using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.Infrastructure
{
    [DataContract]
    public struct IntItems
    {
        [DataMember(EmitDefaultValue = false)]
        public int[] Items { get; set; }
    }
}
