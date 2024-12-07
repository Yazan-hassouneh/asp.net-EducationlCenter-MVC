using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationalCenter.Web.Controllers
{
	public class MentorController : Controller
	{
		// GET: MentorController
		public ActionResult Index()
		{
			return View();
		}

		// GET: MentorController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: MentorController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: MentorController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: MentorController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: MentorController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: MentorController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: MentorController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
