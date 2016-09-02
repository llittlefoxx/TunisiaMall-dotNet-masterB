using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.Domain.Entities;
namespace TunisiaMall.Data.Models.Mapping
{
    public class shoprequestMap : EntityTypeConfiguration<shoprequest>
    {
        public shoprequestMap()
        {

            ToTable("shoprequest");
            // Primary Key
            this.HasKey(t => t.idRequest);

            // Properties
            this.Property(t => t.address)
                .HasMaxLength(255);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.firstName)
                .HasMaxLength(255);

            this.Property(t => t.job)
                .HasMaxLength(255);

            this.Property(t => t.lastName)
                .HasMaxLength(255);

            this.Property(t => t.phone)
                .HasMaxLength(255);

            // Table & Column Mappings
           
            this.Property(t => t.idRequest).HasColumnName("idRequest");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.birthdate).HasColumnName("birthdate");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.firstName).HasColumnName("firstName");
            this.Property(t => t.job).HasColumnName("job");
            this.Property(t => t.lastName).HasColumnName("lastName");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.plannedOpeningDate).HasColumnName("plannedOpeningDate");
            this.Property(t => t.rcptDate).HasColumnName("rcptDate");
            this.Property(t => t.rentPeriod).HasColumnName("rentPeriod");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.storeInMall).HasColumnName("storeInMall");
            this.Property(t => t.category_fk).HasColumnName("category_fk");

            // Relationships
            this.HasOptional(t => t.category)
                .WithMany(t => t.shoprequests)
                .HasForeignKey(d => d.category_fk);

        }
    }
}
