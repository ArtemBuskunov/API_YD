using System.Runtime.Serialization;

namespace API_Yandex_Direct.Model.KeywordI
{
    /// <summary>
    /// Продуктивность фразы и рекомендации по ее повышению.
    /// </summary>
    [DataContract]
    public class Productivity
    {
        /// <summary>
        /// Значение продуктивности фразы (до 1 знака после запятой).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal Value { get; set; }

        /// <summary>
        /// Массив номеров рекомендаций для данной фразы.
        /// <para>Справочник рекомендаций можно получить с помощью метода Dictionaries.get.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int[] References { get; set; }
    }
}
