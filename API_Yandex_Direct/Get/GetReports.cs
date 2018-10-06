using API_Yandex_Direct.Get.Report;
using API_Yandex_Direct.Get.Shared;
using API_Yandex_Direct.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_Yandex_Direct.Get
{
    public class GetReport : GetAbstract
    {
        public List<string[]> GetReports(ParamsRequest paramsRequest, ApiConnect.ApiConnect apiConnect)
        {
            List<string> listHeaders = null;
            List<string[]> listResult = new List<string[]>();
            paramsRequest.ReportName = apiConnect.UserRequest.loginClient + DateTime.Now.Ticks.ToString();

            do
            {
                if (listHeaders != null)
                {
                    int ii = 0;
                    int.TryParse(listHeaders.Find(p => p.IndexOf("retryIn") == 0).Replace("retryIn : ", ""), out ii);
                    System.Threading.Thread.Sleep(ii * 1000);
                }

                string[] Headers = new string[] {
                "processingMode: offline",
                "skipColumnHeader: true" ,
                "skipReportSummary: true",
                "returnMoneyInMicros: false" };

                listResult.AddRange(apiConnect.RequestReport(paramsRequest, "reports", "", ref Headers));
                listHeaders = Headers.ToList();
            }
            while (listHeaders.Exists(p => p == "HttpStatusCode : Created") || listHeaders.Exists(p => p == "HttpStatusCode : Accepted"));

            if (listHeaders.Exists(p => p == "HttpStatusCode : OK")) { return listResult; }
            if (listHeaders.Exists(p => p == "HttpStatusCode : BadRequest") || listHeaders.Exists(p => p == "HttpStatusCode : InternalServerError"))           { return null; }
            return null;
        }


        public List<string[]> GetReports(FieldNamesEnum[] SetParamsRequest, ReportTypeEnum reportTypeEnum, ApiConnect.ApiConnect apiConnect)
        {
            ParamsRequest paramsRequest = new ParamsRequest(SetParamsRequest)
            {
                SelectionCriteria = new SelectionCriteria { Filter = null },
                ReportName = "Actual1",
                ReportType = reportTypeEnum,
                DateRangeType = DateRangeTypeEnum.LAST_30_DAYS,
                Format = ParamsRequest.FormatEnum.TSV,
                IncludeVAT = YesNoEnum2.YES,
                IncludeDiscount = YesNoEnum2.NO
            };
            return GetReports(paramsRequest, apiConnect);
        }
    }
}
