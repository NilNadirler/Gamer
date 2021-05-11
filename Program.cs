using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.DogumYili = 1990;
            gamer1.FirstName = "Nil";
            gamer1.LastName = "Nadirler";
            gamer1.IdentityNumber = 12345;
            gamer1.Id = 1;

            UserValidationManager userValidationManager = new UserValidationManager();
            GamerManager gamerManager = new GamerManager(userValidationManager);
            gamerManager.Add(gamer1);


            Order order = new Order();
            order.OrderName = "Bebito";
            order.OrderId = 2;
            order.OrderPrice = 140;

            Campaign campaign = new Campaign();
            campaign.Discount = 50;
            campaign.Id = 3;
            campaign.CampaignName = "Sezon indirimi";

            OrderManager orderManager = new OrderManager();
            orderManager.Buyer(gamer1, order);
            orderManager.Sale(gamer1, order, campaign);

            Console.ReadLine();


        }
    }
}
