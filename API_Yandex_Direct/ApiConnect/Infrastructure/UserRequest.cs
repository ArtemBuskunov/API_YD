namespace API_Yandex_Direct.ApiConnect.Infrastructure
{
    /// <summary>
    /// Объект хранит данные для запроса к Api
    /// </summary>
    public class UserRequest
    {
        public UserRequest(string LoginClient = "") { loginClient = LoginClient; }

        /// <summary>
        /// Логин рекламодателя — клиента рекламного агентства.Обязателен, если запрос осуществляется от имени агентства.</param>
        /// </summary>
        public string loginClient { get; set; }

        /// <summary>
        /// OAuth-токен код, разрешающий доступ к данным конкретного пользователя.
        /// </summary>
        public string TokenApi { get; set; }

        /// <summary>
        ///  Язык ответных сообщений.На выбранном языке возвращаются текстовые пояснения к статусам объектов(кампаний, объявлений и др.), тексты ошибок и предупреждений.
        /// </summary>
        public AccepLanguage AccepLanguage { get; set; }
    }
}
