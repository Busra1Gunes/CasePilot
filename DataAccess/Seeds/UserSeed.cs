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
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Password Yonetim123.,
            builder.HasData(new User { ID=1, CityID=1,DistrictID=1, Name="Yönetim",Surname="Hesabı",Mail= "yonetim@gmail.com", UserName="yonetim",
                Password= "$2a$12$GgOpgM7pbk/ZJX651CXYSOqATge1BBViPvrBnw9gJcbteIfWwTPDC", CreatedDate=DateTime.Now,RoleID=1,Status=true});
        }
    }
}
