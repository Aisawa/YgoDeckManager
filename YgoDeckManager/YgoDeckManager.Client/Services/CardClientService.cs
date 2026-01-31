using System.Net.Http.Json;
using YgoDeckManager.Shared.DTOs;

namespace YgoDeckManager.Client.Services
{
    public class CardClientService
    {
        private readonly HttpClient _http;
        public CardClientService(HttpClient http) => _http = http;

        public async Task<List<CardSetDTO>> GetSetsAsync() =>
            await _http.GetFromJsonAsync<List<CardSetDTO>>("api/cards/sets");

        public async Task<List<CardDTO>> GetCardsBySetAsync(string setName) =>
            await _http.GetFromJsonAsync<List<CardDTO>>($"api/cards/set/{setName}");
    }
}
