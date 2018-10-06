using API_Yandex_Direct.Get.Shared;
using System;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.Client
{
    [DataContract]
    public class ParamsRequest : ParamsRequestAbstractNotPage
    {
        public ParamsRequest(FieldNamesEnum[] enumsFieldNames) : base(enumsFieldNames as Array) { }
    }
}
