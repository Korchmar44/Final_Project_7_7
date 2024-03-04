using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_7_7.Services
{
    /// <summary>
    /// Представляет дополнительную информацию для заказа.
    /// </summary>
    public class AdditionalOrderInfo
    {
        /// <summary>
        /// Получает или задает заметку для заказа.
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Получает или задает любые особые отметки для заказа.
        /// </summary>
        public string SpecialMarks { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса AdditionalOrderInfo с указанной заметкой и особыми отметками.
        /// </summary>
        /// <param name="note">Заметка для заказа.</param>
        /// <param name="specialMarks">Любые особые отметки для заказа.</param>
        public AdditionalOrderInfo(string note, string specialMarks)
        {
            Note = note;
            SpecialMarks = specialMarks;
        }

        /// <summary>
        /// Возвращает строку, представляющую текущий объект, включая заметку и особые отметки.
        /// </summary>
        /// <returns>Строка, представляющая текущий объект.</returns>
        public override string ToString()
        {
            return $"Информация: {Note}, Особые отметки: {SpecialMarks}";
        }
    }
}
