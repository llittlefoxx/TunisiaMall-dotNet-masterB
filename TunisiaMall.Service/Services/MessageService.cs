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
    public class MessageService : Service<message>, IMessageService
    {
        // Attributes
        private static IDatabaseFactory dbFactory = new DatabaseFactory();
        private static IUnitOfWork work = new UnitOfWork(dbFactory);
        // Methods
        public MessageService() : base(work) { }

        public List<message> getConversation(int idUser1, int idUser2)
        {
            return GetMany(m => (m.sender.idUser == idUser1 && m.reciver.idUser == idUser2) || (m.sender.idUser == idUser2 && m.reciver.idUser == idUser1)).OrderBy(m => m.date).ToList();
        }

        public List<message> getMessagesForUser(int idUser)
        {
            IUserService userService = new UserService();
            user u = userService.FindById(idUser);
            var l = u.recivedMessages.GroupBy(m => m.sender);
            List<message> result = new List<message>();
            foreach (var item in l)
            {
                result.Add(item.Last());
            }
            return result;
        }

        public void sendMessage(int idSender, int idReceiver, string text)
        {
            IUserService userService = new UserService();
            user sender = userService.FindById(idSender);
            user receiver = userService.FindById(idReceiver);
            message m = new message();
            m.text = text;
            m.date = DateTime.Now;
            m.sender = sender;
            m.reciver = receiver;
            this.Create(m);
            this.Commit();
        }

        public void deleteConversation(int idUser1, int idUser2)
        {
            List<message> messagesList = this.getConversation(idUser1, idUser2);
            foreach (var item in messagesList)
            {
                this.Delete(item);
            }
            this.Commit();
        }
    }
}
