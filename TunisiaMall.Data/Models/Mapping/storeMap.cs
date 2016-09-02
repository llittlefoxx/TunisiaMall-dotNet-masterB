using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.Domain.Entities;
namespace TunisiaMall.Data.Models.Mapping
{
    public class storeMap : EntityTypeConfiguration<store>
    {
        public storeMap()
        {

            ToTable("store");
            // Primary Key
            this.HasKey(t => t.idStroe);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.status)
                .HasMaxLength(255);

            this.Property(t => t.tel)
                .HasMaxLength(255);

            // Table & Column Mappings
            
            this.Property(t => t.idStroe).HasColumnName("idStroe");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.openingDay).HasColumnName("openingDay");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.tel).HasColumnName("tel");
            this.Property(t => t.category_fk).HasColumnName("category_fk");
            this.Property(t => t.idUser).HasColumnName("idUser");

            // Relationships
            this.HasMany(t => t.events)
                .WithMany(t => t.stores)
                .Map(m =>
                    {
                        m.ToTable("storeevent", "tunisiamall");
                        m.MapLeftKey("idStore");
                        m.MapRightKey("idEvent");
                    });

            this.HasOptional(t => t.category)
                .WithMany(t => t.stores)
                .HasForeignKey(d => d.category_fk);
            this.HasOptional(t => t.user)
                .WithMany(t => t.stores)
                .HasForeignKey(d => d.idUser);

        }
    }
}
