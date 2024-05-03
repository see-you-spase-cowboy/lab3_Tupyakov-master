using System.Diagnostics.Metrics;
namespace Instruments_Test
{
        /// <summary>
        /// ����� ���������
        /// </summary>
        class RabSil : Sotrudnic
        {
            /// <summary>
            /// ��������
            /// </summary>
            private int _salary;
            /// <summary>
            /// ����������� ���������
            /// </summary>
            /// <param name="name">���</param>
            /// <param name="surname">�������</param>
            /// <param name="birthdate">���� ��������</param>
            /// <param name="instruments">������ ������������</param>
            /// <param name="salary">��������</param>
            public RabSil(string name, string surname, DateTime birthdate, List<System.Diagnostics.Metrics.Instrument> instruments, int salary) : base(name, surname, birthdate, instruments)
            {
                _instruments = instruments;
                _salary = salary;
            }
            /// <summary>
            /// ���������� � ������� ���������� � ���������
            /// </summary>
            public new void Display()
            {
                base.Display();
                Console.WriteLine($"Instrument:{_instruments} Salary:{_salary}");
            }
        }
    }