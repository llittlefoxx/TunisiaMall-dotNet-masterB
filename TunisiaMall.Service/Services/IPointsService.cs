using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Domain.Entities;

namespace TunisiaMall.Service.Services
{
    public interface IPonitsService
    {
        void addPointsToCustomer(customer u, int points);
        void removePointsFromCustomer(customer u, int points);
        void showAffordableGifts(customer u);
        // Normally :  void convertPointsToGift(customer u, gift g);
        void convertPoints(customer u, int points);
        Dictionary<customer, int> getBestClient(int number);

    }
}
