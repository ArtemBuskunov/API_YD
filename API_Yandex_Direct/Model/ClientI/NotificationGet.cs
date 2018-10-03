using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.ClientI
{
    /// <summary>
    /// Полномочия рекламодателя по управлению кампаниями.
    /// </summary>
    [DataContract]
    public class NotificationGet
    {
        /// <summary>
        ///  Язык уведомлений.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Lang { get; set; }

        /// <summary>
        ///  Телефонный номер для отправки SMS-уведомлений из профиля пользователя на Яндексе.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string SmsPhoneNumber { get; set; }

        /// <summary>
        ///  Адрес электронной почты для отправки уведомлений, связанных с аккаунтом (до 255 символов).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        ///  Адрес электронной почты для отправки уведомлений, связанных с аккаунтом (до 255 символов).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public EmailSubscriptionItem EmailSubscriptions { get; set; }
    }

}
