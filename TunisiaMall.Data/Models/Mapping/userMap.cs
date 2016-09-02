using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TunisiaMall.Domain.Entities;

namespace TunisiaMall.Data.Models.Mapping
{
    public class userMap : EntityTypeConfiguration<user>
    {
        public userMap()
        {
            // Primary Key
            this.HasKey(t => t.idUser);

            // Properties
            this.Property(t => t.address)
                .HasMaxLength(255);

            this.Property(t => t.firstName)
                .HasMaxLength(255);

            this.Property(t => t.gender)
                .HasMaxLength(255);

            this.Property(t => t.job)
                .HasMaxLength(255);

            this.Property(t => t.lastName)
                .HasMaxLength(255);

            this.Property(t => t.login)
                .HasMaxLength(255);

            this.Property(t => t.mail)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            this.Property(t => t.phone)
                .HasMaxLength(255);

            this.Property(t => t.pictureUrl)
                .HasMaxLength(255);






            // Table & Column Mappings
            ToTable("user");
            this.Property(t => t.idUser).HasColumnName("idUser");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.baned).HasColumnName("baned");
            this.Property(t => t.birthdate).HasColumnName("birthdate");
            this.Property(t => t.firstName).HasColumnName("firstName");
            this.Property(t => t.gender).HasColumnName("gender");
            this.Property(t => t.job).HasColumnName("job");
            this.Property(t => t.lastName).HasColumnName("lastName");
            this.Property(t => t.login).HasColumnName("login");
            this.Property(t => t.mail).HasColumnName("mail");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.pictureUrl).HasColumnName("pictureUrl");

            Map<customer>(c =>
            {
                c.Requires("USER_TYPE").HasValue("customer");
            });
            Map<shopowner>(c =>
            {
                c.Requires("USER_TYPE").HasValue("shopOwner");
            });
        }
    }
}
