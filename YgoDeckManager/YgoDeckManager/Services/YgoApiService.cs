using YgoDeckManager.Shared.DTOs;

namespace YgoDeckManager.Services
{
    public class YgoApiService
    {
        private readonly HttpClient _http;
        public YgoApiService(HttpClient http) => _http = http;

        public async Task<List<CardSetDTO>> GetSetsAsync()
        {
            return await _http.GetFromJsonAsync<List<CardSetDTO>>("https://db.ygoprodeck.com/api/v7/cardsets.php");
        }

        public async Task<List<CardDTO>> GetCardsBySetAsync(string setName)
        {
            var response = await _http.GetFromJsonAsync<CardDataResponse>($"https://db.ygoprodeck.com/api/v7/cardinfo.php?set={setName}&language=fr");
            return response.data;
        }
    }

    public class CardDataResponse { public List<CardDTO> data { get; set; } }
}
