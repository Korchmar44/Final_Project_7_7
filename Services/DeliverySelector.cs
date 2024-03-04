using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_7_7.Services
{
    /// <summary>
    /// Класс для выбора и создания различных типов доставок
    /// </summary>
    public class DeliverySelector
    {
        /// <summary>
        /// Выбирает тип доставки и собирает необходимую информацию от пользователя для создания объекта доставки
        /// </summary>
        /// <returns>Выбранный объект доставки</returns>
        public Delivery SelectDelivery()
        {
            Delivery delivery;
            int delivery_type;
            string address;
            string recipient;
            string phoneNumber;
            string pickPointId;
            string shopName;

            Console.WriteLine("Выберите тип доставки:\n1-доставка на дом\n2-доставка в пункт выдачи\n3-доставка в магазин");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1)
            {
                delivery_type = 1;
            }
            else if (userInput == 2)
            {
                delivery_type = 2;
            }
            else if (userInput == 3)
            {
                delivery_type = 3;
            }
            else
            {
                delivery_type = 0;
            }

            switch (delivery_type)
                {
                case 1:
                    Console.WriteLine("Выбрана доставка на дом");

                    Console.WriteLine();
                    
                    Console.WriteLine("Введите адрес доставки");
                    address = Console.ReadLine();
                    Console.WriteLine("Введите имя получателя");
                    recipient = Console.ReadLine();
                    Console.WriteLine("Введите телефон получателя");
                    phoneNumber = Console.ReadLine();
                    delivery = new HomeDelivery(address, recipient, phoneNumber);
                    break;

                case 2:
                    Console.WriteLine("Выбрана доставка в пункт выдачи");

                    Console.WriteLine();

                    Console.WriteLine("Введите адрес доставки");
                    address = Console.ReadLine();
                    Console.WriteLine("Введите имя получателя");
                    recipient = Console.ReadLine();
                    Console.WriteLine("Введите идентификатор пункта выдачи");
                    pickPointId = Console.ReadLine();
                    delivery = new PickPointDelivery(address, recipient, pickPointId);
                    break;

                case 3:
                    Console.WriteLine("Выбрана доставка в магазин");

                    Console.WriteLine();

                    Console.WriteLine("Введите адрес доставки");
                    address = Console.ReadLine();
                    Console.WriteLine("Введите имя получателя");
                    recipient = Console.ReadLine();
                    Console.WriteLine("Введите наименование магазина");
                    shopName = Console.ReadLine();
                    delivery = new ShopDelivery(address, recipient, shopName);
                    break;

                default:
                    Console.WriteLine("Неизвестный тип доставки");
                    delivery = null;
                    break;
                }
            return delivery;
        }
    }
}
