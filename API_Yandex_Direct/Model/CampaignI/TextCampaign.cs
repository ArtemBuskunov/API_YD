using API_Yandex_Direct.Model.Infrastructure;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.CampaignI
{
    [DataContract]
    public class TextCampaign
    {
        /// <summary>
        /// Настройки для кампании с типом «Реклама мобильных приложений». 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TextCampaignSetting[] Settings { get; set; }

        /// <summary>
        /// Идентификаторы счетчиков Яндекс.Метрики, установленных на сайте рекламодателя 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public IntItems? CounterIds { get; set; }

        /// <summary>
        /// Настройки показов по дополнительным релевантным фразам
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public RelevantKeywordsSetting RelevantKeywords { get; set; }


        /// <summary>
        /// Стратегия показа.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TextCampaignStrategy BiddingStrategy { get; set; }
    }
}
