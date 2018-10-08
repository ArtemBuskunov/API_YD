using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextCampaignSettingsEnum : byte
    {

        ADD_METRICA_TAG,

        ADD_OPENSTAT_TAG,

        ADD_TO_FAVORITES,

        ENABLE_AREA_OF_INTEREST_TARGETING,

        ENABLE_COMPANY_INFO,

        ENABLE_EXTENDED_AD_TITLE,
        /// <summary>
        /// Останавливать показы при недоступности сайта рекламодателя (см. раздел Мониторинг доступности сайтов помощи Директа).  Отсутствие настройки эквивалентно значению NO.
        /// </summary>
        ENABLE_SITE_MONITORING,
        /// <summary>
        /// Рассчитывать минимальные ставки за позиции показа без учета ставок в объявлениях конкурентов, остановленных в соответствии с временным таргетингом.        Отсутствие настройки эквивалентно значению NO.
        /// </summary>
        EXCLUDE_PAUSED_COMPETING_ADS,
        /// <summary>
        /// Удерживать среднюю цену клика в сетях ниже средней цены на поиске.        Отсутствие настройки эквивалентно значению YES.
        /// </summary>
        MAINTAIN_NETWORK_CPC,
        /// <summary>
        /// Перевести кампанию на обслуживание персональным менеджером.
        /// <para> Если у рекламодателя нет кампаний, обслуживаемых менеджером, можно установить только значение NO. При попытке установить значение YES устанавливается значение NO и выдается предупреждение. Отсутствие настройки эквивалентно значению NO.</para>
        /// <para>Если у рекламодателя уже есть хотя бы одна кампания, обслуживаемая менеджером, допустимо указать любое значение — YES или NO. Отсутствие настройки эквивалентно значению YES. Изменить значение с YES на NO нельзя.</para>
        /// </summary>
        REQUIRE_SERVICING,
        /// <summary>
        /// Подключен общий счет.
        /// </summary>
        SHARED_ACCOUNT_ENABLED,
        /// <summary>
        /// Доступно управление дневным бюджетом кампании.
        /// </summary>
        DAILY_BUDGET_ALLOWED
    }

}
