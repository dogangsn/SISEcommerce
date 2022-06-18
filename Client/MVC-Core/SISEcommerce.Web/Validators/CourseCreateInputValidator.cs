using FluentValidation;
using SISEcommerce.Web.Models.Catalog;

namespace SISEcommerce.Web.Validators
{
    public class CourseCreateInputValidator:AbstractValidator<CourseCreateInput>
    {
        public CourseCreateInputValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("isim alanı boş olamaz");
        }


    }
}
