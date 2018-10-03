using API_Yandex_Direct.Get.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.Campaign
{
    [DataContract]
    public class ParamsRequest : ParamsRequestAbstract
    {
        /// <summary>
        /// Критерий отбора кампаний.
        ///<para>Чтобы получить все кампании рекламодателя, необходимо указать пустой SelectionCriteria.</para> 
        /// </summary>
        [DataMember]
        public SelectionCriteriaFromCampaignRequest SelectionCriteria { get; set; }
  
        #region TextCampaignFieldNames
        /// <summary>
        /// Имена параметров кампании с типом «Текстово-графические объявления»
        ///<para>Примечание. Если согласно SelectionCriteria отобрана кампания другого типа,
        /// параметры из TextCampaignFieldNames не возвращаются.</para> 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TextCampaignFieldNamesList[] TextCampaignFieldNames { get; set; }

        /// <summary>
        /// Перечень доступных полей для запросов
        /// </summary>   
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextCampaignFieldNamesList { CounterIds, RelevantKeywords, Settings, BiddingStrategy }
        #endregion
        #region MobileAppCampaignFieldNames
        /// <summary>
        /// Имена параметров кампании с типом «Реклама мобильных приложений»
        ///<para>Примечание. Если согласно SelectionCriteria отобрана кампания другого типа, 
        /// параметры из MobileAppCampaignFieldNames не возвращаются.</para> 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public MobileAppCampaignFieldNamesList[] MobileAppCampaignFieldNames { get; set; }

        /// <summary>
        /// Перечень доступных полей для запросов
        /// </summary>       
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MobileAppCampaignFieldNamesList { Settings, BiddingStrategy }
        #endregion
        #region DynamicTextCampaignFieldNames
        /// <summary>
        /// Имена параметров кампании с типом «Динамические объявления»
        ///<para>Примечание. Если согласно SelectionCriteria отобрана кампания другого типа, 
        ///параметры из DynamicTextCampaignFieldNames не возвращаются.</para> 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DynamicTextCampaignFieldNamesList[] DynamicTextCampaignFieldNames { get; set; }
        /// <summary>
        /// Перечень доступных полей для запросов
        /// </summary>       
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DynamicTextCampaignFieldNamesList { CounterIds, Settings, BiddingStrategy }

        #endregion
       
    }

}
