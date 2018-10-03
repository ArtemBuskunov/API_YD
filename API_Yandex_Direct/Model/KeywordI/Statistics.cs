using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.KeywordI
{
    /// <summary>
    /// Продуктивность фразы и рекомендации по ее повышению.
    /// </summary>
    [DataContract]
    public class Statistics
    {
        /// <summary>
        /// Количество кликов по всем объявлениям группы, показанным по данной фразе. Рассчитывается за 28 дней от текущей даты. Для расчета отбираются дни, в течение которых был хотя бы один клик по объявлению.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Clicks { get; set; }

        /// <summary>
        /// Количество показов всех объявлений группы по данной фразе. Рассчитывается за 28 дней от текущей даты. Для расчета отбираются дни, в течение которых был хотя бы один показ объявления по данной фразе.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Impressions { get; set; }
    }
}
