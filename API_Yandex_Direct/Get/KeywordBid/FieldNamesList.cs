using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Yandex_Direct.Get.KeywordBid
{
    /// <summary>
    /// Перечень доступных полей для запросов
    /// </summary>       
    public enum FieldNamesEnum
    {
        /// <summary>
        /// Идентификатор кампании, к которой относится ключевая фраза или автотаргетинг.
        /// </summary>
        KeywordId,
        /// <summary>
        /// Идентификатор группы объявлений, к которой относится ключевая фраза или автотаргетинг.
        /// </summary>
        AdGroupId,
        /// <summary>
        /// Идентификатор ключевой фразы или автотаргетинга.
        /// </summary>
        CampaignId,
        /// <summary>
        /// Статус возможности показов группы объявлений. 
        /// </summary>
        ServingStatus,
        /// <summary>
        /// Приоритет ключевой фразы или автотаргетинга: LOW, NORMAL или HIGH.
        /// </summary>
        StrategyPriority,
        ///// <summary>
        ///// Приоритет ключевой фразы или автотаргетинга: LOW, NORMAL или HIGH.
        ///// </summary>
        //Search,
        ///// <summary>
        ///// Ставка и данные торгов в сетях.
        ///// </summary>
        //Network
    };
}
