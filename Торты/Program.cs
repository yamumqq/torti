namespace Торты
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int pozicia = 3;
            string tort = "";
            do
            {

                Menu.Menush(pozicia, tort, sum);
            } while (true);
        }

    }
}