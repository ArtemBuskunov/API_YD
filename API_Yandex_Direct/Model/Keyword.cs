using API_Yandex_Direct.Model.Enum;
using API_Yandex_Direct.Model.KeywordI;
using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model
{

    [DataContract]
    public class KeywordClass
    {
        /// <summary>
        /// Идентификатор ключевой фразы.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Идентификатор группы объявлений, к которой относится ключевая фраза.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long AdGroupId { get; set; }

        /// <summary>
        /// Идентификатор кампании, к которой относится ключевая фраза.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long CampaignId { get; set; }


        /// <summary>
        /// Ключевая фраза. Может содержать минус-слова.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Keyword { get; set; }

        /// <summary>
        /// Значение подстановочной переменной {param1}. Не более 255 символов.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string UserParam1 { get { return userParam1; } set { if (value != null) { userParam1 = value; } } }

        string userParam1 = "", userParam2 = "";

        /// <summary>
        /// Значение подстановочной переменной {param2}. Не более 255 символов.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string UserParam2 { get { return userParam2; } set { if (value != null) { userParam2 = value; } } }

        /// <summary>
        /// Ставка на поиске.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Bid { get; set; }

        /// <summary>
        /// Ставка в сетях.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long ContextBid { get; set; }

        /// <summary>
        /// Приоритет фразы.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public PriorityEnum? StrategyPriority { get; set; }

        /// <summary>
        /// Статус ключевой фразы. 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public PriorityEnum StatusEnum { get; set; }

        /// <summary>
        /// Статус возможности показов группы объявлений.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ServingStatusEnum ServingStatus { get; set; }

        /// <summary>
        /// Состояние ключевой фразы.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public StatusEnumK State { get; set; }

        /// <summary>
        /// Продуктивность фразы и рекомендации по ее повышению.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public Productivity Productivity { get; set; }

        /// <summary>
        /// Статистика показов и кликов всех объявлений группы по данной фразе на поиске.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public Statistics StatisticsSearch { get; set; }

        /// <summary>
        /// Статистика показов и кликов всех объявлений группы по данной фразе в сетях.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public Statistics StatisticsNetwork { get; set; }


    }
    
}
