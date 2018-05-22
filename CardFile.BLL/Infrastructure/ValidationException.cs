using System;

namespace CardFile.BLL.Infrastructure
{
    /// <inheritdoc />
    /// <summary>
    /// Класс ValidationException осуществляет валидацию с передачей ошибок в уровень представления.
    /// </summary>
    public class ValidationException : Exception
    {
        /// <summary>
        /// Свойство Property позволяет сохранить название свойства модели, которое некорректно и не проходит валидацию.
        /// </summary>
        public string Property { get; protected set; }

        /// <inheritdoc />
        /// <summary>
        /// Конструктор базового класса.
        /// </summary>
        /// <param name="message">Сообщение, которое будет выводиться для некорректного свойства в Property.</param>
        /// <param name="prop">Свойство модели, которое некорректно и не проходит валидацию.</param>
        public ValidationException(string message, string prop) : base(message)
        {
            Property = prop;
        }
    }
}