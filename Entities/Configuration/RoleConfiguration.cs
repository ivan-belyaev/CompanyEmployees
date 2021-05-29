using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    /// <summary>
    /// Role Configuration
    /// </summary>
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        /// <summary>
        /// Seed default data
        /// </summary>
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
              new IdentityRole
              {
                  Name = "Manager",
                  NormalizedName = "MANAGER"
              },
              new IdentityRole
              {
                  Name = "Administrator",
                  NormalizedName = "ADMINISTRATOR"
              }
            );
        }
    }
}
