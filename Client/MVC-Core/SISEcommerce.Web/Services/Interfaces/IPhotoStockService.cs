using Microsoft.AspNetCore.Http;
using SISEcommerce.Web.Models.PhotoStocks;
using System.Threading.Tasks;

namespace SISEcommerce.Web.Services.Interfaces
{
    public interface IPhotoStockService
    {
        Task<PhotoViewModel> UploadPhoto(IFormFile photo);

        Task<bool> DeletePhoto(string photoUrl);
    }
}
