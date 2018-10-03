using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationMVC.Models
{
    public class Setup
    {
        public static Setup SetupGet { get; set; } 


        /// <summary>
        /// Адрес по которому осуществляется запрос в 5 версии
        /// </summary>
        public string UrlDirect { get; set; }
        /// <summary>
        /// Пользовательский токен для Яндекс директ Приложения токен для Яндекс директ
        /// </summary>
        public string OAuthDirect { get; set; }

    }
}