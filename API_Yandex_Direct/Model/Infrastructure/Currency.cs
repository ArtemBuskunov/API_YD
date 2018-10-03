using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.Infrastructure
{
    /// <summary>
    /// Курсы валют, валютные параметры и ограничения.
    /// </summary>
    [DataContract]
    public class CurrencyClass
    {
        /// <summary>
        /// Обозначение валюты (параметр кампании Currency).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Наименование и значение валютного параметра:
        /// <para> FullName — название валюты на языке, указанном в запросе в HTTP-заголовке </para>
        /// <para> BidIncrement — шаг торгов;</para>
        /// <para> MaximumBid — максимальная ставка;</para>
        /// <para> MinimumAverageCPA — минимальное значение средней цены конверсии для стратегии</para>
        /// <para> MinimumAverageCPC — минимальное значение средней цены клика для стратегий </para>
        /// <para> MinimumBid — минимальная ставка;</para>
        /// <para> MinimumDailyBudget — минимальный дневной бюджет;</para>
        /// <para> MinimumPayment — минимальный платеж (без учета НДС);</para>
        /// <para> MinimumTransferAmount — минимальная сумма перевода между кампаниями;</para>
        /// <para> MinimumWeeklySpendLimit — минимальный недельный бюджет;</para>
        /// <para> Rate — стоимость 1 у. е. без учета НДС;</para>
        /// <para> RateWithVAT — стоимость 1 у. е. с учетом НДС.</para>
        /// <para></para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ConstantsItem[] Properties { get; set; }



    }

}
