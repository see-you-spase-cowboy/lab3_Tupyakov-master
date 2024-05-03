namespace Instruments_Test
{
    class Gitar : Instrument
    /// <summary>
    /// ![Image](C:\gitar.png)
    /// Класс гитары
    /// </summary>
    {
        /// <summary>
        /// Конструктор гитары
        /// </summary>
        /// <param name="name">Название</param>
        public Gitar(string name) : base(name) { }
        /// <summary>
        /// Выводит в консоль звук гитары
        /// </summary>
        public void Sound()
        {
            Console.WriteLine("TRUUUUUUN");
        }
    }
}
