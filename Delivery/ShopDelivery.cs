using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_7_7
{
    /// <summary>
    /// Представляет доставку из магазина.
    /// </summary>
    class ShopDelivery : Delivery
    {
        /// <summary>
        /// Получает или устанавливает название магазина.
        /// </summary>
        public string ShopName { get; set; } // Название магазина

        /// <summary>
        /// Инициализирует новый экземпляр класса ShopDelivery с указанным адресом, получателем и названием магазина.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="recipient">Получатель доставки.</param>
        /// <param name="shopName">Название магазина.</param>
        public ShopDelivery(string address, string recipient, string shopName) : base(address, recipient)
        {
            ShopName = shopName;
        }

        /// <summary>
        /// Отправляет доставку через магазин.
        /// </summary>
        public override void Send()
        {
            Console.WriteLine("Отправка через магазин: " + ShopName);
        }

        /// <summary>
        /// Доставляет посылку в магазин.
        /// </summary>
        public override void Deliver()
        {
            base.Deliver(); // Вызываем базовую реализацию метода Deliver
            Console.WriteLine("Посылка доставлена в магазин: " + ShopName);
        }
    }
}
