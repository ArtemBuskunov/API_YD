namespace API_Yandex_Direct.ApiConnect.Infrastructure
{

    class JsonConvert
    {
        /// <summary>
        /// Заполнение выходной строки JSon по параметрам
        /// </summary>
        /// <typeparam name="T">Тип сущности  в которой необходимо преобразовать парметры в JSon</typeparam>
        /// <param name="t">сущность в которой необходимо преобразовать парметры в JSon</param>
        /// <returns></returns>
        public static string SerializeJSon<T>(T t) { return Newtonsoft.Json.JsonConvert.SerializeObject(t); }
    }
}
