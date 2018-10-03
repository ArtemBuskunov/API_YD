using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.Report
{
    [DataContract]
    public class SelectionCriteria
    {
        /// <summary>
        /// Начальная дата отчетного периода, YYYY-MM-DD.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string DateFrom { get; set; }

        /// <summary>
        /// Конечная дата отчетного периода, YYYY-MM-DD.
        /// <para>Параметры DateFrom и DateTo обязательны при значении CUSTOM_DATE параметра DateRangeType и недопустимы при других значениях.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string DateTo { get; set; }

        /// <summary>
        /// Фильтры
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public FilterItem[] Filter { get; set; }
    }
}
