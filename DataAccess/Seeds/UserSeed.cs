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
            //Password Busra123.,
            builder.HasData(new User { ID=1, CityID=1,DistrictID=1, Name="Büşra",Surname="Güneş",Mail= "busragunes@gmail.com", UserName="busra",Password= "$2a$12$hdNKsAO3bfSb9l7we/6Ww.rpkDzM5KjEBa09B6BfK5B/12.ZOVAt.", CreatedDate=DateTime.Now,RoleID=1,Status=true});
        }
    }
}
