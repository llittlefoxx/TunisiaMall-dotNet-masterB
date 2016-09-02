using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.Domain.Entities;
namespace TunisiaMall.Data.Models.Mapping
{
    public class mvtstockMap : EntityTypeConfiguration<mvtstock>
    {
        public mvtstockMap()
        {

            ToTable("mvtstock");
            // Primary Key
            this.HasKey(t => t.idMvt);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.nature)
                .HasMaxLength(255);

            // Table & Column Mappings
           
            this.Property(t => t.idMvt).HasColumnName("idMvt");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.nature).HasColumnName("nature");
            this.Property(t => t.qte).HasColumnName("qte");
            this.Property(t => t.supplier).HasColumnName("supplier");
            this.Property(t => t.idProduct).HasColumnName("idProduct");

            // Relationships
            this.HasOptional(t => t.product)
                .WithMany(t => t.mvtstocks)
                .HasForeignKey(d => d.idProduct);

        }
    }
}
