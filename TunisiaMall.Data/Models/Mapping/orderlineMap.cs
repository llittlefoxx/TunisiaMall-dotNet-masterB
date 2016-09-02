using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.Domain.Entities;
namespace TunisiaMall.Data.Models.Mapping
{
    public class orderlineMap : EntityTypeConfiguration<orderline>
    {
        public orderlineMap()
        {

            ToTable("orderLine");
            // Primary Key
            this.HasKey(t => t.idOrderLine);

            // Table & Column Mappings
            
            this.Property(t => t.idOrderLine).HasColumnName("idOrderLine");
            this.Property(t => t.qte).HasColumnName("qte");
            this.Property(t => t.idOrder_fk).HasColumnName("idOrder_fk");
            this.Property(t => t.idProduct_fk).HasColumnName("idProduct_fk");

            // Relationships
            this.HasOptional(t => t.product)
                .WithMany(t => t.orderlines)
                .HasForeignKey(d => d.idProduct_fk);
            this.HasOptional(t => t.order)
                .WithMany(t => t.orderlines)
                .HasForeignKey(d => d.idOrder_fk);

        }
    }
}
