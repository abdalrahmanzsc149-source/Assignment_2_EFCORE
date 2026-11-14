using Assignment_2_EFCORE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_2_EFCORE.Data
{
    public class OrganizerProfileConfiguration : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.HasKey(op => op.Id);

            builder.HasOne(op => op.Organizer)
                   .WithOne(o => o.OrganizerProfile)
                   .HasForeignKey<OrganizerProfile>(op => op.OrganizerId);
        }
    }
}