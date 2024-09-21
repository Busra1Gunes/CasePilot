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
    public class IlSeed : IEntityTypeConfiguration<Il>
    {
        public void Configure(EntityTypeBuilder<Il> builder)
        {
            builder.HasData(
                new Il { Id = 1, Adi = "Adana" },
                 new Il { Id = 2, Adi = "Adıyaman" },
                 new Il { Id = 3, Adi = "Afyonkarahisar" },
                 new Il { Id = 4, Adi = "Ağrı" },
                 new Il { Id = 5, Adi = "Amasya" },
                 new Il { Id = 6, Adi = "Ankara" },
                 new Il { Id = 7, Adi = "Antalya" },
                 new Il { Id = 8, Adi = "Artvin" },
                 new Il { Id = 9, Adi = "Aydın" },
                 new Il { Id = 10, Adi = "Balıkesir" },
                 new Il { Id = 11, Adi = "Bilecik" },
                 new Il { Id = 12, Adi = "Bingöl" },
                 new Il { Id = 13, Adi = "Bitlis" },
                 new Il { Id = 14, Adi = "Bolu" },
                 new Il { Id = 15, Adi = "Burdur" },
                 new Il { Id = 16, Adi = "Bursa" },
                 new Il { Id = 17, Adi = "Çanakkale" },
                 new Il { Id = 18, Adi = "Çankırı" },
                 new Il { Id = 19, Adi = "Çorum" },
                 new Il { Id = 20, Adi = "Denizli" },
                 new Il { Id = 21, Adi = "Diyarbakır" },
                 new Il { Id = 22, Adi = "Edirne" },
                 new Il { Id = 23, Adi = "Elazığ" },
                 new Il { Id = 24, Adi = "Erzincan" },
                 new Il { Id = 25, Adi = "Erzurum" },
                 new Il { Id = 26, Adi = "Eskişehir" },
                 new Il { Id = 27, Adi = "Gaziantep" },
                 new Il { Id = 28, Adi = "Giresun" },
                 new Il { Id = 29, Adi = "Gümüşhane" },
                 new Il { Id = 30, Adi = "Hakkari" },
                 new Il { Id = 31, Adi = "Hatay" },
                 new Il { Id = 32, Adi = "Isparta" },
                 new Il { Id = 33, Adi = "Mersin" },
                 new Il { Id = 34, Adi = "İstanbul" },
                 new Il { Id = 35, Adi = "İzmir" },
                 new Il { Id = 36, Adi = "Kars" },
                 new Il { Id = 37, Adi = "Kastamonu" },
                 new Il { Id = 38, Adi = "Kayseri" },
                 new Il { Id = 39, Adi = "Kırklareli" },
                 new Il { Id = 40, Adi = "Kırşehir" },
                 new Il { Id = 41, Adi = "Kocaeli" },
                 new Il { Id = 42, Adi = "Konya" },
                 new Il { Id = 43, Adi = "Kütahya" },
                 new Il { Id = 44, Adi = "Malatya" },
                 new Il { Id = 45, Adi = "Manisa" },
                 new Il { Id = 46, Adi = "Kahramanmaraş" },
                 new Il { Id = 47, Adi = "Mardin" },
                 new Il { Id = 48, Adi = "Muğla" },
                 new Il { Id = 49, Adi = "Muş" },
                 new Il { Id = 50, Adi = "Nevşehir" },
                 new Il { Id = 51, Adi = "Niğde" },
                 new Il { Id = 52, Adi = "Ordu" },
                 new Il { Id = 53, Adi = "Rize" },
                 new Il { Id = 54, Adi = "Sakarya" },
                 new Il { Id = 55, Adi = "Samsun" },
                 new Il { Id = 56, Adi = "Siirt" },
                 new Il { Id = 57, Adi = "Sinop" },
                 new Il { Id = 58, Adi = "Sivas" },
                 new Il { Id = 59, Adi = "Tekirdağ" },
                 new Il { Id = 60, Adi = "Tokat" },
                 new Il { Id = 61, Adi = "Trabzon" },
                 new Il { Id = 62, Adi = "Tunceli" },
                 new Il { Id = 63, Adi = "Şanlıurfa" },
                 new Il { Id = 64, Adi = "Uşak" },
                 new Il { Id = 65, Adi = "Van" },
                 new Il { Id = 66, Adi = "Yozgat" },
                 new Il { Id = 67, Adi = "Zonguldak" },
                 new Il { Id = 68, Adi = "Aksaray" },
                 new Il { Id = 69, Adi = "Bayburt" },
                 new Il { Id = 70, Adi = "Karaman" },
                 new Il { Id = 71, Adi = "Kırıkkale" },
                 new Il { Id = 72, Adi = "Batman" },
                 new Il { Id = 73, Adi = "Şırnak" },
                 new Il { Id = 74, Adi = "Bartın" },
                 new Il { Id = 75, Adi = "Ardahan" },
                 new Il { Id = 76, Adi = "Iğdır" },
                 new Il { Id = 77, Adi = "Yalova" },
                 new Il { Id = 78, Adi = "Karabük" },
                 new Il { Id = 79, Adi = "Kilis" },
                 new Il { Id = 80, Adi = "Osmaniye" },
                 new Il { Id = 81, Adi = "Düzce" }
                );
        }
    }
}
