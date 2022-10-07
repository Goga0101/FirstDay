using FirstDay.Poco;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FirstDay.PocoConfiguration
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {

        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasKey(x => x.GenderId);
        }

    }
}
