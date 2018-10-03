using API_Yandex_Direct.Model.Infrastructure;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.CampaignI
{
    /// <summary>
    /// Параметры стратегии «Ставка в сети устанавливается в зависимости от ставки на поиск».
    /// </summary>
    [DataContract]
    public class StrategyNetworkDefault
    {
        /// <summary>
        /// Максимальный процент бюджета, расходуемый на показы в сетях. Значение кратно десяти: 10, 20, ..., 100. Значение по умолчанию — 100.
        /// </summary>
        [DataMember]
        public int LimitPercent { get; set; }

        /// <summary>
        ///  Ограничение ставки в сетях. Задается в процентах от ставки на поиске. Значение кратно десяти: 10, 20, ..., 100. Значение 100 делает ставку в сетях равной цене на поиске. Значение по умолчанию — 100.
        /// </summary>
        [DataMember]
        public int BidPercent { get; set; }
    }

    /// <summary>
    /// Параметры стратегии Недельный бюджет (максимум кликов).
    /// </summary>
    [DataContract]
    public class StrategyMaximumClicks
    {
        /// <summary>
        /// Недельный бюджет в валюте рекламодателя, умноженный на 1 000 000.
        /// </summary>
        [DataMember]
        public long WeeklySpendLimit { get; set; }

        /// <summary>
        /// Максимальная ставка в валюте рекламодателя, умноженная на 1 000 000.
        ///<para> Минимальное и максимальное значение ставки для каждой валюты представлены в справочнике валют.Справочник валют можно получить с помощью метода Dictionaries.get.</para>   
        /// </summary>
        [DataMember]
        public long? BidCeiling { get; set; }

    }

    /// <summary>
    /// Параметры стратегии Недельный бюджет (максимальная конверсия).
    /// </summary>
    [DataContract]
    public class StrategyMaximumConversionRate
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public long WeeklySpendLimit { get; set; }

        /// <summary>
        /// Идентификатор цели Яндекс.Метрики (подходят только несоставные цели). Подробнее о целях см. раздел Цели и конверсии помощи Метрики.
        ///<para>Значение 0 — все цели, настроенные на сайте (кроме составных).</para>
        /// </summary>
        [DataMember]
        public long GoalId { get; set; }

        /// <summary>
        /// Максимальная ставка в валюте рекламодателя, умноженная на 1 000 000.
        ///<para>Минимальное и максимальное значение ставки для каждой валюты представлены в справочнике валют. Справочник валют можно получить с помощью метода Dictionaries.get. </para>   
        /// </summary>
        [DataMember]
        public long? BidCeiling { get; set; }
    }

    /// <summary>
    /// Параметры стратегии Средняя цена клика.
    /// </summary>
    [DataContract]
    public class StrategyAverageCpc
    {
        /// <summary>
        /// Средняя цена клика в валюте рекламодателя, умноженная на 1 000 000.
        ///<para> Минимальное значение средней цены для каждой валюты представлено в справочнике валют. Справочник валют можно получить с помощью метода Dictionaries.get.</para>   
        /// </summary>
        [DataMember]
        public long AverageCpc { get; set; }

        /// <summary>
        /// Недельный бюджет в валюте рекламодателя, умноженный на 1 000 000.
        ///<para> Минимальный недельный бюджет для каждой валюты представлен в справочнике валют. Справочник валют можно получить с помощью метода Dictionaries.get.</para>   
        /// </summary>
        [DataMember]
        public long? WeeklySpendLimit { get; set; }
    }

    /// <summary>
    /// Параметры стратегии Средняя цена конверсии.
    /// </summary>
    [DataContract]
    public class StrategyAverageCpa
    {
        /// <summary>
        /// Средняя цена достижения цели в валюте рекламодателя, умноженная на 1 000 000.
        ///<para>Минимальное значение средней цены для каждой валюты представлено в справочнике валют. Справочник валют можно получить с помощью метода Dictionaries.get.</para>   
        /// </summary>
        [DataMember]
        public long AverageCpa { get; set; }

        /// <summary>
        /// Идентификатор цели Яндекс.Метрики (подходят только несоставные цели). Подробнее о целях см. раздел Цели и конверсии помощи Метрики.
        ///<para>Значение 0 — все цели, настроенные на сайте (кроме составных). </para>   
        /// </summary>
        [DataMember]
        public long GoalId { get; set; }

        /// <summary>
        /// 	                Недельный бюджет в валюте рекламодателя, умноженный на 1 000 000.
        ///<para>  Минимальный недельный бюджет для каждой валюты представлен в справочнике валют. Справочник валют можно получить с помощью метода Dictionaries.get.</para>   
        /// </summary>
        [DataMember]
        public long? WeeklySpendLimit { get; set; }

        /// <summary>
        /// Максимальная ставка в валюте рекламодателя, умноженная на 1 000 000.
        ///<para>Минимальное и максимальное значение ставки для каждой валюты представлены в справочнике валют. Справочник валют можно получить с помощью метода Dictionaries.get.</para>   
        /// </summary>
        [DataMember]
        public long? BidCeiling { get; set; }
    }

    /// <summary>
    /// Параметры стратегии Средняя рентабельность инвестиций.
    /// </summary>
    [DataContract]
    public class StrategyAverageRoi
    {
        /// <summary>
        /// Максимальный процент сэкономленных средств, который можно возвращать в рекламу (расходовать) в случае, если прогнозируемое значение рентабельности превышает значение параметра RoiCoef.
        /// </summary>
        [DataMember]
        public int ReserveReturn { get; set; }
        /// <summary>
        /// Желаемая средняя рентабельность инвестиций за неделю. Значение представляет собой отношение прибыли от продаж к расходам на рекламу, умноженное на 1 000 000. Значение должно быть целым числом. Если значение не кратно 10 000, последние 4 цифры обнуляются (что соответствует отбрасыванию лишних знаков после запятой).
        /// </summary>
        [DataMember]
        public long RoiCoef { get; set; }
        /// <summary>
        /// 	                Идентификатор цели Яндекс.Метрики(подходят только несоставные цели). Подробнее о целях см.раздел Цели и конверсии помощи Метрики.
        /// </summary>
        [DataMember]
        public long GoalId { get; set; }
        /// <summary>
        /// 	                Недельный бюджет в валюте рекламодателя, умноженный на 1 000 000.
        /// </summary>
        [DataMember]
        public long? WeeklySpendLimit { get; set; }
        /// <summary>
        /// Максимальная ставка в валюте рекламодателя, умноженная на 1 000 000.
        /// </summary>
        [DataMember]
        public long? BidCeiling { get; set; }
        /// <summary>
        /// Процент выручки, являющийся себестоимостью товаров или услуг.
        /// <para>Значение представляет собой процент, умноженный на 1 000 000. Значение должно быть целым числом от 0 до 100 000 000 (что соответствует 100%). Если значение не кратно 10 000, последние 4 цифры обнуляются (что соответствует отбрасыванию лишних знаков после запятой).</para>
        /// </summary>
        [DataMember]
        public long? Profitability { get; set; }

    }

    /// <summary>
    /// Параметры стратегии Недельный пакет кликов.
    /// </summary>
    [DataContract]
    public class StrategyWeeklyClickPackage
    {
        /// <summary>
        /// Требуемое количество кликов в неделю.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long ClicksPerWeek { get; set; }
        /// <summary>
        /// Средняя цена клика в валюте рекламодателя, умноженная на 1 000 000.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long? AverageCpc { get; set; }
        /// <summary>
        /// Максимальная ставка в валюте рекламодателя, умноженная на 1 000 000.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long? BidCeiling { get; set; }
    }
}
