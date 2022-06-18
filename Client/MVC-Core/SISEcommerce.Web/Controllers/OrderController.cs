using Microsoft.AspNetCore.Mvc;
using SISEcommerce.Web.Models.Orders;
using SISEcommerce.Web.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace SISEcommerce.Web.Controllers
{
    public class OrderController : Controller
    {

        private readonly IBasketService _basketService;
        private readonly IOrderService _orderService;

        public OrderController(IBasketService basketService, IOrderService orderService)
        {
            _basketService = basketService;
            _orderService = orderService;
        }

        public async Task<IActionResult> Checkout()
        {
            var basket = await _basketService.Get();
            ViewBag.basket = basket;

            return View(new CheckoutInfoInput());
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(CheckoutInfoInput checkoutInfoInput)
        {
            //var orderStatus = await _orderService.CreateOrder(checkoutInfoInput); //senkron
            var orderSuspend = await _orderService.SuspendOrder(checkoutInfoInput); //asenkron
            if (!orderSuspend.IsSuccessful)
            {
                var basket = await _basketService.Get();
                ViewBag.basket = basket;
                ViewBag.error = orderSuspend.Error;
                return View();
            }
            //return RedirectToAction(nameof(SuccessfulCheckout), new { orderId = orderStatus.OrderId }); //senkron
            return RedirectToAction(nameof(SuccessfulCheckout) , new { orderId = new Random().Next(1,1000) } ); //asenkron
        }

        public IActionResult SuccessfulCheckout(int orderId)
        {
            ViewBag.orderId = orderId;
            return View();
        }

        public async Task<IActionResult> CheckoutHistory()
        {
            return View(await _orderService.GetOrder());
        }


    }
}
