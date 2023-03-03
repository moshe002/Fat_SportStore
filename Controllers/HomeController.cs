using Microsoft.AspNetCore.Mvc;

namespace Fat_SportStore.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index() => View();
	}
}
