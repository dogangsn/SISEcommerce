using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SISEcommerce.Web.Models.Baskets;
using SISEcommerce.Web.Models.Discounts;
using SISEcommerce.Web.Services.Interfaces;
using System.Threading.Tasks;

namespace SISEcommerce.Web.Controllers
{

    [Authorize]
    public class BasketController : Controller
    {

        private readonly ICatalogService _catalogService;
        private readonly IBasketService _basketService;

        public BasketController(ICatalogService catalogService, IBasketService basketService)
        {
            _catalogService = catalogService;
            _basketService = basketService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _basketService.Get());
        }

        public async Task<IActionResult> AddBasketItem(string courseid)
        {
            var course = await _catalogService.GetByCourseId(courseid);
            var basketItem = new BasketItemViewModel
            {
                CourseId = course.Id,
                CourseName = course.Name,
                Price = course.Price,
            };
            await _basketService.AddBasketItem(basketItem);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> RemoveBasketItem(string courseId)
        {
            await _basketService.RemoveBasketItem(courseId);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ApplyDiscount(DiscountApplyInput discountApplyInput)
        {
            var discount = await _basketService.ApplyDiscount(discountApplyInput.Code);
            TempData["discountStatus"] = discount;
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CancelApplyDiscount()
        {
            await _basketService.CancelApplyDiscount();
            return RedirectToAction(nameof(Index));
        }


    }
}
