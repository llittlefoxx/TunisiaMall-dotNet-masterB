using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.Domain.Entities;
namespace TunisiaMall.Data.Models.Mapping
{
    public class topicMap : EntityTypeConfiguration<topic>
    {
        public topicMap()
        {
            ToTable("topic");
            // Primary Key
            this.HasKey(t => t.idTopic);

            // Properties
            this.Property(t => t.title)
                .HasMaxLength(255);

            // Table & Column Mappings

            this.Property(t => t.idTopic).HasColumnName("idTopic");
            this.Property(t => t.title).HasColumnName("title");
        }
    }
}
