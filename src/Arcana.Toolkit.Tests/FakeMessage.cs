using System.Text.Json.Serialization;

namespace Arcana.Toolkit.Testing.MsTest
{
    public class FakeMessage<T>
    {
        [JsonPropertyName("returncode")]
        public int ReturnCode { get; set; }
        [JsonPropertyName("content")]
        public T Content { get; set; }
    }
}
