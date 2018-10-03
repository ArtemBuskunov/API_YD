using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.BidsI
{
    [DataContract]
    public class ContextCoverage
    {
        /// <summary>
        /// Ставки для данной фразы, позволяющие достичь охвата различных долей аудитории в сетях (прогноз). Служат ориентиром при подборе ставок.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ContextCoverageItem[] Items { get; set; }
    }
}
