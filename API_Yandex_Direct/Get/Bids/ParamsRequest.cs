using API_Yandex_Direct.Get.Shared;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.Bids
{
    [DataContract]
    public class ParamsRequest : ParamsRequestAbstract
    {
        /// <summary>
        /// Критерий отбора групп.
        /// </summary>
        [DataMember]
        public BidsSelectionCriteria SelectionCriteria { get; set; }
    }
}
