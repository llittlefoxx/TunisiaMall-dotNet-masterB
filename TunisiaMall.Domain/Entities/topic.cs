using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunisiaMall.Domain.Entities
{
    public class topic
    {
        public topic()
        {
            this.posts = new List<post>();
        }

        public int idTopic { get; set; }
        public string title { get; set; }

        public ICollection<post> posts { get; set; }
    }
}
