using API_Yandex_Direct.ApiConnect.Infrastructure;
using API_Yandex_Direct.Model.Forecast;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Get.Forecast
{
    public class GetForecastList : Result4
    {
        /// <summary>
        /// Возвращает сформированный прогноз показов, кликов и затрат по его идентификатору.
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public ForecastStatusInfo[] ForecastStatusInfo { get; set; }

        public override object loaddate(string sdsf)
        {
            GetForecastList s = Newtonsoft.Json.JsonConvert.DeserializeObject<GetForecastList>(sdsf);
            
            if (s != null && (s.error_code == null || s.error_code == "")) { return s.ForecastStatusInfo; }
            return null;
        }
    }
}
