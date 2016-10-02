using System.Collections.Generic;
using System.Web.Mvc;

namespace ToDo_List_ASP_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> items = (List<string>)this.Session["items"] ?? new List<string>();

            return View(items);
        }

        [HttpPost]
        [ValidateInput(false)]

        public ActionResult AddItem (string newItem)
        {
            List<string> items = (List<string>)this.Session["items"] ?? new List<string>();
            items.Add(newItem);
            this.Session["items"] = items;

            return this.RedirectToAction("Index");
        }

        public ActionResult RemoveItem(int i)
        {
            List<string> items = (List<string>)this.Session["items"];
            if (items!=null && i < items.Count)
            {
                items.RemoveAt(i);
                this.Session["items"] = items;
            }

            return this.RedirectToAction("Index");
        }
    }
}