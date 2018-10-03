using API_Yandex_Direct.Model.Enum;
using API_Yandex_Direct.Model.Infrastructure;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.MobileApp
{
    /// <summary>
    /// Параметры группы для рекламы мобильных приложений. 
    /// </summary>
    [DataContract]
    public class MobileApp
    {
        /// <summary>
        /// Ссылка на приложение в магазине приложений AppStore или Google Play (не более 1024 символов). Должна содержать протокол. Недоступна для изменения.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string StoreUrl { get; set; }

        /// <summary>
        /// На каких устройствах показывать объявления
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DeviceTypeEnum[] TargetDeviceType { get; set; }

        /// <summary>
        /// По каким типам подключения к интернету показывать объявления
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public CarrierEnum TargetCarrier { get; set; }

        /// <summary>
        /// Минимальная версия операционной системы, на которой может быть показано объявление.
        /// <para>Примечание. Если минимальная версия ОС в магазине приложений выше, чем заданная в параметре, то объявления будут показаны только для версий ОС как в магазине приложений или выше.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string TargetOperatingSystemVersion { get; set; }

        /// <summary>
        /// Результат модерации иконки мобильного приложения.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ExtensionModeration AppIconModeration { get; set; }

        /// <summary>
        /// Тип операционной системы (определяется автоматически на основании данных из магазина приложений)
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public MobileOperatingSystemTypeEnum AppOperatingSystemType { get; set; }


        /// <summary>
        /// Доступно ли приложение в магазине приложений
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public AppAvailabilityStatusEnum AppAvailabilityStatus { get; set; }

    }
}
