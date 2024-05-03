namespace Instruments_Test
{
    class Instrument
    {
        /// <summary>
        /// Название
        /// </summary>
        private string _name;
        /// <summary>
        /// Свойство для получения названия инструмента
        /// </summary>
        public string Name { get { return _name; } }
        /// <summary>
        /// Конструктор инструмента
        /// </summary>
        /// <param name="name">Название</param>
        public Instrument(string name)
        {
            _name = name;
        }
    }
}
