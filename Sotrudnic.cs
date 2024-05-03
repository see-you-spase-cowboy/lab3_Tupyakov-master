using System.Diagnostics.Metrics;

namespace Instruments_Test {
    /// <summary>
    /// Класс человека
    /// </summary>
    class Sotrudnic
    {
        /// <summary>
        /// Имя
        /// </summary>
        protected string _name;
        /// <summary>
        /// Фамилия
        /// </summary>
        protected string _surname;
        /// <summary>
        /// Дата рождения
        /// </summary>
        protected DateTime _birthdate;
        /// <summary>
        /// Интструменты
        /// </summary>
        protected List<System.Diagnostics.Metrics.Instrument> _instruments;
        /// <summary>
        /// Конструктор человека
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="birthdate">Дата рождения</param>
        /// <param name="instruments">Список интструментов</param>
        public Sotrudnic(string name, string surname, DateTime birthdate, List<System.Diagnostics.Metrics.Instrument> instruments)
        {
            _name = name;
            _surname = surname;
            _birthdate = birthdate;
            _instruments = instruments;
        }
        /// <summary>
        /// Отображает в консоли информацию о человеке
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"Name:{_name} {_surname}  Age:{GetAge()}");
            Console.WriteLine("Instruments:");
            foreach (System.Diagnostics.Metrics.Instrument instrument in _instruments)
            {
                Console.WriteLine($"{instrument.Name}");
            }
        }
        /// <summary>
        /// Рассчитывает возраст человека
        /// </summary>
        /// \f$возраст = датаРождения - текущаяДата   \f$
        /// <returns>Возвращает возраст</returns>
        public int GetAge()
        {
            return DateTime.Now.Subtract(_birthdate).Days / 365;
        }
    }
}