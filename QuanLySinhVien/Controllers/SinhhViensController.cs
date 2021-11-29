using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLySinhVien.Models;

namespace QuanLySinhVien.Controllers
{
    public class SinhhViensController : Controller
    {
        private QuanLySinhVienDBcontext db = new QuanLySinhVienDBcontext();

        // GET: SinhhViens
        public ActionResult Index()
        {
            return View(db.SinhhViens.ToList());
        }

        // GET: SinhhViens/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhhVien sinhhVien = db.SinhhViens.Find(id);
            if (sinhhVien == null)
            {
                return HttpNotFound();
            }
            return View(sinhhVien);
        }

        // GET: SinhhViens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SinhhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HoVaTen,MaSinhVien,GioiTinh,DiaChi,Email,Sdt")] SinhhVien sinhhVien)
        {
            if (ModelState.IsValid)
            {
                db.SinhhViens.Add(sinhhVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sinhhVien);
        }

        // GET: SinhhViens/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhhVien sinhhVien = db.SinhhViens.Find(id);
            if (sinhhVien == null)
            {
                return HttpNotFound();
            }
            return View(sinhhVien);
        }

        // POST: SinhhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HoVaTen,MaSinhVien,GioiTinh,DiaChi,Email,Sdt")] SinhhVien sinhhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sinhhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sinhhVien);
        }

        // GET: SinhhViens/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhhVien sinhhVien = db.SinhhViens.Find(id);
            if (sinhhVien == null)
            {
                return HttpNotFound();
            }
            return View(sinhhVien);
        }

        // POST: SinhhViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SinhhVien sinhhVien = db.SinhhViens.Find(id);
            db.SinhhViens.Remove(sinhhVien);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
