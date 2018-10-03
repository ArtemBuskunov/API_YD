using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.CampaignI
{
    [DataContract]
    public class TextCampaignStrategy
    {
        /// <summary>
        ///  Стратегия показа на поиске.Нет
        /// </summary>
        [DataMember]
        public TextCampaignSearchStrategy Search { get; set; }

        /// <summary>
        ///   Стратегия показа в сетях.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TextCampaignNetworkStrategy Network { get; set; }
    }
}
