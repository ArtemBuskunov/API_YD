using API_Yandex_Direct.ApiConnect.Infrastructure;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Create.ForecastReport
{
    public class CreateForecastReport : Result4
    {
        /// <summary>
        /// Возвращает сформированный прогноз показов, кликов и затрат по его идентификатору.
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public int IdRequest { get; set; }

        public override object loaddate(string sdsf)
        {
            CreateForecastReport s = 
                Newtonsoft.Json.JsonConvert.DeserializeObject<CreateForecastReport>(sdsf);


            if (s != null && (s.error_code == null || s.error_code == "")) { return s.IdRequest; }
            return null;
        }
    }
}
