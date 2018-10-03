using API_Yandex_Direct.Model.Enum;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.ClientI
{
    /// <summary>
    /// Представители рекламодателя (см. раздел Регистрация представителей помощи Директа).
    /// <para> Для главного представителя возвращаются все представители, для обычного представителя — только главный представитель.</para>
    /// </summary>
    [DataContract]
    public class Representative
    {
        /// <summary>
        ///  	Логин пользователя.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Login { get; set; }

        /// <summary>
        ///  Адрес электронной почты для отправки уведомлений.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        ///  Роль пользователя
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public RepresentativeRoleEnum Role { get; set; }
    }
}
