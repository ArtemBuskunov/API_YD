using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.Report
{
    [DataContract]
    public class OrderBy
    {
        /// <summary>
        /// Имя поля, которое используется для сортировки.
        /// </summary>
        [DataMember]
        public FieldNamesEnum Field { get; set; }

        /// <summary>
        /// Направление сортировки:
        /// <para>Если не задано, выполняется сортировка по возрастанию.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public OrderBySortOrderEnum SortOrder { get; set; }
    }


}
