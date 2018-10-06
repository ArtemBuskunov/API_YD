using API_Yandex_Direct.Get.Shared;
using System;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.Bids
{
    [DataContract]
    public class ParamsRequest : ParamsRequestAbstract
    {
        public ParamsRequest(FieldNamesEnum[] enumsFieldNames) : base(enumsFieldNames as Array) { }
        /// <summary>
        /// Критерий отбора групп.
        /// </summary>
        [DataMember]
        public BidsSelectionCriteria SelectionCriteria { get; set; }
    }
}
