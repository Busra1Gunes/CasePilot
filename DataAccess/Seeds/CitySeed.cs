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
    public class CitySeed : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City { ID = 1, Name = "Adana" },
                 new City { ID = 2, Name = "Adıyaman" },
                 new City { ID = 3, Name = "Afyonkarahisar" },
                 new City { ID = 4, Name = "Ağrı" },
                 new City { ID = 5, Name = "Amasya" },
                 new City { ID = 6, Name = "Ankara" },
                 new City { ID = 7, Name = "Antalya" },
                 new City { ID = 8, Name = "Artvin" },
                 new City { ID = 9, Name = "Aydın" },
                 new City { ID = 10, Name = "Balıkesir" },
                 new City { ID = 11, Name = "Bilecik" },
                 new City { ID = 12, Name = "Bingöl" },
                 new City { ID = 13, Name = "Bitlis" },
                 new City { ID = 14, Name = "Bolu" },
                 new City { ID = 15, Name = "Burdur" },
                 new City { ID = 16, Name = "Bursa" },
                 new City { ID = 17, Name = "Çanakkale" },
                 new City { ID = 18, Name = "Çankırı" },
                 new City { ID = 19, Name = "Çorum" },
                 new City { ID = 20, Name = "Denizli" },
                 new City { ID = 21, Name = "Diyarbakır" },
                 new City { ID = 22, Name = "Edirne" },
                 new City { ID = 23, Name = "Elazığ" },
                 new City { ID = 24, Name = "Erzincan" },
                 new City { ID = 25, Name = "Erzurum" },
                 new City { ID = 26, Name = "Eskişehir" },
                 new City { ID = 27, Name = "Gaziantep" },
                 new City { ID = 28, Name = "Giresun" },
                 new City { ID = 29, Name = "Gümüşhane" },
                 new City { ID = 30, Name = "Hakkari" },
                 new City { ID = 31, Name = "Hatay" },
                 new City { ID = 32, Name = "Isparta" },
                 new City { ID = 33, Name = "Mersin" },
                 new City { ID = 34, Name = "İstanbul" },
                 new City { ID = 35, Name = "İzmir" },
                 new City { ID = 36, Name = "Kars" },
                 new City { ID = 37, Name = "Kastamonu" },
                 new City { ID = 38, Name = "Kayseri" },
                 new City { ID = 39, Name = "Kırklareli" },
                 new City { ID = 40, Name = "Kırşehir" },
                 new City { ID = 41, Name = "Kocaeli" },
                 new City { ID = 42, Name = "Konya" },
                 new City { ID = 43, Name = "Kütahya" },
                 new City { ID = 44, Name = "Malatya" },
                 new City { ID = 45, Name = "Manisa" },
                 new City { ID = 46, Name = "Kahramanmaraş" },
                 new City { ID = 47, Name = "Mardin" },
                 new City { ID = 48, Name = "Muğla" },
                 new City { ID = 49, Name = "Muş" },
                 new City { ID = 50, Name = "Nevşehir" },
                 new City { ID = 51, Name = "Niğde" },
                 new City { ID = 52, Name = "Ordu" },
                 new City { ID = 53, Name = "Rize" },
                 new City { ID = 54, Name = "Sakarya" },
                 new City { ID = 55, Name = "Samsun" },
                 new City { ID = 56, Name = "Siirt" },
                 new City { ID = 57, Name = "Sinop" },
                 new City { ID = 58, Name = "Sivas" },
                 new City { ID = 59, Name = "Tekirdağ" },
                 new City { ID = 60, Name = "Tokat" },
                 new City { ID = 61, Name = "Trabzon" },
                 new City { ID = 62, Name = "Tunceli" },
                 new City { ID = 63, Name = "Şanlıurfa" },
                 new City { ID = 64, Name = "Uşak" },
                 new City { ID = 65, Name = "Van" },
                 new City { ID = 66, Name = "Yozgat" },
                 new City { ID = 67, Name = "Zonguldak" },
                 new City { ID = 68, Name = "Aksaray" },
                 new City { ID = 69, Name = "Bayburt" },
                 new City { ID = 70, Name = "Karaman" },
                 new City { ID = 71, Name = "Kırıkkale" },
                 new City { ID = 72, Name = "Batman" },
                 new City { ID = 73, Name = "Şırnak" },
                 new City { ID = 74, Name = "Bartın" },
                 new City { ID = 75, Name = "Ardahan" },
                 new City { ID = 76, Name = "Iğdır" },
                 new City { ID = 77, Name = "Yalova" },
                 new City { ID = 78, Name = "Karabük" },
                 new City { ID = 79, Name = "Kilis" },
                 new City { ID = 80, Name = "Osmaniye" },
                 new City { ID = 81, Name = "Düzce" }
                );
        }
    }
}
