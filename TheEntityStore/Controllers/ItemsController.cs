using System.Linq;
using System.Web.Mvc;
using TheEntityStore.Models;
using TheEntityStore.ViewModels;

namespace TheEntityStore.Controllers
{
    public class ItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new ItemsFormViewModel
            {
                Categories = _context.Categories.ToList()
            };


            return View(viewModel);
        }
    }
}