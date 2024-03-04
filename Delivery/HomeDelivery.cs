using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_7_7
{
    /// <summary>
    /// Представляет доставку на дом с указанием номера телефона получателя
    /// </summary>
    public class HomeDelivery : Delivery
    {
        /// <summary>
        /// Получает или устанавливает номер телефона получателя
        /// </summary>
        public string PhoneNumber { get; set; } // Номер телефона получателя

        /// <summary>
        /// Инициализирует новый экземпляр класса HomeDelivery с указанным адресом, получателем и номером телефона
        /// </summary>
        /// <param name="address">Адрес доставки</param>
        /// <param name="recipient">Имя получателя</param>
        /// <param name="phoneNumber">Номер телефона получателя</param>
        public HomeDelivery(string address, string recipient, string phoneNumber) : base(address, recipient)
        {
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Отправляет посылку по адресу получателя
        /// </summary>
        public override void Send()
        {
            Console.WriteLine("Отправка на дом по адресу: " + Address);
        }

        /// <summary>
        /// Доставляет посылку и выводит адрес доставки
        /// </summary>
        public override void Deliver()
        {
            base.Deliver(); // Вызываем базовую реализацию метода Deliver
            Console.WriteLine("Посылка доставлена по адресу: " + Address);
        }
    }
}
