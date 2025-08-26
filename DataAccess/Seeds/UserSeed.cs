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
            builder.HasData(new User { ID=1, CityID=1,DistrictID=1, Name="Büşra",Surname="Güneş",Mail="", UserName="busra",Password="12345", CreatedDate=DateTime.Now,RoleID=1});
        }
    }
}
