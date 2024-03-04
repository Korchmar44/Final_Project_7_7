using Final_Project_7_7.Manager;
using Final_Project_7_7.Services;
using Final_Project_7_7.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_7_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            NewOrder order = new NewOrder();
            Console.ReadKey();
        }
    }

    internal class NewOrder
    {
        static DeliverySelector deliverySelector;
        static DeliveryManager deliveryManager ;
        Delivery delivery;
        AdditionalOrderInfo orderInfo;
        Order<Delivery, AdditionalOrderInfo> order;
        public NewOrder()
        {
            deliverySelector = new DeliverySelector();
            deliveryManager = new DeliveryManager(deliverySelector);
            delivery = deliveryManager.Delivery;
            orderInfo = new AdditionalOrderInfo("Важно: доставить до двери", "Осторожно: хрупкое содержимое");
            order = new Order<Delivery, AdditionalOrderInfo>(delivery, orderInfo);
            order.AddOrder(order);
            order.DisplayOrderDetails();
        }
    }
}
