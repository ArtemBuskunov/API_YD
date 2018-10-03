using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace API_Yandex_Direct.UpDate.Campaign
{
    [DataContract]
    public class ParamsRequest
    {
        /// <summary>
        /// Ставки и/или приоритеты.
        /// </summary>
        [DataMember]
        public CampaignUpdateItem[] Campaigns { get; set; }
    }
}
