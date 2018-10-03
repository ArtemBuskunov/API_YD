using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    /// <summary>
    /// Тип группы задается при создании и недоступен для изменения.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdGroupSubtypeEnum
    {
        /// <summary>
        /// Для групп с типом, отличным от DYNAMIC_TEXT_AD_GROUP
        /// </summary>
        NONE,
        /// <summary>
        /// группа динамических объявлений.
        ///<para>источником данных для генерации объявлений являются страницы сайта.</para>
        ///<para>Для группы этого подтипа необходимо дополнительно указать рекламируемый домен.</para>        
        /// </summary>
        WEBPAGE,
        /// <summary>
        /// группа динамических объявлений.
        ///<para>источником данных для генерации объявлений является фид — файл с товарными предложениями.</para>
        ///<para>Создание и редактирование группы этого подтипа в настоящее время возможно только в веб-интерфейсе.</para>
        /// </summary>
        FEED
    }
}
