using AquaAi.Shared.Wrapper;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AquaAi.Client.Extensions
{
    public static class HttpResponseMessageExtensions
    {
        public static async Task<IResult<T>> ToResult<T>(this HttpResponseMessage response)
        {
            var responseString = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IResult<T>>(responseString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
