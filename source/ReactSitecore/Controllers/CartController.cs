using System.Web.Mvc;

using ReactSitecore.Services;

namespace ReactSitecore.Controllers
{
    public class CartController : Controller
    {
        private readonly CartService cartService = new CartService();

        public ActionResult Cart()
        {
            return View(cartService.Get());
        }
    }
}
