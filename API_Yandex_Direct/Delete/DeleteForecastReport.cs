using API_Yandex_Direct.Delete.ForecastReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Yandex_Direct.Delete
{
    public class DeleteForecastReport
    {
        public int DeleteForecastReportRequest(ApiConnect.ApiConnect apiConnect, int IdRequest)
        {
            string[] Headers = new string[] { };
            DeleteForecastReportId report = new DeleteForecastReportId();
            return (int)apiConnect.GetResult4(IdRequest, "", "DeleteForecastReport", ref Headers, report).Data;
        }

        /// <summary>
        ///  Units указано количество баллов: израсходовано при выполнении запроса / доступный остаток / суточный лимит.
        /// </summary>
        public string Units = "";
    }
}
