using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class user
    {


        public int idUser { get; set; }
        public string address { get; set; }
        public Nullable<bool> baned { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
        public string firstName { get; set; }
        public string gender { get; set; }
        public string job { get; set; }
        public string lastName { get; set; }
        public string login { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string pictureUrl { get; set; }






        public ICollection<comment> comments { get; set; }
        public ICollection<complaint> complaints { get; set; }
        public ICollection<friendship> sentFriendRequests { get; set; }
        public ICollection<friendship> friendRequests { get; set; }
        public ICollection<gestbookentry> gestbookentries { get; set; }
        public virtual ICollection<message> recivedMessages { get; set; }
        public virtual ICollection<message> sentMessages { get; set; }
        public ICollection<order> orders { get; set; }
        public ICollection<post> posts { get; set; }
        public ICollection<store> stores { get; set; }
        public ICollection<subscription> subscriptions { get; set; }
    }
}
