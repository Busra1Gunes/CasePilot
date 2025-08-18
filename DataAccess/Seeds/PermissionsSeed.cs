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
    public class PermissionsSeed : IEntityTypeConfiguration<Permissions>
    {
        public void Configure(EntityTypeBuilder<Permissions> builder)
        {
            builder.HasData(new Permissions { ID = 1, Name = "Case File List", Code = "caseFile-list", Status = true, CreatedDate = DateTime.Now });
            //builder.HasData(new Permissions { ID = 2, Name = "User List", Code = "user-list", Status = true, CreatedDate = DateTime.Now });
            //builder.HasData(new Permissions { ID = 3, Name = "Case Type List", Code = "casetype-list", Status = true, CreatedDate = DateTime.Now });
        
        }
    }
}
