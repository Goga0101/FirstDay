using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using FirstDay.Poco;

namespace FirstDay.PocoConfiguration
{
   
        public class UserConfiguration : IEntityTypeConfiguration<User>
        {
            public void Configure(EntityTypeBuilder<User> builder)
            {
                builder.HasKey(x => x.Id);
                builder.HasOne(x => x.Gender);
            }
        }
    
}
