using API_Yandex_Direct.Get.Keywords;

namespace API_Yandex_Direct.Get
{
    public class GetKeyword
    {
        /// <summary>
        /// Получить от API поисковые фразы для пользователя
        /// </summary>
        /// <param name="SetParamsRequest">Требуемы поля в ответе</param>
        /// <param name="AdGroupIds">Перечень Id групп объявлений</param>
        /// <param name="apiConnect">Данные ползователя для запроса</param>
        /// <returns>Поискове фразы</returns>
        public Model.KeywordClass[] GetKeywordParamsRequest(FieldNamesList[] SetParamsRequest,
            long[] AdGroupIds, ApiConnect.ApiConnect apiConnect)
        {
            string[] Headers = new string[] { };
            string[] pr = new string[SetParamsRequest.Length];
            for (int i = 0; i < SetParamsRequest.Length; i++) { pr[i] = SetParamsRequest[i].ToString(); }
            paramsRequest.FieldNames = pr;
            paramsRequest.SelectionCriteria.AdGroupIds = AdGroupIds;

            return GetKeywordParamsRequest(paramsRequest, apiConnect);
        }

        /// <summary>
        /// Получить от API поисковые фразы 
        /// </summary>
        /// <param name="paramsRequest">фильтр запроса</param>
        /// <param name="apiConnect">Данные ползователя для запроса</param>
        /// <returns>Поискове фразы</returns>
        public Model.KeywordClass[] GetKeywordParamsRequest(ParamsRequest paramsRequest, ApiConnect.ApiConnect apiConnect)
        {
            string[] Headers = new string[] { };
            return apiConnect.GetResult5(paramsRequest, "keywords", "get", ref Headers).Keywords;
        }

        /// <summary>
        ///  Units указано количество баллов: израсходовано при выполнении запроса / доступный остаток / суточный лимит.
        /// </summary>
        public string Units = "";


        /// <summary>
        /// Настройка фильтра запроса
        /// </summary>
        ParamsRequest paramsRequest = new ParamsRequest
        {
            SelectionCriteria = new KeywordsSelectionCriteria(),
            FieldNames = new string[]
               {
                FieldNamesList.Id.ToString(),
                FieldNamesList.Keyword.ToString()
               }
        };

    }
}
