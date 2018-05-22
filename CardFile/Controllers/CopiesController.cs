using System.Data.Entity;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using CardFile.Models;

namespace CardFile.Controllers
{
    public class CopiesController : Controller
    {
        private readonly CardFileContext db = new CardFileContext();

        // GET: Copies
        public async Task<ActionResult> Index()
        {
            var copies = db.Copies.Include(c => c.Book).Include(c => c.User);
            return View(await copies.ToListAsync());
        }

        // GET: Copies/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Copy copy = await db.Copies.FindAsync(id);
            if (copy == null)
            {
                return HttpNotFound();
            }
            return View(copy);
        }

        // GET: Copies/Create
        public ActionResult Create()
        {
            ViewBag.BookId = new SelectList(db.Books, "BookId", "BookTitle");
            ViewBag.UserId = new SelectList(db.Users, "UserId", "FullName");
            return View();
        }

        // POST: Copies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CopyId,BookId,BegDate,EndDate,UserId")] Copy copy)
        {
            if (ModelState.IsValid)
            {
                db.Copies.Add(copy);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.BookId = new SelectList(db.Books, "BookId", "BookTitle", copy.BookId);
            ViewBag.UserId = new SelectList(db.Users, "UserId", "FullName", copy.UserId);
            return View(copy);
        }

        // GET: Copies/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Copy copy = await db.Copies.FindAsync(id);
            if (copy == null)
            {
                return HttpNotFound();
            }
            ViewBag.BookId = new SelectList(db.Books, "BookId", "BookTitle", copy.BookId);
            ViewBag.UserId = new SelectList(db.Users, "UserId", "FullName", copy.UserId);
            return View(copy);
        }

        // POST: Copies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CopyId,BookId,BegDate,EndDate,UserId")] Copy copy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(copy).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.BookId = new SelectList(db.Books, "BookId", "BookTitle", copy.BookId);
            ViewBag.UserId = new SelectList(db.Users, "UserId", "FullName", copy.UserId);
            return View(copy);
        }

        // GET: Copies/Delete/5
        [Authorize]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Copy copy = await db.Copies.FindAsync(id);
            if (copy == null)
            {
                return HttpNotFound();
            }
            return View(copy);
        }

        // POST: Copies/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Copy copy = await db.Copies.FindAsync(id);
            db.Copies.Remove(copy);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Метод Dispose() уничтожает все связанные с контекстом данных ресурсы и подключения.
        /// </summary>
        /// <param name="disposing">Значение true позволяет освободить как управляемые, так и неуправляемые ресурсы;
        /// значение false освобождает только неуправляемые ресурсы.</param>
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