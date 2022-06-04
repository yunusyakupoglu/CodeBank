using DAL.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Validations
{
    public class SourceCodeValidator : AbstractValidator<SourceCode>
    {
        public SourceCodeValidator()
        {
            RuleFor(x => x.CategoryId).NotNull().WithMessage("Kategori null değer döndüremez.");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori boş geçilemez.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş geçilemez.");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Kaynak kod boş geçilemez.");

        }
    }
}
