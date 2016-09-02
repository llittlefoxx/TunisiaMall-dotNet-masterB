using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.Domain.Entities;
namespace TunisiaMall.Data.Models.Mapping
{
    public class subscriptionMap : EntityTypeConfiguration<subscription>
    {
        public subscriptionMap()
        {
            // Primary Key
            this.HasKey(t => t.idSubscription);

            // Table & Column Mappings
            ToTable("subscription");
            this.Property(t => t.idEvent).HasColumnName("idEvent");
            this.Property(t => t.idSubscription).HasColumnName("idSubscription");
            this.Property(t => t.idUser).HasColumnName("idUser");

            // Relationships
            this.HasRequired(t => t.eventt)
                .WithMany(t => t.subscriptions)
                .HasForeignKey(d => d.idEvent);
            this.HasRequired(t => t.user)
                .WithMany(t => t.subscriptions)
                .HasForeignKey(d => d.idUser);

        }
    }
}
