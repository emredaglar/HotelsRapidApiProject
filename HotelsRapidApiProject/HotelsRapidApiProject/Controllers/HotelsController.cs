using Microsoft.AspNetCore.Mvc;

namespace HotelsRapidApiProject.Controllers
{
	public class HotelsController : Controller
	{
		private readonly HttpClient _httpClient;

		public HotelsController(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		private readonly string _apiKey = "3db79cb1e3mshfa9b8dd84816013p1e663fjsn48c308702bf9";
		private readonly string _apiHost = "booking-com15.p.rapidapi.com";


		public IActionResult Index()
		{
			return View();
		}
	}
}
