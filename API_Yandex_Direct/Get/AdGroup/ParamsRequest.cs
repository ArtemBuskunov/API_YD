using API_Yandex_Direct.Get.Shared;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.AdGroup
{
    [DataContract]
    public class ParamsRequest : ParamsRequestAbstract
    {
        /// <summary>
        /// Критерий отбора групп.
        /// </summary>
        [DataMember]
        public AdGroupsSelectionCriteria SelectionCriteria { get; set; }
            
        /// <summary>
        /// Имена параметров группы для рекламы мобильных приложений, которые требуется получить.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public MobileAppAdGroupFieldEnum[] MobileAppAdGroupFieldNames { get; set; }
        
        /// <summary>
        /// Имена параметров группы динамических объявлений, для которых источником данных является сайт.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DynamicTextAdGroupFieldEnum[] DynamicTextAdGroupFieldNames { get; set; }

        /// <summary>
        /// Имена параметров группы динамических объявлений, для которых источником данных является фид. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DynamicTextFeedAdGroupFieldEnum[] DynamicTextFeedAdGroupFieldNames { get; set; }
    }

}
