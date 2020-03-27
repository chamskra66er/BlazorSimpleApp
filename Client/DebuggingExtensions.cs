using System.Text.Json;

namespace NewBlazor.Client
{
    public static class DebuggingExtensions
    {
        public static string ToJson(this object obj)
        {
            return JsonSerializer.Serialize(obj);
        }
    }

}
