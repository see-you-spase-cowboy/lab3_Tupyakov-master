using System.Diagnostics.Metrics;
namespace Instruments_Test
{
        /// <summary>
        /// Класс работника
        /// </summary>
        class RabSil : Sotrudnic
        {
            /// <summary>
            /// Зарплата
            /// </summary>
            private int _salary;
            /// <summary>
            /// Конструктор работника
            /// </summary>
            /// <param name="name">Имя</param>
            /// <param name="surname">Фамилия</param>
            /// <param name="birthdate">Дата рождения</param>
            /// <param name="instruments">Список инструментов</param>
            /// <param name="salary">Зарплата</param>
            public RabSil(string name, string surname, DateTime birthdate, List<System.Diagnostics.Metrics.Instrument> instruments, int salary) : base(name, surname, birthdate, instruments)
            {
                _instruments = instruments;
                _salary = salary;
            }
            /// <summary>
            /// Отображает в консоли информацию о работнике
            /// </summary>
            public new void Display()
            {
                base.Display();
                Console.WriteLine($"Instrument:{_instruments} Salary:{_salary}");
            }
        }
    }