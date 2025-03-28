using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Seeds
{
    public class EvrakTurSeed : IEntityTypeConfiguration<EvrakTur>
    {
        public void Configure(EntityTypeBuilder<EvrakTur> builder)
        {
            builder.HasData(new EvrakTur { Id = 1, EvrakTurAdi = "TcKimlik", Tur = "DosyaEvrak", Durum = false },
          new EvrakTur { Id = 2, EvrakTurAdi = "Sici Kaydı", Tur = "KullaniciEvrak", Durum = false });
        }
    }
}
