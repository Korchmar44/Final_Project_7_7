using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_7_7
{
    /// <summary>
    /// Представляет сущность доставки.
    /// </summary>
    public abstract class Delivery
    {
        /// <summary>
        /// Получает уникальный номер доставки.
        /// </summary>
        public Guid DeliveryNumber { get; }

        /// <summary>
        /// Получает или устанавливает адрес доставки.
        /// </summary>
        public string Address { get; set; } // Адрес доставки

        /// <summary>
        /// Получает или устанавливает получателя доставки.
        /// </summary>
        public string Recipient { get; set; } // Получатель

        /// <summary>
        /// Получает или устанавливает дату доставки.
        /// </summary>
        public DateTime DeliveryDate { get; set; } // Дата доставки

        /// <summary>
        /// Получает значение, указывающее, доставлена ли доставка или нет.
        /// </summary>
        public bool IsDelivered { get; protected set; } // Доставлено или нет

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Delivery"/> с указанным адресом и получателем.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="recipient">Получатель доставки.</param>
        public Delivery(string address, string recipient)
        {
            DeliveryNumber = Guid.NewGuid();
            Address = address;
            Recipient = recipient;
            DeliveryDate = DateTime.Now;
            IsDelivered = false;
        }

        /// <summary>
        /// Отправляет доставку.
        /// </summary>
        public abstract void Send();

        /// <summary>
        /// Доставляет доставку.
        /// </summary>
        public virtual void Deliver()
        {
            IsDelivered = true;
            Console.WriteLine("Доставка успешно осуществлена до: " + Recipient);
        }

        /// <summary>
        /// Отменяет доставку, если она еще не была доставлена.
        /// </summary>
        public virtual void CancelDelivery()
        {
            if (!IsDelivered)
            {
                Console.WriteLine("Доставка отменена для адреса: " + Address);
            }
            else
            {
                Console.WriteLine("Невозможно отменить доставку, так как уже доставлено.");
            }
        }

        /// <summary>
        /// Изменяет детали доставки, если доставка еще не была доставлена.
        /// </summary>
        /// <param name="newAddress">Новый адрес доставки.</param>
        /// <param name="newDeliveryDate">Новая дата доставки.</param>
        public virtual void ChangeDeliveryDetails(string newAddress, DateTime newDeliveryDate)
        {
            if (!IsDelivered)
            {
                Address = newAddress;
                DeliveryDate = newDeliveryDate;
                Console.WriteLine("Изменены детали доставки. Новый адрес: " + Address + ", Новая дата доставки: " + DeliveryDate);
            }
            else
            {
                Console.WriteLine("Невозможно изменить детали доставки, так как уже доставлено.");
            }
        }
    }
}
