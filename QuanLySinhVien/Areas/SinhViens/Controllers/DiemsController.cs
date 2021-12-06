using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLySinhVien.Models;

namespace QuanLySinhVien.Areas.SinhViens.Controllers
{
    public class DiemsController : Controller
    {
        private QuanLySinhVienDBcontext db = new QuanLySinhVienDBcontext();

        // GET: SinhViens/Diems
        public ActionResult Index()
        {
            var diems = db.Diems.Include(d => d.HocPhan);
            return View(diems.ToList());
        }

        // GET: SinhViens/Diems/Details/5
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

        // GET: SinhViens/Diems/Create
        public ActionResult Create()
        {
            ViewBag.MaHocPhan = new SelectList(db.HocPhans, "MaHocPhan", "TenHocPhan");
            return View();
        }

        // POST: SinhViens/Diems/Create
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

        // GET: SinhViens/Diems/Edit/5
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

        // POST: SinhViens/Diems/Edit/5
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

        // GET: SinhViens/Diems/Delete/5
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

        // POST: SinhViens/Diems/Delete/5
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
