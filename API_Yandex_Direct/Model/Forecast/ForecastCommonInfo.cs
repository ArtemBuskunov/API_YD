using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.Forecast
{
    [DataContract]
    public class ForecastCommonInfo
    {
        /// <summary>
        /// Список регионов, которые указаны при формировании отчета(метод CreateNewForecast (Live)).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Geo { get; set; }

        /// <summary>
        /// Стоимость кликов при показе в нижнем блоке(кроме первого места) суммарно по всем указанным фразам(в валюте, указанной в параметре Currency).
        /// <para>Значение конвертируется в валюту, указанную в параметре Currency, и округляется вверх с точностью до шага торгов в этой валюте(см.раздел Реальные валюты вместо у.е.).</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public float Min { get; set; }

        /// <summary>
        ///  Стоимость кликов при показе на первом месте в нижнем блоке суммарно по всем указанным фразам(в валюте, указанной в параметре Currency).
        /// <para>Значение конвертируется в валюту, указанную в параметре Currency, и округляется вверх с точностью до шага торгов в этой валюте(см.раздел Реальные валюты вместо у.е.).</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public float Max { get; set; }

        /// <summary>
        ///  Стоимость кликов при показе в спецразмещении суммарно по всем указанным фразам(в валюте, указанной в параметре Currency).
        ///  <para>Значение конвертируется в валюту, указанную в параметре Currency, и округляется вверх с точностью до шага торгов в этой валюте(см.раздел Реальные валюты вместо у.е.).</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public float PremiumMin { get; set; }

        /// <summary>
        ///      Возможное количество показов объявления суммарно по всем фразам.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int Shows { get; set; }

        /// <summary>
        ///  Возможное количество кликов в нижнем блоке(кроме первого места) суммарно по всем указанным фразам.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int Clicks { get; set; }

        /// <summary>
        /// Возможное количество кликов на первом месте в нижнем блоке суммарно по всем указанным фразам.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int FirstPlaceClicks { get; set; }

        /// <summary>
        ///  Возможное количество кликов в спецразмещении суммарно по всем указанным фразам.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int PremiumClicks { get; set; }

    }

}
