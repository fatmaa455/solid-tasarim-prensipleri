namespace SolidOrnekler13
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new Anahtar(), new Lamp());
            client.Yak();
            client.Sondur();
        }
    }
}
