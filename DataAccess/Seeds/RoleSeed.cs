using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class RoleSeed : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(new Role { ID = 1, Name="Admin", Description="This is a admin roles" ,CreatedDate = DateTime.Now ,Status=true});
        }
    }
}
