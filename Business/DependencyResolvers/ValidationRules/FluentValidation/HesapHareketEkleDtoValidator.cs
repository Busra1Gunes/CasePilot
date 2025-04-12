using Entities.Dto.HesapHareketDto;
using Entities.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.ValidationRules.FluentValidation
{
    public class HesapHareketEkleDtoValidator : AbstractValidator<HesapHareketEkleDto>
    {
        public HesapHareketEkleDtoValidator()
        {
            RuleFor(x => x.BorcluID)
                .Cascade(CascadeMode.Stop)
                .GreaterThan(0)
                .WithMessage("Gönderen ID geçerli bir değer olmalıdır.");

            RuleFor(x => x.AlacakId)
                .Cascade(CascadeMode.Stop)
                .GreaterThan(0)
                .WithMessage("Alıcı ID geçerli bir değer olmalıdır.");

            RuleFor(x => x.Tutar)
                .Cascade(CascadeMode.Stop)
                .GreaterThan(0)
                .WithMessage("Tutar sıfırdan büyük olmalıdır.");


            RuleFor(x => x.HareketTuru)
                .Cascade(CascadeMode.Stop)
                .IsInEnum()
                .WithMessage("Geçersiz Hareket Türü.");


            RuleFor(x => x.Aciklama)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Açıklama boş olamaz.")
                .MaximumLength(250)
                .WithMessage("Açıklama en fazla 250 karakter olabilir.");


            When(x => x.HareketTuru == HareketTuru.DosyaMasrafi, () =>
            {
                RuleFor(x => x.DosyaId)
                    .Cascade(CascadeMode.Stop)
                    .NotNull()
                    .GreaterThan(0)
                    .WithMessage("DosyaMasrafı türünde DosyaId boş veya 0 olamaz.");
            });


            When(x => x.HareketTuru != HareketTuru.DosyaMasrafi, () =>
            {
                RuleFor(x => x.DosyaId)
                    .Cascade(CascadeMode.Stop)
                    .Must(x => x == null)
                    .WithMessage("DosyaId sadece DosyaMasrafı türünde dolu olabilir.");
            });
        }
        //FluentValidation, C# projelerinde veri doğrulama (validation) işlemlerini daha sade,
        //okunabilir ve etkili şekilde yapmanı sağlayan bir kütüphanedir.

        // RuleFor() metodu, hangi özelliği doğrulamak istediğini belirtir.

        //Cascade() ile bir alanda birden fazla kural varsa, ilk hata sonrası diğer kuralların çalışmasını durdurabilirsin.

        //When() blokları, belirli şartlara göre farklı kurallar uygulamanı sağlar(koşullu validasyon).
    }
}
