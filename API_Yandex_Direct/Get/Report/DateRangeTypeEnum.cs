using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Yandex_Direct.Get.Report
{

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DateRangeTypeEnum
    {
        /// <summary>
        ///  — текущий день;
        /// </summary>
        TODAY,
        /// <summary>
        ///  — вчера;
        /// </summary>
        YESTERDAY,
        /// <summary>
        /// — указанное количество предыдущих дней, не включая текущий день;
        /// </summary>
        LAST_3_DAYS,
        /// <summary>
        /// — указанное количество предыдущих дней, не включая текущий день;
        /// </summary> 
        LAST_5_DAYS,
        /// <summary>
        /// — указанное количество предыдущих дней, не включая текущий день;
        /// </summary>
        LAST_7_DAYS,
        /// <summary>
        /// — указанное количество предыдущих дней, не включая текущий день;
        /// </summary>
        LAST_14_DAYS,
        /// <summary>
        /// — указанное количество предыдущих дней, не включая текущий день;
        /// </summary>
        LAST_30_DAYS,
        /// <summary>
        /// — указанное количество предыдущих дней, не включая текущий день;
        /// </summary>
        LAST_90_DAYS,
        /// <summary>
        /// — указанное количество предыдущих дней, не включая текущий день;
        /// </summary>
        LAST_365_DAYS,
        /// <summary>
        ///  — текущая неделя начиная с понедельника, включая текущий день;
        /// </summary>
        THIS_WEEK_MON_TODAY,
        /// <summary>
        /// — текущая неделя начиная с воскресенья, включая текущий день;
        /// </summary>
        THIS_WEEK_SUN_TODAY,
        /// <summary>
        ///  — прошлая неделя с понедельника по воскресенье;
        /// </summary>        
        LAST_WEEK,
        /// <summary>
        /// — прошлая рабочая неделя с понедельника по пятницу;
        /// </summary>        
        LAST_BUSINESS_WEEK,
        /// <summary>
        ///  — прошлая неделя с воскресенья по субботу;
        /// </summary>
        LAST_WEEK_SUN_SAT,
        /// <summary>
        ///    — текущий месяц;
        /// </summary>        
        THIS_MONTH,
        /// <summary>
        ///  — предыдущий месяц;
        /// </summary>     
        LAST_MONTH,
        /// <summary>
        /// — вся доступная статистика, включая текущий день;
        /// </summary>        
        ALL_TIME,
        /// <summary>
        ///   — произвольный период. При выборе этого значения необходимо указать даты начала и окончания периода в параметрах DateFrom и DateTo.
        /// </summary>        
        CUSTOM_DATE,
        /// <summary>
        ///  — период, за который статистика могла измениться. Период выбирается автоматически в зависимости от того, произошла ли в предыдущий день корректировка статистики. Подробнее см. в разделе Как получить актуальную статистику.
        /// </summary>       
        AUTO
    }

}
