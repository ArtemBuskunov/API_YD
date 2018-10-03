using API_Yandex_Direct.Model.CampaignI;
using API_Yandex_Direct.Model.Infrastructure;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using static API_Yandex_Direct.Model.Campaign;

namespace API_Yandex_Direct.UpDate.Campaign
{
    /// <summary>
    ///
    /// <para> Внимание! Параметры CampaignId, AdGroupId и KeywordId являются взаимоисключающими. В одном запросе можно указывать только один из этих параметров.</para>
    /// <para> Хотя бы один из параметров Bid, ContextBid, StrategyPriority</para>
    /// </summary>
    [DataContract]
    public class CampaignUpdateItem
    {
        /// <summary>
        /// Идентификатор кампании, параметры которой требуется изменить.
        /// </summary>
        [DataMember]
        public long Id { get; set; }

        /// <summary>
        /// Название кампании (до 255 символов).
        /// </summary>       
        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Название клиента (до 255 символов). Значение по умолчанию — наименование из настроек рекламодателя.
        /// </summary>       
        [DataMember(EmitDefaultValue = false)]
        public string ClientInfo { get; set; }

        /// <summary>
        /// Дата начала показов объявлений в формате YYYY-MM-DD. Должна быть не меньше текущей даты.
        /// <para> Показы объявлений начинаются в 00:00 по московскому времени(независимо от значения параметра TimeZone). На время начала показов влияют настройки временного таргетинга(параметр TimeTargeting).</para>  
        /// <para>  Показы объявлений возможны при условии, что хотя бы одно объявление принято модерацией и внесены средства на кампанию или на общий счет.</para>  
        /// </summary>       
        [DataMember(EmitDefaultValue = false)]
        public string StartDate { get; set; }


        /// <summary>
        /// Дата окончания показов объявлений в формате YYYY-MM-DD. Показы объявлений прекращаются в 24:00 по московскому времени (независимо от значения параметра TimeZone).
        /// </summary>       
        [DataMember(EmitDefaultValue = false)]
        public string EndDate { get; set; }


        /// <summary>
        /// Настройки временного таргетинга и почасовой корректировки ставок. Указываются по времени часового пояса, указанного в параметре TimeZone.	
        /// </summary>  
        [DataMember(EmitDefaultValue = false)]
        public TimeTargetingClass TimeTargeting { get; set; }


        /// <summary>
        /// Часовой пояс в месте нахождения рекламодателя. Справочник часовых поясов можно получить с помощью метода Dictionaries.get.
        /// <para> Значение по умолчанию Europe/Moscow.</para>  
        /// </summary> 
        [DataMember(EmitDefaultValue = false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Массив минус-фраз, общих для всех ключевых фраз кампании.
        /// <para>  Минус-фразу следует указывать без минуса перед первым словом.</para>  
        /// <para>  Не более 7 слов в минус-фразе.Длина каждого слова — не более 35 символов.Суммарная длина минус-фраз в массиве — 20000 символов.Оператор «!» или «+» перед словом не учитывается в суммарной длине.</para>  
        /// </summary> 
        [DataMember(EmitDefaultValue = false)]
        public StringItems? NegativeKeywords { get; set; }

        /// <summary>
        /// Массив IP-адресов, которым не нужно показывать объявления. Не более 25 элементов в массиве.
        /// </summary> 
        [DataMember(EmitDefaultValue = false)]
        public StringItems? BlockedIps { get; set; }

        /// <summary>
        /// Массив мест показа, где не нужно показывать объявления:
        /// <para> доменные имена сайтов;</para>  
        /// <para> идентификаторы мобильных приложений(bundle ID для iOS, package name для Android);</para>  
        /// <para> наименования внешних сетей(SSP). Список наименований можно получить с помощью метода Dictionaries.get.</para>  
        /// <para> Не более 1000 элементов в массиве.Не более 255 символов в каждом элементе массива.</para>  
        /// </summary> 
        [DataMember(EmitDefaultValue = false)]
        public StringItems? ExcludedSites { get; set; }

        /// <summary>
        /// Настройки дневного бюджета кампании.
        /// <para> Управление дневным бюджетом доступно, если в кампании выбрана ручная стратегия показа, а также в параметре Settings, возвращаемом методом get, присутствует настройка DAILY_BUDGET_ALLOWED со значением YES.В противном случае при попытке задать дневной бюджет возвращается ошибка.</para>  
        /// <para> Чтобы сбросить дневной бюджет, передайте null (nil).</para>  
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DailyBudgetClass DailyBudget { get; set; }

        /// <summary>
        /// Настройки SMS- и email-уведомлений.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public NotificationClass Notification { get; set; }

        /// <summary>
        /// Настройки для кампании с типом «Текстово-графические объявления». Описание структуры данных см. в разделе update: параметры TextCampaign.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TextCampaign TextCampaign { get; set; }

        ///// <summary>
        ///// Настройки для кампании с типом «Динамические объявления». Описание структуры данных см. в разделе update: параметры DynamicTextCampaign.
        ///// </summary>
        //[DataMember(EmitDefaultValue = false)]
        //public DynamicTextCampaign DynamicTextCampaign { get; set; }

        ///// <summary>
        ///// Настройки для кампании с типом «Реклама мобильных приложений». Описание структуры данных см. в разделе update: параметры MobileAppCampaign.
        ///// </summary>
        //[DataMember(EmitDefaultValue = false)]
        //public MobileAppCampaign MobileAppCampaign { get; set; }
    }
}
