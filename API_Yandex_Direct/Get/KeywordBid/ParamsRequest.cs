using API_Yandex_Direct.Get.Shared;
using System;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.KeywordBid
{
    [DataContract]
    public class ParamsRequest : ParamsRequestAbstract
    {
        public ParamsRequest(FieldNamesEnum[] enumsFieldNames) : base(enumsFieldNames as Array) { }
        /// <summary>
        /// Критерий отбора групп.
        /// </summary>
        [DataMember]
        public KeywordBidsSelectionCriteria SelectionCriteria { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public KeywordBidSearchFieldEnum[] SearchFieldNames { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public KeywordBidNetworkFieldEnum[] NetworkFieldNames { get; set; }



    }
}
