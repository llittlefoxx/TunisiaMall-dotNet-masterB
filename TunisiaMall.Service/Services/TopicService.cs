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
    public class TopicService : Service<topic>, ITopicService
    {
        private static IDatabaseFactory dbFactory = new DatabaseFactory();
        private static IUnitOfWork work = new UnitOfWork(dbFactory);

        public TopicService() : base(work){ }

        public IEnumerable<topic> GetAllTopic()
        {
            return work.getRepository<topic>().GetMany();
        }
    }
}
