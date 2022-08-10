using A_little_Extra.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace A_little_Extra.Controllers
{
    public class StudentController : Controller
    {
		private readonly IStudentsService service;

		public StudentController(IStudentsService service)
		{
			this.service = service;
		}

		public async Task<IActionResult> Index()
		{
			var data = await service.GetAll();

            return View(data);
		}
	}
}
