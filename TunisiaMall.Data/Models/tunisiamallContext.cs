using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TunisiaMall.Data.Models.Mapping;
using TunisiaMall.Domain.Entities;

namespace TunisiaMall.Data.Models
{
    public partial class tunisiamallContext : DbContext
    {
    


        public tunisiamallContext()
            : base("Name=tunisiamallContext")
        {
          
        }

        public DbSet<category> categories { get; set; }
        public DbSet<comment> comments { get; set; }
        public DbSet<complaint> complaints { get; set; }
        public DbSet<Event> events { get; set; }
        public DbSet<friendship> friendships { get; set; }
        public DbSet<gestbookentry> gestbookentries { get; set; }
        public DbSet<image> images { get; set; }
        public DbSet<message> messages { get; set; }
        public DbSet<mvtstock> mvtstocks { get; set; }
        public DbSet<orderline> orderlines { get; set; }
        public DbSet<order> orders { get; set; }
        public DbSet<post> posts { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<promotion> promotions { get; set; }
        public DbSet<promotionsuggest> promotionsuggests { get; set; }
        public DbSet<shoprequest> shoprequests { get; set; }
        public DbSet<store> stores { get; set; }
        public DbSet<subcategory> subcategories { get; set; }
        public DbSet<subscription> subscriptions { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<topic> topics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new categoryMap());
            modelBuilder.Configurations.Add(new commentMap());
            modelBuilder.Configurations.Add(new complaintMap());
            modelBuilder.Configurations.Add(new eventMap());
            modelBuilder.Configurations.Add(new friendshipMap());
            modelBuilder.Configurations.Add(new gestbookentryMap());
            modelBuilder.Configurations.Add(new imageMap());
            modelBuilder.Configurations.Add(new messageMap());
            modelBuilder.Configurations.Add(new mvtstockMap());
            modelBuilder.Configurations.Add(new orderlineMap());
            modelBuilder.Configurations.Add(new orderMap());
            modelBuilder.Configurations.Add(new postMap());
            modelBuilder.Configurations.Add(new productMap());
            modelBuilder.Configurations.Add(new promotionMap());
            modelBuilder.Configurations.Add(new promotionsuggestMap());
            modelBuilder.Configurations.Add(new shoprequestMap());
            modelBuilder.Configurations.Add(new storeMap());
            modelBuilder.Configurations.Add(new subcategoryMap());
            modelBuilder.Configurations.Add(new subscriptionMap());
            modelBuilder.Configurations.Add(new userMap());
            modelBuilder.Configurations.Add(new topicMap());
        }
    }
}
