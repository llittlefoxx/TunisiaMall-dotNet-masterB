using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.Domain.Entities;
namespace TunisiaMall.Data.Models.Mapping
{
    public class messageMap : EntityTypeConfiguration<message>
    {
        public messageMap()
        {
            ToTable("message");
            // Primary Key
            this.HasKey(t => t.idMessage);

            // Properties
            this.Property(t => t.text)
                .HasMaxLength(255);

            // Table & Column Mappings
           
            this.Property(t => t.idMessage).HasColumnName("idMessage");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.text).HasColumnName("text");
            this.Property(t => t.idUserReciver_fk).HasColumnName("idUserReciver_fk");
            this.Property(t => t.idUserSender_FK).HasColumnName("idUserSender_FK");

            // Relationships
            this.HasRequired(t => t.reciver)
                .WithMany(t => t.recivedMessages)
                .HasForeignKey(d => d.idUserReciver_fk);
            this.HasRequired(t => t.sender)
                .WithMany(t => t.sentMessages)
                .HasForeignKey(d => d.idUserSender_FK);

        }
    }
}
