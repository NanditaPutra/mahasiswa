using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mahasiswa.Services;
using mahasiswa.Models;

namespace mahasiswa.Controllers
{
    public class MahasiswaController : Controller
    {
        mahasiswaservice Mahasiswa;


        // GET: Mahasiswa
        public ActionResult Index()
        {
            Mahasiswa = new mahasiswaservice();
            var result = Mahasiswa.GetListMahasiswa();
            return View(result);
        }

        // GET: Mahasiswa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mahasiswa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mahasiswa/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mahasiswa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mahasiswa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mahasiswa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mahasiswa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
