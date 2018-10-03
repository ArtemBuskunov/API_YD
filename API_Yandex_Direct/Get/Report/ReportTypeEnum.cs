using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Get.Report
{

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReportTypeEnum
    {
        /// <summary>
        /// Статистика по аккаунту рекламодателя
        /// </summary>
        ACCOUNT_PERFORMANCE_REPORT,
        /// <summary>
        /// Статистика по кампаниям
        /// </summary>
        CAMPAIGN_PERFORMANCE_REPORT,
        /// <summary>
        /// Статистика по группам объявлений
        /// </summary>
        ADGROUP_PERFORMANCE_REPORT,
        /// <summary>
        /// Статистика по объявлениям
        /// </summary>
        AD_PERFORMANCE_REPORT,
        /// <summary>
        /// Статистика по условиям показа
        /// </summary>
        CRITERIA_PERFORMANCE_REPORT,
        /// <summary>
        /// Статистика с произвольными группировками
        /// </summary>
        CUSTOM_REPORT,
        /// <summary>
        /// Статистика по поисковым запросам
        /// </summary>
        SEARCH_QUERY_PERFORMANCE_REPORT
    }

}
