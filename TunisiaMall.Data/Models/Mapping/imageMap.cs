using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.Domain.Entities;
namespace TunisiaMall.Data.Models.Mapping
{
    public class imageMap : EntityTypeConfiguration<image>
    {
        public imageMap()
        {
            ToTable("image");
            // Primary Key
            this.HasKey(t => t.idImage);

            // Properties
            this.Property(t => t.imagePath)
                .HasMaxLength(255);

            // Table & Column Mappings
           
            this.Property(t => t.idImage).HasColumnName("idImage");
            this.Property(t => t.imagePath).HasColumnName("imagePath");
            this.Property(t => t.idProduct).HasColumnName("idProduct");

            // Relationships
            this.HasOptional(t => t.product)
                .WithMany(t => t.images)
                .HasForeignKey(d => d.idProduct);

        }
    }
}
