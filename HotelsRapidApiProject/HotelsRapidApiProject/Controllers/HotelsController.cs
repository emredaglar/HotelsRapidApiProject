using HotelsRapidApiProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace HotelsRapidApiProject.Controllers
{
	public class HotelsController : Controller
	{
		public async Task<IActionResult> Index()
		{

			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id=-735338&search_type=CITY&arrival_date=2025-01-27&departure_date=2025-01-31&adults=1&children_age=0%2C17&room_qty=1&page_number=1&units=metric&temperature_unit=c&languagecode=en-us&currency_code=AED"),
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
				return View(values.data.hotels);
			}
		}


	}
}
