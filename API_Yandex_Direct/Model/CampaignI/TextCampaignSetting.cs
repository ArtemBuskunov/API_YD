using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.CampaignI
{
    [DataContract]
    public class TextCampaignSetting
    {
        /// <summary>
        /// Имя настройки
        /// </summary>
        [DataMember]
        public TextCampaignSettingsEnum Option { get; set; }

        /// <summary>
        /// Значение настройки.
        /// </summary>
        [DataMember]
        public YesNoEnum Value { get; set; }
    }
}
