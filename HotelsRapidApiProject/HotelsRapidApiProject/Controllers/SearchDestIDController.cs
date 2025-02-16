using HotelsRapidApiProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelsRapidApiProject.Controllers
{
    public class SearchDestIDController : Controller
    {
        public async Task<IActionResult> SearchDest()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query=ankara"),
                Headers =
    {
        { "x-rapidapi-key", "3db79cb1e3mshfa9b8dd84816013p1e663fjsn48c308702bf9" },
        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<SearchDestIDViewModel>(body);
                return View(values.data.Take(1).ToList());
            }
        }
    }
}
