using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Seeds
{
    public class KullaniciSeed : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasData(new Kullanici { Id=1, IlId=1,IlceId=1, Adi="Büşra",Soyadi="Güneş", KullaniciAdi="busra",Sifre="12345", EklenmeTarihi=DateTime.Now});
        }
    }
}
