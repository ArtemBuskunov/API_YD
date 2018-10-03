using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.Forecast
{
    [DataContract]
    public class BannerPhraseInfo
    {
        /// <summary>
        ///   Ключевая фраза, для которой составлен прогноз.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Phrase { get; set; }

        /// <summary>
        /// Признак того, что фраза является рубрикой Яндекс.Каталога.Всегда содержит значение No.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string IsRubric { get; set; }

        /// <summary>
        /// Средневзвешенная цена клика в нижнем блоке на момент составления прогноза.
        ///<para>Значение конвертируется в валюту, указанную в параметре Currency, и округляется вверх с точностью до шага торгов в этой валюте (см.раздел Реальные валюты вместо у. е.).</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public float Min { get; set; }

        /// <summary>
        /// Средневзвешенная цена клика на первом месте в нижнем блоке на момент составления прогноза.
        /// <para>Значение конвертируется в валюту, указанную в параметре Currency, и округляется вверх с точностью до шага торгов в этой валюте(см.раздел Реальные валюты вместо у.е.).</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public float Max { get; set; }

        /// <summary>
        ///    Средневзвешенная цена клика в спецразмещении на момент составления прогноза.
        /// <para>Значение конвертируется в валюту, указанную в параметре Currency, и округляется вверх с точностью до шага торгов в этой валюте(см.раздел Реальные валюты вместо у.е.).</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public float PremiumMin { get; set; }

        /// <summary>
        ///  Средневзвешенная цена клика на первом месте в спецразмещении на момент составления прогноза.
        ///  <para>Значение конвертируется в валюту, указанную в параметре Currency, и округляется вверх с точностью до шага торгов в этой валюте(см.раздел Реальные валюты вместо у.е.).</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public float PremiumMax { get; set; }

        /// <summary>
        ///  Возможное количество показов объявления по данной фразе за прошедший месяц.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int Shows { get; set; }

        /// <summary>
        /// Возможное количество кликов по объявлению в нижнем блоке(кроме первого места) за прошедший месяц.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int Clicks { get; set; }

        /// <summary>
        /// Возможное количество кликов по объявлению на первом месте в нижнем блоке, за прошедший месяц.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int FirstPlaceClicks { get; set; }

        /// <summary>
        /// Возможное количество кликов по объявлению в спецразмещении за прошедший месяц.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int PremiumClicks { get; set; }

        /// <summary>
        /// CTR при показе в нижнем блоке, в процентах.Рассчитывается по формуле: Clicks/Shows* 100
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public float CTR { get; set; }

        /// <summary>
        ///  CTR при показе на первом месте в нижнем блоке.Рассчитывается по формуле:FirstPlaceClicks/Shows* 100
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public float FirstPlaceCTR { get; set; }

        /// <summary>
        /// CTR при показе в спецразмещении.Рассчитывается по формуле: PremiumClicks/Shows* 100
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string PremiumCTR { get; set; }

        /// <summary>
        /// Валюта, в которой выражены цены клика и суммарные затраты в отчете.
        ///<para>Возможные значения: RUB, CHF, EUR, KZT, TRY, UAH, USD, BYN.Если параметр отсутствует или равен NULL, подразумеваются условные единицы (у.е.).</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Массив объектов PhraseAuctionBids, содержащий результаты торгов по фразе: ставку за каждую позицию в спецразмещении и в нижнем блоке, а также списываемую цену для каждой позиции.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public PhraseAuctionBids[] AuctionBids { get; set; }
    }


}
