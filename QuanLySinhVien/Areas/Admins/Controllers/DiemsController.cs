using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLySinhVien.Models;

namespace QuanLySinhVien.Areas.Admins.Controllers
{
    public class DiemsController : Controller
    {
        private QuanLySinhVienDBcontext db = new QuanLySinhVienDBcontext();

        // GET: Admins/Diems
        public ActionResult Index()
        {
            var diems = db.Diems.Include(d => d.HocPhan);
            return View(diems.ToList());
        }

        // GET: Admins/Diems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diem diem = db.Diems.Find(id);
            if (diem == null)
            {
                return HttpNotFound();
            }
            return View(diem);
        }
        [Authorize(Roles = "Admin")]
        // GET: Admins/Diems/Create
        public ActionResult Create()
        {
            ViewBag.MaHocPhan = new SelectList(db.HocPhans, "MaHocPhan", "TenHocPhan");
            return View();
        }

        // POST: Admins/Diems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,HocKi,DiemA,DiemB,DiemC,DiemTB,MaSinhVien,MaHocPhan")] Diem diem)
        {
            if (ModelState.IsValid)
            {
                db.Diems.Add(diem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaHocPhan = new SelectList(db.HocPhans, "MaHocPhan", "TenHocPhan", diem.MaHocPhan);
            return View(diem);
        }

        // GET: Admins/Diems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diem diem = db.Diems.Find(id);
            if (diem == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaHocPhan = new SelectList(db.HocPhans, "MaHocPhan", "TenHocPhan", diem.MaHocPhan);
            return View(diem);
        }

        // POST: Admins/Diems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,HocKi,DiemA,DiemB,DiemC,DiemTB,MaSinhVien,MaHocPhan")] Diem diem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaHocPhan = new SelectList(db.HocPhans, "MaHocPhan", "TenHocPhan", diem.MaHocPhan);
            return View(diem);
        }

        // GET: Admins/Diems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diem diem = db.Diems.Find(id);
            if (diem == null)
            {
                return HttpNotFound();
            }
            return View(diem);
        }

        // POST: Admins/Diems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Diem diem = db.Diems.Find(id);
            db.Diems.Remove(diem);
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
