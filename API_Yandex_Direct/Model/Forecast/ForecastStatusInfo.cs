using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.Forecast
{
    [DataContract]
    public class ForecastStatusInfo
    {
        /// <summary>
        /// Идентификатор отчета.
        /// </summary>
        [DataMember]
        public int ForecastID { get; set; }

        /// <summary>
        ///  Состояние отчета:

        /// </summary>
        [DataMember]
        public StatusForecast StatusForecast { get; set; }


    }
}
