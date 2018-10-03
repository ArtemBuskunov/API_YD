using API_Yandex_Direct.Get.Report;
using API_Yandex_Direct.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_Yandex_Direct.Get
{
    public class GetReports
    {
        public List<string[]> GetReport(
            FieldNamesEnum[] SetParamsRequest, string[] CampageIds, ApiConnect.ApiConnect apiConnect)
        {
            List<string[]> list = new List<string[]>();

            string[] pr = new string[SetParamsRequest.Length];
            for (int i = 0; i < SetParamsRequest.Length; i++) { pr[i] = SetParamsRequest[i].ToString(); }
            paramsRequest.FieldNames = pr;

            paramsRequest.ReportName = apiConnect.UserRequest.loginClient + DateTime.Now.Ticks.ToString();
            ret1:
            string[] Headers = new string[] {
                "processingMode: offline",
                "skipColumnHeader: true" ,
                "skipReportSummary: true",
                "returnMoneyInMicros: false"
            };



            List<string[]> listResult = apiConnect.RequestReport(paramsRequest, "reports", "", ref Headers);

            List<string> listHeaders = Headers.ToList();
            if (listHeaders.Exists(p => p == "HttpStatusCode : Created") ||
                listHeaders.Exists(p => p == "HttpStatusCode : Accepted"))
            {
                int ii = 0;
                Int32.TryParse(listHeaders.Find(p => p.IndexOf("retryIn") == 0).Replace("retryIn : ", ""), out ii);
                System.Threading.Thread.Sleep(ii * 1000);
                goto ret1;
            }
            if (listHeaders.Exists(p => p == "HttpStatusCode : OK")) { return listResult; }
            if (listHeaders.Exists(p => p == "HttpStatusCode : BadRequest")) { return null; }
            if (listHeaders.Exists(p => p == "HttpStatusCode : InternalServerError")) { return null; }


            return null;
        }

        /// <summary>
        ///  Units указано количество баллов: израсходовано при выполнении запроса / доступный остаток / суточный лимит.
        /// </summary>
        public string Units = "";

        /// <summary>
        /// Настройка фильтра запроса
        /// </summary>
        public ParamsRequest paramsRequest = new ParamsRequest
        {
            SelectionCriteria = new SelectionCriteria { Filter = null },
            FieldNames = new string[]
                  {
                      FieldNamesEnum.AvgCpc.ToString(),
                      FieldNamesEnum.CriteriaId.ToString(),
                      FieldNamesEnum.Ctr.ToString(),
                      FieldNamesEnum.CriteriaType.ToString(),
                      FieldNamesEnum.CriterionId.ToString(),
                      FieldNamesEnum.ClickType.ToString(),
                      FieldNamesEnum.Cost.ToString(),
                      FieldNamesEnum.Criteria.ToString(),
                      FieldNamesEnum.Slot.ToString(),
                  },
            ReportName = "Actual1",
            ReportType = ReportTypeEnum.ADGROUP_PERFORMANCE_REPORT,
            DateRangeType = DateRangeTypeEnum.LAST_30_DAYS,
            Format = ParamsRequest.FormatEnum.TSV,
            IncludeVAT = YesNoEnum2.YES,
            IncludeDiscount = YesNoEnum2.NO
        };
    }
}
