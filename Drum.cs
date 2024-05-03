namespace Instruments_Test
{
    class Drum : Instrument
    /// <summary>
    /// ![Image](C:\drum.png)
    /// Класс барабана
    /// </summary>
    {
        /// <summary>
        /// Конструктор барабана
        /// </summary>
        /// <param name="name">Название</param>
        public Drum(string name) : base(name) { }
        /// <summary>
        /// Выводит в консоль звук барабана
        /// </summary>
        public void Sound()
        {
            Console.WriteLine("BOOOOOM");
        }
    }
}
