using System.Net.Http;
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
        
        [HttpPost]
        [Route("remove")]
        public IHttpActionResult Remove(RemoveItem data)
        {
            cartService.Remove(data.ProductId);

            return Ok();
        }
    }
}
