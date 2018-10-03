using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.Report
{
    [DataContract]
    public class FilterItem
    {
        /// <summary>
        /// Имя поля, которое используется для фильтрации данных. Каждое поле можно использовать только в одном фильтре: несколько фильтров с одним и тем же полем не допускается.
        /// </summary>
        [DataMember]
        public FieldNamesEnum Field { get; set; }
        /// <summary>
        /// Оператор, используемый для фильтрации данных
        /// <para>Операторы EQUALS, NOT_EQUALS, IN, NOT_IN для полей Keyword и Query не учитывают регистр, для остальных полей — учитывают регистр.</para>
        /// <para>Операторы STARTS_WITH_IGNORE_CASE, DOES_NOT_START_WITH_IGNORE_CASE, STARTS_WITH_ANY_IGNORE_CASE, DOES_NOT_START_WITH_ALL_IGNORE_CASE не учитывают регистр.</para>
        /// </summary>
        [DataMember]
        public FilterOperatorEnum Operator { get; set; }
        /// <summary>
        /// Значения, используемые для фильтрации данных. Не более 10 000 элементов в массиве.
        /// <para>Все денежные значения следует указывать в виде целых чисел: сумм в валюте, умноженных на 1 000 000 (независимо от наличия заголовка returnMoneyInMicros: false).</para>
        /// </summary>
        [DataMember]
        public string[] Values { get; set; }
    }
}
