using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.Domain.Entities;
namespace TunisiaMall.Data.Models.Mapping
{
    public class promotionMap : EntityTypeConfiguration<promotion>
    {
        public promotionMap()
        {

            ToTable("promotion");
            // Primary Key
            this.HasKey(t => t.idPromotion);

            // Properties
            this.Property(t => t.idPromotion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            
            this.Property(t => t.idPromotion).HasColumnName("idPromotion");
            this.Property(t => t.endDate).HasColumnName("endDate");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.startDate).HasColumnName("startDate");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.value).HasColumnName("value");
        }
    }
}
