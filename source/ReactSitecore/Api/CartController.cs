using System.Web.Http;

using ReactSitecore.Models;
using ReactSitecore.Services;

namespace ReactSitecore.Api
{
    [RoutePrefix("api/cart")]
    public class CartController : ApiController
    {
        readonly CartService cartService = new CartService();

        [HttpGet]
        [Route("")]
        public CartModel Index()
        {
            return cartService.Get();
        }
    }
}
