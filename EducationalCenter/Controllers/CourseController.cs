﻿using EducationalCenter.Core.Interfaces.RepositoryInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace EducationalCenter.Web.Controllers
{
	public class CourseController(IUnitOfWork unitOfWork) : Controller
	{
		private readonly IUnitOfWork _unitOfWork = unitOfWork;
		public ActionResult Index()
		{

			return View();
		}
		public ActionResult Details(int id)
		{
			return View();
		}
		public ActionResult Create()
		{
			return View();
		}
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
		public ActionResult Edit(int id)
		{
			return View();
		}
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
		public ActionResult Delete(int id)
		{
			return View();
		}
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
