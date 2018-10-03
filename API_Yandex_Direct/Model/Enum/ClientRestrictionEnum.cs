using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Model.Enum
{
    /// <summary>
    ///  Имя ограничения
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClientRestrictionEnum
    {
        /// <summary>
        /// максимальное количество кампаний у рекламодателя.
        /// </summary>
        CAMPAIGNS_TOTAL_PER_CLIENT,
        /// <summary>
        /// максимальное количество кампаний, не находящихся в архиве.
        /// </summary>
        CAMPAIGNS_UNARCHIVED_PER_CLIENT,
        /// <summary>
        /// максимальное количество групп в кампании.
        /// </summary>
        ADGROUPS_TOTAL_PER_CAMPAIGN,
        /// <summary>
        /// максимальное количество объявлений в группе.
        /// </summary>
        ADS_TOTAL_PER_ADGROUP,
        /// <summary>
        /// максимальное количество ключевых фраз в группе.
        /// </summary>
        KEYWORDS_TOTAL_PER_ADGROUP,
        /// <summary>
        /// максимальное количество расширений к объявлениям у рекламодателя.
        /// </summary>
        AD_EXTENSIONS_TOTAL,
        /// <summary>
        /// максимальное количество одновременно формируемых статистических отчетов.
        /// </summary>
        STAT_REPORTS_TOTAL_IN_QUEUE,
        /// <summary>
        /// максимальное количество хранимых на сервере отчетов о прогнозируемом бюджете, количестве показов и кликов.
        /// </summary>
        FORECAST_REPORTS_TOTAL_IN_QUEUE,
        /// <summary>
        /// максимальное количество хранимых на сервере отчетов о статистике поисковых запросов.
        /// </summary>
        WORDSTAT_REPORTS_TOTAL_IN_QUEUE,
        /// <summary>
        /// суточный лимит баллов.
        /// </summary>
        API_POINTS
    }
}
