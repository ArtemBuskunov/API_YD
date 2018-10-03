namespace API_Yandex_Direct.ApiConnect.Infrastructure
{
    /// <summary>
    /// Класс для сохранения инфорамции о запросах.
    /// </summary>
    public class Request
    {
        public string RequestId { get; set; }
        public string ClientLogin { get; set; }
        public string Units { get; set; }
        public string RequestText { get; set; }
        public string ResponseText { get; set; }
    }
}
