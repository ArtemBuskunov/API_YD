using API_Yandex_Direct.Get.Shared;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.Keywords
{
    [DataContract]
    public class ParamsRequest : ParamsRequestAbstract
    {
        /// <summary>
        /// Критерий отбора групп.
        /// </summary>
        [DataMember]
        public KeywordsSelectionCriteria SelectionCriteria { get; set; }
    }
}
