using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Pattern;

namespace TunisiaMall.Service.Services
{
    public interface IMessageService : IService<message>
    {
        List<message> getMessagesForUser(int idUser);
        List<message> getConversation(int idUser1, int idUser2);
        void sendMessage(int idSender, int idReceiver, string text);
        void deleteConversation(int idUser1, int idUser2);
    }
}
