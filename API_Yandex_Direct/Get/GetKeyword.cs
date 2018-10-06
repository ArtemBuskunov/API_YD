using API_Yandex_Direct.Get.Keywords;
using API_Yandex_Direct.Get.Shared;

namespace API_Yandex_Direct.Get
{
    public class GetKeyword : GetAbstract
    {
        /// <summary>
        /// Получить от API поисковые фразы 
        /// </summary>
        /// <param name="paramsRequest">фильтр запроса</param>
        /// <param name="apiConnect">Данные ползователя для запроса</param>
        /// <returns>Поискове фразы</returns>
        public Model.KeywordClass[] GetKeywords(ParamsRequest paramsRequest, ApiConnect.ApiConnect apiConnect)
        { return apiConnect.GetResult5(paramsRequest, "keywords", "get", ref Headers).Keywords; }

        /// <summary>
        /// Получить от API поисковые фразы для пользователя
        /// </summary>
        /// <param name="SetParamsRequest">Требуемы поля в ответе</param>
        /// <param name="AdGroupIds">Перечень Id групп объявлений</param>
        /// <param name="apiConnect">Данные ползователя для запроса</param>
        /// <returns>Поискове фразы</returns>
        public Model.KeywordClass[] GetKeywords(long[] AdGroupIds, ApiConnect.ApiConnect apiConnect)
        {
            ParamsRequest paramsRequest = new ParamsRequest(new FieldNamesEnum[] { FieldNamesEnum.Id, FieldNamesEnum.Keyword })
            { SelectionCriteria = new KeywordsSelectionCriteria { AdGroupIds = AdGroupIds } };
            return GetKeywords(paramsRequest, apiConnect);
        }
     
        /// <summary>
        /// Получить от API поисковые фразы для пользователя
        /// </summary>
        /// <param name="SetParamsRequest">Требуемы поля в ответе</param>
        /// <param name="AdGroupIds">Перечень Id групп объявлений</param>
        /// <param name="apiConnect">Данные ползователя для запроса</param>
        /// <returns>Поискове фразы</returns>
        public Model.KeywordClass[] GetKeywords(FieldNamesEnum[] GetParamsRequest, long[] AdGroupIds, ApiConnect.ApiConnect apiConnect)
        {
            if (GetParamsRequest is null) { return null; }
            ParamsRequest paramsRequest = new ParamsRequest(GetParamsRequest)
            { SelectionCriteria = new KeywordsSelectionCriteria { AdGroupIds = AdGroupIds } };

            return GetKeywords(paramsRequest, apiConnect);
        }
    }
}
