using A_little_Extra.Data.Services;
using A_little_Extra.Models;
using Microsoft.AspNetCore.Mvc;

namespace A_little_Extra.Controllers
{
    public class ActivitiesController : Controller
	{
		private readonly IActivitiesService service;

		public ActivitiesController(IActivitiesService service)
		{	
			this.service = service;
		}

		public async Task<IActionResult> Index()
		{
			var data = await service.GetAllAysnc();

			return View(data);
		}

		// Get: Activities/CreateActivity
		public IActionResult CreateActivity()
        {
			return View();
        }

		[HttpPost]
		public async Task<IActionResult> CreateActivity([Bind("Name", "Description", "StartDate", "EndDate", "Points")]Activity activity)
		{
            if (!ModelState.IsValid)
            {
				return View(activity);
            }

			await service.AddAsync(activity);

			return RedirectToAction(nameof(Index));
		}

		// Get: Activities/ActivityDeails/1
		public async Task<IActionResult> ActivityDetails(int id)
		{
			var activity = await service.GetByIdAysnc(id);

			if (activity == null) return View("NotFound");

			return View(activity);
		}

		// Get: Activities/EditActivity
		public async Task<IActionResult> EditActivity(int id)
		{
			var activity = await service.GetByIdAysnc(id);

			if (activity == null) return View("NotFound");

			return View(activity);
		}

		[HttpPost]
		public async Task<IActionResult> EditActivity(int id, [Bind("ACtivityId, Name, Description, StartDate, EndDate, Points")] Activity activity)
		{
			if (!ModelState.IsValid)
			{
				return View(activity);
			}

			await service.UpdateAsync(id, activity);

			return RedirectToAction(nameof(Index));
		}

	}
}
