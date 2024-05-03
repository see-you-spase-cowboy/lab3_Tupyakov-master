namespace Instruments_Test
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            RabSil man = new("Ivan", "Egorov", DateTime.Parse("15.06.2002"), new()
            {
            }, 0);

            man.Display();
        }
    }
}