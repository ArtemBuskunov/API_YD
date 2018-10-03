using API_Yandex_Direct.Model.ClientI;
using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model
{
    [DataContract]
    public class Client
    {
        /// <summary>
        /// Показатель качества аккаунта 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? AccountQuality { get; set; }

        /// <summary>
        /// Признак того, что рекламодатель помещен в архив (не активен).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public YesNoEnum Archived { get; set; }

        /// <summary>
        /// Идентификатор рекламодателя.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long ClientId { get; set; }

        /// <summary>
        /// ФИО пользователя Директа (до 255 символов).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string ClientInfo { get; set; }

        /// <summary>
        /// Идентификатор страны рекламодателя из справочника регионов.
        /// <para>Справочник регионов можно получить с помощью метода Dictionaries.get.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int CountryId { get; set; }

        /// <summary>
        /// Дата регистрации пользователя в Директе, в формате YYYY-MM-DD.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Валюта рекламодателя.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public CurrencyEnum Currency { get; set; }

        /// <summary>
        /// Полномочия рекламодателя по управлению кампаниями.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public GrantGetItem[] Grants { get; set; }

        /// <summary>
        /// Логин пользователя Директа.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Login { get; set; }

        /// <summary>
        /// Настройки SMS- и email-уведомлений пользователя Директа.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public NotificationGet Notification { get; set; }

        /// <summary>
        ///Лимит овердрафта, которым рекламодатель может воспользоваться в текущий момент времени (см. раздел Отсрочка платежа помощи Директа).
        /// <para>Возвращается в виде целого числа, которое представляет собой лимит овердрафта в валюте рекламодателя, умноженный на 1 000 000.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long OverdraftSumAvailable { get; set; }

        /// <summary>
        /// Номер телефона пользователя Директа (до 255 символов).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Представители рекламодателя (см. раздел Регистрация представителей помощи Директа).
        /// <para> Для главного представителя возвращаются все представители, для обычного представителя — только главный представитель.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public Representative[] Representatives { get; set; }

        /// <summary>
        /// Количественные ограничения на объекты рекламодателя.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ClientRestrictionItem[] Restrictions { get; set; }

        /// <summary>
        /// Настройки рекламодателя, допускающие только значения YES или NO.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ClientSettingGetItem[] Settings { get; set; }

        /// <summary>
        /// Тип клиента:
        /// <para> CLIENT — прямой рекламодатель;</para>
        /// <para>  SUBCLIENT — рекламодатель, являющийся клиентом агентства.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Ставка НДС клиента, осуществляющего оплату: прямого рекламодателя или агентства.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal VatRate { get; set; }
    }
}
