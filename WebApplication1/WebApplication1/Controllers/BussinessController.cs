using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class BussinessController : Controller
    {
        public IBussinessOperation bussinessOperation; 

        public BussinessController(IBussinessOperation _bussinessOperation)
        {
            bussinessOperation = _bussinessOperation;
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: BussinessController/Details/5
        public ActionResult Details(int id )
        {
            return View();
        }

        // GET: BussinessController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BussinessController/Create
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

        // GET: BussinessController/Edit/5
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

        // GET: BussinessController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BussinessController/Delete/5
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
