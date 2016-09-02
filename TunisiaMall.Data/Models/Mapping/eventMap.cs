using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.Domain.Entities;
namespace TunisiaMall.Data.Models.Mapping
{
    public class eventMap : EntityTypeConfiguration<Event>
    {
        public eventMap()
        {

            ToTable("event");
            // Primary Key
            this.HasKey(t => t.idEvent);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.titleEvent)
                .HasMaxLength(255);

            this.Property(t => t.typeEvent)
                .HasMaxLength(255);

            // Table & Column Mappings
      
            this.Property(t => t.idEvent).HasColumnName("idEvent");
            this.Property(t => t.dateEvent).HasColumnName("dateEvent");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.periodEvent).HasColumnName("periodEvent");
            this.Property(t => t.titleEvent).HasColumnName("titleEvent");
            this.Property(t => t.typeEvent).HasColumnName("typeEvent");
        }
    }
}
