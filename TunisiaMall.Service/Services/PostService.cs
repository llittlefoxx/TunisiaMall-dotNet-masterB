using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Data.Infrastructure;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Pattern;

namespace TunisiaMall.Service.Services
{
    public class PostService : Service<post> , IPostService
    {
        // Attributes
        private static IDatabaseFactory dbFactory = new DatabaseFactory();
        private static IUnitOfWork work = new UnitOfWork(dbFactory);
        // Methods
        public PostService() : base(work){ }

        public IEnumerable<post> GetPostByTopic(int idTopic)
        {
            return GetMany(p => p.idTopic == idTopic);
        }
        public post GetPostByTitle(string Title)
        {
            return GetMany(p => p.title == Title).First();
        }
        public IEnumerable<post> GetAllPost()
        {
            return work.getRepository<post>().GetMany();
        }
        
        public IEnumerable<post> GetPostByDate(DateTime Date)
        {
            return GetMany(p => p.postDate == Date);
        }
        
        public post GetPost(int id)
        {
            return work.getRepository<post>().FindById(id);
        }
    }
}
