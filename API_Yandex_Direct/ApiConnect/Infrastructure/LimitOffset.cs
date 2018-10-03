using System.Runtime.Serialization;

namespace API_Yandex_Direct.ApiConnect.Infrastructure
{
    /// <summary>
    /// Постраничная выборка
    ///<para>Метод get возвращает не более 10 000 объектов за один запрос. Постраничное получение данных можно организовать с помощью структуры</para>
    ///<para>
    ///"Page": { "Limit": 200,"Offset": 600  }  -  будут возвращены объекты с 601-го по 800-й.
    ///</para>
    ///<para>
    ///!
    ///</para>
    ///<para>
    /// Если возвращенная страница — не последняя (в выборке остались еще объекты), то метод get возвращает поле LimitedBy — порядковый номер последнего возвращенного объекта. Чтобы получить следующую страницу, полученное значение LimitedBy нужно указать в качестве Offset при следующем вызове метода get с тем же SelectionCriteria.
    /// </para>
    /// </summary>
    [DataContract]
    public class LimitOffset
    {
        /// <summary>
        /// Количество возвращаемых объектов (размер страницы). От 0 до 10 000. Если не указано, используется ограничение 10 000.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Limit { get; set; }

        /// <summary>
        /// Количество объектов, которое должно быть пропущено при выборке. Если не указано, подразумевается 0.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Offset { get; set; }
    }
}
