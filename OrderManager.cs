using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer
{
    class OrderManager : IOrderService
    {
        public void Buyer(Gamer gamer, Order order)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " kisi" + order.OrderName + " adli oyunu satin aldi  ");
            Console.WriteLine("Urunun fiyati:" + order.OrderPrice);
        }

        public void Sale(Gamer gamer, Order order, Campaign campaign)
        {
            double SalesPrice = order.OrderPrice - ( (order.OrderPrice * campaign.Discount)/100);
            Console.WriteLine("Urunun indirimli fiyati: " + SalesPrice);

            Console.WriteLine(gamer.FirstName
                + " " + gamer.LastName.ToUpper() + " isimli kullanıcı "
                + order.OrderName + " ürününü " + campaign.CampaignName + " kampanyası dahilinde"
                + " %" + campaign.Discount + " indirim ile "+SalesPrice+" lira fiyata aldi!");
        }
    }
}
