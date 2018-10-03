using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace API_Yandex_Direct.ApiConnect.Infrastructure
{
    public abstract class abstractExceptionNotificationClass
    {
        /// <summary>
        /// Предупреждения, возникшие при выполнении операции.
        /// </summary>
        [DataMember]
        public ExceptionNotification[] Warnings { get; set; }

        /// <summary>
        /// Ошибки, возникшие при выполнении операции.
        /// </summary>
        [DataMember]
        public ExceptionNotification[] Errors { get; set; }
    }
}
