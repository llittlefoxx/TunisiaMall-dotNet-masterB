using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.Domain.Entities;
namespace TunisiaMall.Data.Models.Mapping
{
    public class promotionsuggestMap : EntityTypeConfiguration<promotionsuggest>
    {
        public promotionsuggestMap()
        {
            ToTable("promotionsuggest");
            // Primary Key
            this.HasKey(t => t.idPromotionSuggest);

            // Properties
            this.Property(t => t.desccription)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
           
            this.Property(t => t.idPromotionSuggest).HasColumnName("idPromotionSuggest");
            this.Property(t => t.desccription).HasColumnName("desccription");
            this.Property(t => t.endDate).HasColumnName("endDate");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.startDate).HasColumnName("startDate");
            this.Property(t => t.suggestionDate).HasColumnName("suggestionDate");
            this.Property(t => t.value).HasColumnName("value");
        }
    }
}
