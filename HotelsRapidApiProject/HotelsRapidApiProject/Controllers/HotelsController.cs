using HotelsRapidApiProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace HotelsRapidApiProject.Controllers
{
    public class HotelsController : Controller
    {
        [HttpGet]
        public IActionResult SearchDest()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchDest(string city, string dateIn, string dateOut, int guest, int children)
        {
            if (string.IsNullOrEmpty(city) || string.IsNullOrEmpty(dateIn) || string.IsNullOrEmpty(dateOut))
            {
                return View();
            }

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query={city}"),
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


                var value = JsonConvert.DeserializeObject<SearchDestIDViewModel>(body);
                var destinationId = value?.data?.Count > 0 ? value.data[0].dest_id : null;
                if (destinationId == null)
                {

                    return View();
                }


                return RedirectToAction("Index", new { destId = destinationId, dateIn, dateOut, guest, children });
            }
        }



        public async Task<IActionResult> Index(string destId, string dateIn, string dateOut, int guest, int children)
        {
            if (string.IsNullOrEmpty(destId) || string.IsNullOrEmpty(dateIn) || string.IsNullOrEmpty(dateOut))
            {
                return BadRequest("Not Parameters");
            }

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id={destId}&search_type=CITY&arrival_date={dateIn}&departure_date={dateOut}&adults={guest}&children_age={children}%2C17&room_qty=1&page_number=1&units=metric&temperature_unit=c&languagecode=en-us&currency_code=TRY"),
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


                var values = JsonConvert.DeserializeObject<HotelsViewModel>(body);
                var hotels = values?.data?.hotels?.ToList() ?? new List<HotelsViewModel.Hotel>();

                return View(hotels);
            }
        }




    }
}