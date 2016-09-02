using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.Domain.Entities;
namespace TunisiaMall.Data.Models.Mapping
{
    public class postMap : EntityTypeConfiguration<post>
    {
        public postMap()
        {
            ToTable("post");
            // Primary Key
            this.HasKey(t => t.idPost);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);
            this.Property(t => t.title)
                .HasMaxLength(255);

            // Table & Column Mappings

            this.Property(t => t.idPost).HasColumnName("idPost");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.rating).HasColumnName("rating");
            this.Property(t => t.postDate).HasColumnName("postDate");
            this.Property(t => t.idUser).HasColumnName("idUser");
            this.Property(t => t.idTopic).HasColumnName("idTopic");

            // Relationships
            this.HasRequired(t => t.user)
                .WithMany(t => t.posts)
                .HasForeignKey(d => d.idUser);
            this.HasRequired(p => p.topic)
                .WithMany(t => t.posts)
                .HasForeignKey(d => d.idTopic);

        }
    }
}
