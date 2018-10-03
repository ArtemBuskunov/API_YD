using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.Forecast
{
    [DataContract]
    public class GetForecastInfo
    {
        /// <summary>
        /// Массив объектов BannerPhraseInfo. Каждый объект содержит прогноз по одной фразе, указанной при формировании отчета 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public BannerPhraseInfo[] Phrases { get; set; }

        /// <summary>
        /// Объект ForecastCommonInfo с суммарным прогнозом по всем фразам.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ForecastCommonInfo Common { get; set; }
    }
}
