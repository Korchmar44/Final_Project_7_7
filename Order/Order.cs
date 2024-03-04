using Final_Project_7_7.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_7_7.Order
{
    /// <summary>
    /// Представляет заказ с выбранной доставкой и дополнительной информацией.
    /// </summary>
    /// <typeparam name="TDelivery">Тип доставки.</typeparam>
    /// <typeparam name="TStruct">Тип дополнительной информации.</typeparam>
    public class Order<TDelivery, TStruct> where TDelivery : Delivery where TStruct : AdditionalOrderInfo
    {
        /// <summary>
        /// Получает список товаров в заказе.
        /// </summary>
        public List<string> Items { get; }

        /// <summary>
        /// Получает выбранную доставку для заказа.
        /// </summary>
        public TDelivery SelectedDelivery { get; }

        /// <summary>
        /// Получает дополнительную информацию для заказа.
        /// </summary>
        public TStruct AdditionalInfo { get; }

        /// <summary>
        /// Получает дату заказа.
        /// </summary>
        public DateTime OrderDate { get; }

        /// <summary>
        /// Получает список подзаказов для заказа.
        /// </summary>
        public List<Order<TDelivery, TStruct>> Orders { get; } = new List<Order<TDelivery, TStruct>>();

        /// <summary>
        /// Инициализирует новый экземпляр класса Order с выбранной доставкой и дополнительной информацией.
        /// </summary>
        /// <param name="selectedDelivery">Выбранная доставка для заказа.</param>
        /// <param name="additionalInfo">Дополнительная информация для заказа.</param>
        public Order(TDelivery selectedDelivery, TStruct additionalInfo)
        {
            SelectedDelivery = selectedDelivery;
            AdditionalInfo = additionalInfo;
            OrderDate = DateTime.Now;
            Items = new List<string>() { "Игрушка 1", "Игрушка 2", "Игрушка 3" };
        }

        /// <summary>
        /// Отображает детали заказа.
        /// </summary>
        public void DisplayOrderDetails()
        {
            Console.WriteLine($"Заказ {SelectedDelivery.DeliveryNumber} содержит следующие товары:");
            foreach (var item in Items)
            {
                Console.WriteLine($"- {item}");
            }
            Console.WriteLine($"{AdditionalInfo.Note}");
            Console.WriteLine($"Выбранный тип доставки: {SelectedDelivery.GetType().Name}");
            Console.WriteLine($"Дата заказа: {OrderDate}");
        }

        /// <summary>
        /// Добавляет новый подзаказ к заказу.
        /// </summary>
        /// <param name="newOrder">Новый подзаказ для добавления.</param>
        public void AddOrder(Order<TDelivery, TStruct> newOrder)
        {
            Orders.Add(newOrder);
        }
    }
}
