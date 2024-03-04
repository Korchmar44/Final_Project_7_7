using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_7_7
{
    /// <summary>
    /// Представляет доставку через пункт выдачи.
    /// </summary>
    class PickPointDelivery : Delivery
    {
        /// <summary>
        /// Получает или устанавливает идентификатор пункта выдачи.
        /// </summary>
        public string PickPointId { get; set; } // Идентификатор пункта выдачи

        /// <summary>
        /// Инициализирует новый экземпляр класса PickPointDelivery с указанным адресом, получателем и идентификатором пункта выдачи.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="recipient">Получатель доставки.</param>
        /// <param name="pickPointId">Идентификатор пункта выдачи.</param>
        public PickPointDelivery(string address, string recipient, string pickPointId) : base(address, recipient)
        {
            PickPointId = pickPointId;
        }

        /// <summary>
        /// Отправляет доставку через пункт выдачи.
        /// </summary>
        public override void Send()
        {
            Console.WriteLine("Отправка через пункт самовывоза: " + PickPointId);
        }

        /// <summary>
        /// Доставляет посылку в пункт выдачи.
        /// </summary>
        public override void Deliver()
        {
            base.Deliver(); // Вызываем базовую реализацию метода Deliver
            Console.WriteLine("Посылка доставлена в пункт выдачи: " + PickPointId);
        }
    }
}
