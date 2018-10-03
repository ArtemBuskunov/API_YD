using API_Yandex_Direct.Model.CampaignI;
using API_Yandex_Direct.Model.Enum;
using API_Yandex_Direct.Model.Infrastructure;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model
{
    [DataContract]
    public class Campaign
    {
        [DataMember(EmitDefaultValue = false)]
        public string BiddingStrategy { get; set; }

        /// <summary>
        /// Массив IP-адресов, которым не нужно показывать объявления. Не более 25 элементов в массиве.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string[] BlockedIps { get; set; }

        /// <summary>
        /// Название клиента (до 255 символов). Значение по умолчанию — наименование из настроек рекламодателя.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string ClientInfo { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CounterIds { get; set; }

        /// <summary>
        /// Валюта кампании.Совпадает с валютой рекламодателя для всех кампаний, за исключением кампаний в у.е., 
        ///для которых были созданы копии при переходе рекламодателя на работу в реальной валюте.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public CurrencyEnum Currency { get; set; }

        /// <summary>
        /// Настройки дневного бюджета кампании.
        /// <para>  Управление дневным бюджетом доступно, если в кампании выбрана ручная стратегия показа, 
        /// а также в параметре Settings, возвращаемом методом get, присутствует настройка DAILY_BUDGET_ALLOWED со значением YES.
        /// В противном случае при попытке задать дневной бюджет возвращается ошибка.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DailyBudgetClass DailyBudget { get; set; }




        /// <summary>
        /// Дата окончания показов объявлений в формате YYYY-MM-DD. 
        /// <para>Показы объявлений прекращаются в 24:00 по московскому времени (независимо от значения параметра TimeZone).</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string EndDate { get; set; }


        /// <summary>
        ///Массив мест показа, где не нужно показывать объявления:
        /// <para> доменные имена сайтов;</para>
        /// <para> идентификаторы мобильных приложений(bundle ID для iOS, package name для Android);</para>
        /// <para> наименования внешних сетей(SSP). Список наименований можно получить с помощью метода Dictionaries.get.</para>
        /// <para>   Не более 1000 элементов в массиве.Не более 255 символов в каждом элементе массива.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string[] ExcludedSites { get; set; }

        /// <summary>
        ///  Финансовые показатели кампании.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public FundsParam Funds { get; set; }
        [DataContract]
        public class FundsParam
        {
            /// <summary>
            ///Тип финансовых показателей кампании:
            /// <para> CAMPAIGN_FUNDS — общий счет не подключен, финансовые показатели кампании возвращаются в дочерней структуре CampaignFund;</para>
            /// <para> SHARED_ACCOUNT_FUNDS — общий счет подключен, финансовые показатели кампании возвращаются в дочерней структуре SharedAccountFund.</para>
            /// </summary>

            [DataMember(EmitDefaultValue = false)]
            public CampaignFundsEnum Mode { get; set; }

            /// <summary>
            ///Финансовые показатели кампании, в случае если общий счет не подключен.
            /// </summary>
            [DataMember(EmitDefaultValue = false)]
            public CampaignFundsParam CampaignFunds { get; set; }

            /// <summary>
            ///Финансовые показатели кампании, в случае если общий счет не подключен.
            /// </summary>
            [DataContract]
            public class CampaignFundsParam
            {
                /// <summary>
                /// Сумма средств, зачисленных на баланс кампании за время ее существования, в валюте рекламодателя, без НДС.
                /// </summary>
                [DataMember(EmitDefaultValue = false)]
                public long Sum { get; set; }

                /// <summary>
                /// Текущий баланс кампании в валюте рекламодателя, без НДС.
                /// </summary>
                [DataMember(EmitDefaultValue = false)]
                public long Balance { get; set; }

                /// <summary>
                /// Скидочный бонус. Параметр утратил актуальность.
                /// </summary>
                [DataMember(EmitDefaultValue = false)]
                public long BalanceBonus { get; set; }

                /// <summary>
                /// Сумма, доступная для переноса на другую кампанию, в валюте рекламодателя, без НДС.
                /// </summary>
                [DataMember(EmitDefaultValue = false)]
                public long SumAvailableForTransfer { get; set; }
            }

            /// <summary>
            ///Финансовые показатели кампании, в случае если общий счет подключен.
            /// </summary>
            [DataMember(EmitDefaultValue = false)]
            public SharedAccountFundsParam SharedAccountFunds { get; set; }

            /// <summary>
            ///Финансовые показатели кампании, в случае если общий счет подключен.
            /// </summary>
            [DataContract]
            public class SharedAccountFundsParam
            {
                /// <summary>
                /// Сумма возврата средств за клики, признанные системой недобросовестными или ошибочными, без НДС. 
                /// Эта сумма не поступает на общий счет и может быть израсходована только в рамках этой же кампании.
                /// </summary>
                [DataMember(EmitDefaultValue = false)]
                public long Refund { get; set; }

                /// <summary>
                /// Сумма средств, израсходованных по данной кампании за все время ее существования, без НДС.
                /// </summary>
                [DataMember(EmitDefaultValue = false)]
                public long Spend { get; set; }


            }

        }

        /// <summary>
        /// Идентификатор кампании.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Название кампании (до 255 символов).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Массив минус-фраз, общих для всех ключевых фраз кампании.
        /// <para>  Минус-фразу следует указывать без минуса перед первым словом.</para>
        /// <para>   Не более 7 слов в минус-фразе.Длина каждого слова — не более 35 символов.
        /// Суммарная длина минус-фраз в массиве — 20000 символов.Оператор «!» или «+» перед словом не учитывается в суммарной длине.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public StringItems? NegativeKeywords { get; set; }


        /// <summary>
        /// Настройки SMS- и email-уведомлений.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public NotificationClass Notification { get; set; }
        [DataContract]
        public class NotificationClass
        {
            /// <summary>
            ///Настройки отправки SMS-уведомлений.
            ///Телефонный номер для отправки берется из профиля рекламодателя на Яндексе 
            ///(см. раздел Мои телефоны помощи Яндекс.Паспорта).
            /// </summary>
            [DataMember(EmitDefaultValue = false)]
            public SmsSettingsClass SmsSettings { get; set; }

            [DataContract]
            public class SmsSettingsClass
            {
                /// <summary>
                ///События, о которых необходимо информировать по SMS:
                /// <para>  MONITORING — остановка и возобновление показов объявлений мониторингом доступности сайта по данным Метрики;</para>
                /// <para>   MODERATION — объявления приняты или отклонены модерацией;</para>
                /// <para>   MONEY_IN — поступление средств на баланс кампании(не используется при подключенном общем счете);</para>
                /// <para> MONEY_OUT — исчерпание средств на балансе кампании(не используется при подключенном общем счете);</para>
                /// <para>  FINISHED — окончание кампании.</para>
                /// </summary>
                [DataMember(EmitDefaultValue = false)]
                public SmsEventsEnum[] Events { get; set; }
                public enum SmsEventsEnum { MONITORING, MODERATION, MONEY_IN, MONEY_OUT, FINISHED }

                /// <summary>
                ///Время, начиная с которого разрешено отправлять SMS о событиях, связанных с кампанией. 
                ///Указывается в формате HH:MM, минуты задают кратно 15 (0, 15, 30, 45). 
                ///<para>  Например, 19:45. Значение по умолчанию 9:00.</para>
                /// </summary>
                [DataMember(EmitDefaultValue = false)]
                public string TimeFrom { get; set; }

                /// <summary>
                ///Время, до которого разрешено отправлять SMS о событиях, связанных с кампанией.
                ///Указывается в формате HH:MM, минуты задают кратно 15 (0, 15, 30, 45). 
                ///<para>Например, 19:45. Значение по умолчанию 21:00.</para>
                /// </summary>
                [DataMember(EmitDefaultValue = false)]
                public string TimeTo { get; set; }
            }



            /// <summary>
            ///Настройки отправки уведомлений по электронной почте.
            /// </summary>
            [DataMember(EmitDefaultValue = false)]
            public EmailSettingsClass EmailSettings { get; set; }

            [DataContract]
            public class EmailSettingsClass
            {
                /// <summary>
                ///Адрес электронной почты для отправки уведомлений о событиях, связанных с кампанией.
                /// <para>Значение по умолчанию — адрес рекламодателя.</para>
                /// </summary>
                [DataMember(EmitDefaultValue = false)]
                public string Email { get; set; }

                /// <summary>
                ///Периодичность проверки позиции объявления — 15, 30 или 60 минут. Значение по умолчанию — 60.
                /// <para> Уведомление отправляется, если объявление переместилось на более низкую позицию, чем та,
                /// которую обеспечивала ставка на момент установки.</para>
                /// </summary>
                [DataMember(EmitDefaultValue = false)]
                public int CheckPositionInterval { get; set; }

                /// <summary>
                ///Минимальный баланс, при уменьшении до которого отправляется уведомление. 
                ///Задается в процентах от суммы последнего платежа, от 1 до 50. Значение по умолчанию — 20.
                /// <para>  Если у клиента подключен общий счет, параметр не используется.</para>
                /// </summary>
                [DataMember(EmitDefaultValue = false)]
                public int WarningBalance { get; set; }

                /// <summary>
                ///Отправлять ли уведомления о событиях, связанных с кампанией. 
                ///Задается для кампаний, обслуживаемых персональным менеджером в Яндексе. 
                ///Для кампаний, не обслуживаемых персональным менеджером, переданное значение игнорируется. 
                /// <para>Значение по умолчанию — NO.</para>
                /// </summary

                [DataMember(EmitDefaultValue = false)]
                public YesNoEnum SendAccountNews { get; set; }

                /// <summary>
                ///Отправлять ли уведомления по электронной почте. Значение по умолчанию — NO.
                /// </summary>

                [DataMember(EmitDefaultValue = false)]
                public YesNoEnum SendWarnings { get; set; }


            }
        }

        [DataMember(EmitDefaultValue = false)]
        public string RelevantKeywords { get; set; }

        /// <summary>
        /// Персональный менеджер в Яндексе или агентство, обслуживающее кампанию.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public CampaignAssistant RepresentedBy { get; set; }
        [DataContract]
        public class CampaignAssistant
        {
            /// <summary>
            /// Имя персонального менеджера в Яндексе (для кампаний, обслуживаемых персональным менеджером).
            /// </summary>
            [DataMember(EmitDefaultValue = false)]
            public string Manager { get; set; }

            /// <summary>
            /// Название рекламного агентства (для кампаний, обслуживаемых агентством).
            /// </summary>
            [DataMember(EmitDefaultValue = false)]
            public string Agency { get; set; }
        }

        [DataMember(EmitDefaultValue = false)]
        public string Settings { get; set; }

        /// <summary>
        ///  Идентификатор исходной кампании в у.е., если текущая кампания была создана автоматически при переходе рекламодателя на работу в валюту.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long? SourceId { get; set; }

        /// <summary>
        /// Дата начала показов объявлений в формате YYYY-MM-DD.
        /// <para> Должна быть не меньше текущей даты.</para>
        /// <para>Показы объявлений начинаются в 00:00 по московскому времени(независимо от значения параметра TimeZone). </para>
        /// <para>На время начала показов влияют настройки временного таргетинга(параметр TimeTargeting).</para>
        /// <para>Показы объявлений возможны при условии, что хотя бы одно объявление принято модерацией и внесены средства на кампанию или на общий счет.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Состояние кампании. 
        /// </summary>

        [DataMember(EmitDefaultValue = false)]
        public CampaignStateEnum State { get; set; }

        /// <summary>
        ///         Статистика показов и кликов за время существования кампании.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public StatisticsClass Statistics { get; set; }

        /// <summary>
        ///         Статистика показов и кликов за время существования кампании.
        /// </summary>
        [DataContract]
        public class StatisticsClass
        {
            /// <summary>
            /// Количество показов за время существования кампании.
            /// </summary>
            [DataMember(EmitDefaultValue = false)]
            public long Impressions { get; set; }
            /// <summary>
            /// Количество кликов за время существования кампании.
            /// </summary>
            [DataMember(EmitDefaultValue = false)]
            public long Clicks { get; set; }
        }

        /// <summary>
        /// Статус кампании.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public CampaignStatusSelectionEnum Status { get; set; }

        /// <summary>
        /// Текстовое пояснение к статусу.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string StatusClarification { get; set; }

        /// <summary>
        /// Статус оплаты кампании.
        /// </summary>

        [DataMember(EmitDefaultValue = false)]
        public CampaignStatusPaymentEnum StatusPayment { get; set; }

        /// <summary>
        /// Настройки временного таргетинга и почасовой корректировки ставок.
        /// <para> Указываются по времени часового пояса, указанного в параметре TimeZone.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TimeTargetingClass TimeTargeting { get; set; }

        /// <summary>
        /// Настройки временного таргетинга и почасовой корректировки ставок. Указываются по времени часового пояса, указанного в параметре TimeZone.
        /// </summary>
        [DataContract]
        public class TimeTargetingClass
        {

            /// <summary>
            /// Настройки временного таргетинга и почасовой корректировки ставок. Не более 7 элементов в массиве.
            /// <para>  Каждый элемент массива содержит 25 чисел, разделенных запятыми.Первое число — номер дня недели: 
            /// от 1 (понедельник) до 7 (воскресенье). 
            /// Следующие 24 числа — последовательность коэффициентов к ставке для показа объявлений в соответствующие часы. 
            /// Коэффициенты указываются в процентах от 0 до 200, значение должно быть кратно 10. 
            /// Коэффициент 0 означает, что объявления в этот час не показываются.</para>
            /// <para>Пример элемента массива: 1,0,0,50,50,100,100,150,200,200,150,100,100,80,70,100,100,100,50,50,40,30,0,0,0</para>
            /// <para>   Примечание.</para>
            /// <para>  Если в массиве отсутствует элемент, соответствующий дню недели, то объявления в этот день показываются
            /// круглосуточно, с коэффициентом 100%.</para>
            /// <para>Если выбрана автоматическая стратегия показа, коэффициент 0 означает запрет показов,
            /// а любой другой коэффициент означает разрешение показов (то есть эквивалентен 100).</para>
            /// </summary>
            [DataMember(EmitDefaultValue = false)]
            public StringItems Schedule { get; set; }




            /// <summary>
            /// Менять ли расписание показов при переносе рабочего дня на субботу или воскресенье.
            /// <para>Например, если рабочий день перенесен с понедельника на субботу, при значении YES в рабочую субботу 
            /// пойдут показы по расписанию понедельника, а в нерабочий понедельник, — по расписанию субботы.</para>
            /// </summary>

            [DataMember(EmitDefaultValue = false)]
            public YesNoEnum ConsiderWorkingWeekends { get; set; }

            /// <summary>
            ///  Настройки показа в праздничные дни.
            /// <para> Если часовой пояс, указанный в параметре TimeZone, относится к России, Украине, Беларуси, 
            /// Казахстану или Турции, то используется календарь праздников и переносов рабочих дней соответствующей страны.
            /// В остальных случаях используется российский календарь.</para>
            /// </summary>

            [DataMember(EmitDefaultValue = false)]
            public TimeTargetingOnPublicHolidays HolidaysSchedule { get; set; }

            [DataContract]
            public class TimeTargetingOnPublicHolidays
            {
                /// <summary>
                /// Останавливать ли объявления в праздничные нерабочие дни: YES — останавливать, NO — не останавливать.
                /// <para> Примечание.Параметры BidPercent, StartHour и EndHour допускается задавать только при значении NO параметра SuspendOnHolidays.</para>
                /// </summary>

                [DataMember(EmitDefaultValue = false)]
                public YesNoEnum SuspendOnHolidays { get; set; }
                /// <summary>
                /// Коэффициент к ставке при показе в праздничные нерабочие дни. Указывается в процентах от 10 до 200, значение должно быть кратно 10.
                /// </summary>
                [DataMember(EmitDefaultValue = false)]
                public int BidPercent { get; set; }

                /// <summary>
                /// Время (в часах) начала показов в праздничные нерабочие дни. От 0 до 23.
                /// </summary>
                [DataMember(EmitDefaultValue = false)]
                public int StartHour { get; set; }

                /// <summary>
                /// Время (в часах) окончания показов в праздничные нерабочие дни. От 1 до 24.
                /// </summary>
                [DataMember(EmitDefaultValue = false)]
                public int EndHour { get; set; }
            }
        }

        /// <summary>
        /// Часовой пояс в месте нахождения рекламодателя. Справочник часовых поясов можно получить с помощью метода Dictionaries.get.
        /// <para>  Значение по умолчанию Europe/Moscow.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Тип кампании. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public CampaignTypeEnum Type { get; set; }


        /// <summary>
        /// Настройки для кампании с типом «Текстово-графические объявления». 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TextCampaign TextCampaign { get; set; }
        ///// <summary>
        ///// Настройки для кампании с типом «Динамические объявления»
        ///// </summary>
        //[DataMember(EmitDefaultValue = false)]
        //public DynamicTextCampaignGetItem DynamicTextCampaign { get; set; }
        ///// <summary>
        ///// Настройки для кампании с типом «Реклама мобильных приложений». 
        ///// </summary>
        //[DataMember(EmitDefaultValue = false)]
        //public MobileAppCampaignGetItem MobileAppCampaign { get; set; }

        //[DataMember(EmitDefaultValue = false)]
        //public CpmBannerCampaign CpmBannerCampaign { get; set; }
        

    }


}
