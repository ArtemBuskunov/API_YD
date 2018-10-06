using API_Yandex_Direct.ApiConnect.Infrastructure;
using System;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.Shared
{
    [DataContract]
    public abstract class ParamsRequestAbstract : ParamsRequestAbstractNotPage
    {
        public ParamsRequestAbstract(Array enumsFieldNames) : base(enumsFieldNames) { }

        /// <summary>
        /// Постраничная выборка
        ///<para>Метод get возвращает не более 10 000 объектов за один запрос. Постраничное получение данных можно организовать с помощью структуры</para>
        ///<para>
        ///"Page": { "Limit": 200,"Offset": 600  }  -  будут возвращены объекты с 601-го по 800-й.
        ///</para>
        ///<para>
        ///|
        ///</para>
        ///<para>
        /// Если возвращенная страница — не последняя (в выборке остались еще объекты), то метод get возвращает поле LimitedBy — порядковый номер последнего возвращенного объекта. Чтобы получить следующую страницу, полученное значение LimitedBy нужно указать в качестве Offset при следующем вызове метода get с тем же SelectionCriteria.
        /// </para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public LimitOffset Page { get; set; }
    }

    [DataContract]
    public abstract class ParamsRequestAbstractNotPage
    {
        public ParamsRequestAbstractNotPage(Array enumsFieldNames)

        { FieldNames = Convert.EnumArrayToStringArray(enumsFieldNames); }
        /// <summary>
        /// Имена параметров верхнего уровня, которые требуется получить.
        /// </summary>
        [DataMember]
        public string[] FieldNames { get; set; }
    }


}
