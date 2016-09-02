using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.Domain.Entities;
namespace TunisiaMall.Data.Models.Mapping
{
    public class friendshipMap : EntityTypeConfiguration<friendship>
    {
        public friendshipMap()
        {
            ToTable("friendship");
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
           
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.accepted).HasColumnName("accepted");
            this.Property(t => t.idUser1).HasColumnName("idUser1");
            this.Property(t => t.idUser2).HasColumnName("idUser2");

            // Relationships
            this.HasRequired(t => t.user1)
                .WithMany(t => t.sentFriendRequests)
                .HasForeignKey(d => d.idUser1);
            this.HasRequired(t => t.user2)
                .WithMany(t => t.friendRequests)
                .HasForeignKey(d => d.idUser2);

        }
    }
}
