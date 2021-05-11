using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer
{
    interface IOrderService
    {
        void Buyer(Gamer gamer, Order order);
        void Sale(Gamer gamer, Order order, Campaign campaign);
    }
}
