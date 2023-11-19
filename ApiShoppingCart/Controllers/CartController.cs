using ApiShoppingCart.Models;
using ApiShoppingCart.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiShoppingCart.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class CartController:ControllerBase
    {
        public ICartRepository cartRepository;

        public CartController(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }

        [HttpPost]
        [Route("/PlaceOrder")]
        public async Task<bool> PlaceOrder(Order order)
        {
            return await cartRepository.PlaceOrder(order);
        }

        [HttpGet]
        [Route("GetOrders")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return StatusCode(StatusCodes.Status200OK,
                await cartRepository.GetOrders());
        }

        [HttpGet]
        [Route("GetOrderById/{idOrder}")]
        public async Task<ActionResult<Order>> GetOrderById(string idOrder)
        {
            return StatusCode(StatusCodes.Status200OK,
                await cartRepository.GetOrderById(idOrder));
        }

        [HttpGet]
        [Route("GetOrderByCustomer/{idCustomer}")]
        public async Task<ActionResult<Order>> GetOrderByCustomer(string idCustomer)
        {
            return StatusCode(StatusCodes.Status200OK,
                await cartRepository.GetOrderByCustomer(idCustomer));
        }

        

    }
}
