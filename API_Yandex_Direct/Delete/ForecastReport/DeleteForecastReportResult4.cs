using API_Yandex_Direct.ApiConnect.Infrastructure;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Delete.ForecastReport
{
    public class DeleteForecastReportId : Result4
    {
        /// <summary>
        /// Возвращает сформированный прогноз показов, кликов и затрат по его идентификатору.
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public int IdRequest { get; set; }

        public override object loaddate(string sdsf)
        {
            DeleteForecastReportId s = Newtonsoft.Json.JsonConvert.DeserializeObject<DeleteForecastReportId>(sdsf);
            
            if (s != null && (s.error_code == null || s.error_code == "")) { return s.IdRequest; }
            return null;
        }
    }
}
