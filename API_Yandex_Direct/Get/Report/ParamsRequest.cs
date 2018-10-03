using API_Yandex_Direct.Get.Shared;
using API_Yandex_Direct.Model.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.Report
{
    [DataContract]
    public class ParamsRequest : ParamsRequestAbstract
    {
        /// <summary>
        /// Критерии отбора данных для отчета.
        /// </summary>
        [DataMember]
        public SelectionCriteria SelectionCriteria { get; set; }

        /// <summary>
        /// Имена полей (столбцов), по которым требуется отсортировать строки в отчете.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public OrderBy[] OrderBy { get; set; }

        /// <summary>
        /// Название отчета.Выводится в первой строке отчета.
        /// <para>В режиме офлайн название отчета должно быть уникальным для рекламодателя. Если отчет с таким названием, но с отличающимися параметрами уже сформирован или находится в очереди, выдается ошибка.</para>
        /// </summary>
        [DataMember]
        public string ReportName { get; set; }

        /// <summary>
        /// Тип отчета.
        /// </summary>
        [DataMember]
        public ReportTypeEnum ReportType { get; set; }

        /// <summary>
        /// Период, за который формируется отчет.
        /// </summary>
        [DataMember]
        public DateRangeTypeEnum DateRangeType { get; set; }

        /// <summary>
        /// Формат отчета. В настоящее время поддерживается только значение TSV.
        /// </summary>
        [DataMember]
        public FormatEnum Format { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum { TSV }

        /// <summary>
        /// Включать ли НДС в денежные суммы в отчете.
        ///<para> Если рекламодатель работает в у.е.Директа, допускается только значение YES.</para>
        /// </summary>
        [DataMember]
        public YesNoEnum2 IncludeVAT { get; set; }

        /// <summary>
        /// Учитывать ли скидку для денежных сумм в отчете.
        /// <para>Если рекламодатель работает в у. е. Директа, допускается только значение NO.</para>
        /// </summary>
        [DataMember]
        public YesNoEnum2 IncludeDiscount { get; set; }
    }
}
