using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.Domain.Entities;
namespace TunisiaMall.Data.Models.Mapping
{
    public class complaintMap : EntityTypeConfiguration<complaint>
    {
        public complaintMap()
        {
            ToTable("complaint");
            // Primary Key
            this.HasKey(t => t.idComplaint);

            // Properties
            this.Property(t => t.nature)
                .HasMaxLength(255);

            this.Property(t => t.text)
                .HasMaxLength(255);

            // Table & Column Mappings
          
            this.Property(t => t.idComplaint).HasColumnName("idComplaint");
            this.Property(t => t.complaintDate).HasColumnName("complaintDate");
            this.Property(t => t.nature).HasColumnName("nature");
            this.Property(t => t.text).HasColumnName("text");
            this.Property(t => t.idUser).HasColumnName("idUser");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.complaints)
                .HasForeignKey(d => d.idUser);

        }
    }
}
