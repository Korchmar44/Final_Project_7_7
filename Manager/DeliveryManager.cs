using Final_Project_7_7.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_7_7.Manager
{
    /// <summary>
    /// Управляет процессом доставки
    /// </summary>
    public class DeliveryManager
    {
        private Delivery delivery;
        /// <summary>
        /// Получает выбранную доставку
        /// </summary>
        public Delivery Delivery { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса DeliveryManager
        /// </summary>
        /// <param name="deliverySelector">Селектор доставки</param>
        public DeliveryManager(DeliverySelector deliverySelector)
        {
            delivery = new DeliverySelector().SelectDelivery();
            Delivery = delivery;
        }
    }
}
