using API_Yandex_Direct.Model.Infrastructure;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.CampaignI
{
    [DataContract]
    public class RelevantKeywordsSetting
    {
        /// <summary>
        /// Максимальный процент бюджета, расходуемый на клики по дополнительным релевантным фразам.
        ///<para>    Если структура RelevantKeywordsSetting ранее отсутствовала в кампании</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int BudgetPercent { get; set; }

        /// <summary>
        /// Идентификатор цели Яндекс.Метрики. Статистика конверсий по этой цели используется для оптимизации дополнительных релевантных фраз.
        ///<para> Подходят все цели, доступные для кампании, в том числе составные.Подробнее о целях см.раздел Цели и конверсии помощи Метрики. Список целей получают с помощью метода GetStatGoals API версии 4 или Live 4.</para>
        ///<para> Допустимы также следующие значения:</para>
        ///<para> 0 — оптимизация дополнительных релевантных фраз осуществляется по всем целям, доступным для кампании;</para>
        ///<para> null (nil) — оптимизация по целям не осуществляется.</para>
        ///<para> Если параметр не передан и в кампании отсутствовала структура RelevantKeywordsSetting(показы по дополнительным релевантным фразам были отключены), то значение по умолчанию — 0.</para>
        ///<para> Внимание! Если в кампании выбрана стратегия WB_MAXIMUM_CONVERSION_RATE, AVERAGE_CPA или AVERAGE_ROI, то независимо от значения параметра OptimizeGoalId оптимизация осуществляется по цели(или всем целям), указанной в параметре GoalId в настройках стратегии.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long? OptimizeGoalId { get; set; }
    }

}
