using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.CampaignI
{
    /// <summary>
    /// Настройки дневного бюджета кампании.
    /// <para>  Управление дневным бюджетом доступно, если в кампании выбрана ручная стратегия показа, 
    /// а также в параметре Settings, возвращаемом методом get, присутствует настройка DAILY_BUDGET_ALLOWED со значением YES.
    /// В противном случае при попытке задать дневной бюджет возвращается ошибка.</para>
    /// </summary>
    [DataContract]
    public class DailyBudgetClass
    {
        /// <summary>
        /// Дневной бюджет кампании в валюте рекламодателя, умноженный на 1 000 000.
        /// <para>    Минимальный дневной бюджет для каждой валюты представлен в справочнике валют.
        /// Справочник валют можно получить с помощью метода Dictionaries.get.</para>
        /// </summary>
        [DataMember]
        public long Amount { get; set; }

        /// <summary>
        /// DISTRIBUTED — распределять дневной бюджет равномерно на весь день.
        /// <para>  STANDARD — дневной бюджет может исчерпаться, а показы завершиться ранее окончания дня.</para>
        /// </summary>
        [DataMember]
        public DailyBudgetModeEnum Mode { get; set; }
    }
}
