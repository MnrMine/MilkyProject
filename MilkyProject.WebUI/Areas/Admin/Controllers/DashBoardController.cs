using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class DashBoardController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public DashBoardController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{

			var clientContact = _httpClientFactory.CreateClient();
			var responseMessageContact = await clientContact.GetAsync("https://localhost:7054/api/Contact/GetContactCount");

			var clientNewsletter = _httpClientFactory.CreateClient();
			var responseMessageNewsletter = await clientNewsletter.GetAsync("https://localhost:7054/api/Newsletter/GetNewsletterCount");

			var clientTeam = _httpClientFactory.CreateClient();
			var responseMessageTeam = await clientTeam.GetAsync("https://localhost:7054/api/Team/GetETeamCount");

			var clientCategory = _httpClientFactory.CreateClient();
			var responseMessageCategory = await clientCategory.GetAsync("https://localhost:7054/api/Category/GetCategoryCount");

			if (responseMessageContact.IsSuccessStatusCode)
			{
				var jsonDataContact = await responseMessageContact.Content.ReadAsStringAsync();
				ViewBag.ContactCount = jsonDataContact;

				var jsonDataNewsletter = await responseMessageNewsletter.Content.ReadAsStringAsync();
				ViewBag.NewsletterCount = jsonDataNewsletter;

				var jsonDataEmployer = await responseMessageTeam.Content.ReadAsStringAsync();
				ViewBag.TeamCount = jsonDataEmployer;

				var jsonDataCategory = await responseMessageCategory.Content.ReadAsStringAsync();
				ViewBag.CategoryCount = jsonDataCategory;

				return View();
			}
			return View();
		}
	}
	}

