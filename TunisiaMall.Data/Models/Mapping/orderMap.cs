using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.Domain.Entities;
namespace TunisiaMall.Data.Models.Mapping
{
    public class orderMap : EntityTypeConfiguration<order>
    {
        public orderMap()
        {
            // Primary Key
            this.HasKey(t => t.idOrder);

            // Properties
            this.Property(t => t.cardHolder)
                .HasMaxLength(255);

            this.Property(t => t.orderStatus)
                .HasMaxLength(255);

            this.Property(t => t.statusPayment)
                .HasMaxLength(255);

            // Table & Column Mappings
            ToTable("Orders");
            this.Property(t => t.idOrder).HasColumnName("idOrder");
            this.Property(t => t.amountPayed).HasColumnName("amountPayed");
            this.Property(t => t.cardHolder).HasColumnName("cardHolder");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.datePay).HasColumnName("datePay");
            this.Property(t => t.orderStatus).HasColumnName("orderStatus");
            this.Property(t => t.statusPayment).HasColumnName("statusPayment");
            this.Property(t => t.idUser).HasColumnName("idUser");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.orders)
                .HasForeignKey(d => d.idUser);

        }
    }
}
