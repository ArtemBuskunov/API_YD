using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.ClientI
{
    /// <summary>
    /// Типы уведомлений, отправляемых по электронной почте.
    /// </summary>
    [DataContract]
    public class EmailSubscriptionItem
    {
        /// <summary>
        /// Тип уведомления:
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public EmailSubscriptionEnum Option { get; set; }


        /// <summary>
        /// Отправлять ли уведомления данного типа.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public YesNoEnum Value { get; set; }
    }
}
