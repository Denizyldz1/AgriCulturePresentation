using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator:AbstractValidator<Image>
    {
        public ImageValidator() 
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Görsel başlığı boş geçilemez");
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Görsel açıklaması boş geçilemez");
            RuleFor(x=>x.ImageUrl).NotEmpty().WithMessage("Görsel yolunu boş geçilemez");
            RuleFor(x => x.Title).MaximumLength(30).WithMessage("Max 20 karakter girilebilir.");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("Min 8 karakter girilebilir.");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Max 50 karakter girilebilir.");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Min 10 karakter girilebilir.");

        }
    }
}
