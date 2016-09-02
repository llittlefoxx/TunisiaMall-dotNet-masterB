using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.Domain.Entities;
namespace TunisiaMall.Data.Models.Mapping
{
    public class commentMap : EntityTypeConfiguration<comment>
    {
        public commentMap()
        {

            ToTable("comment");
            // Primary Key
            this.HasKey(t => t.idComment);

            // Properties
            this.Property(t => t.text)
                .HasMaxLength(255);

            // Table & Column Mappings
          
            this.Property(t => t.idComment).HasColumnName("idComment");
            this.Property(t => t.commentDate).HasColumnName("commentDate");
            this.Property(t => t.text).HasColumnName("text");
            this.Property(t => t.idPost).HasColumnName("idPost");
            this.Property(t => t.idUser).HasColumnName("idUser");

            // Relationships
            this.HasRequired(t => t.post)
                .WithMany(t => t.comments)
                .HasForeignKey(d => d.idPost);
            this.HasRequired(t => t.user)
                .WithMany(t => t.comments)
                .HasForeignKey(d => d.idUser);

        }
    }
}
