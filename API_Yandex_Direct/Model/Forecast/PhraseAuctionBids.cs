using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.Forecast
{
    [DataContract]
    public class PhraseAuctionBids
    {
        /// <summary>
        /// Позиция показа: Pmn, где 
        ///<para> m — номер блока(1 — спецразмещение, 2 — блок гарантированных показов);</para>
        /// <para> n — номер позиции в рамках блока.</para>
        /// <para> Например, P12 — второе место в спецразмещении, P21 — первое место в блоке гарантированных показов.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Position { get; set; }

        /// <summary>
        ///  Минимальная ставка за указанную позицию (в валюте, указанной в параметре Currency).
        /// <para> Значение конвертируется в валюту, указанную в параметре Currency, и округляется вверх с точностью до шага торгов в этой валюте(см.раздел Реальные валюты вместо у.е.).</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public float Bid { get; set; }

        /// <summary>
        /// Списываемая цена для указанной позиции(в валюте, указанной в параметре Currency).
        /// <para>Значение конвертируется в валюту, указанную в параметре Currency, и округляется вверх с точностью до шага торгов в этой валюте(см.раздел Реальные валюты вместо у.е.).</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public float Price { get; set; }
    }

}
