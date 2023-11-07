namespace SolidOrnekler13
{
    class Client
    {
        private IGiris giris;
        private ICikis cikis;

        public Client(IGiris g, ICikis c)
        {
            this.giris = g;
            this.cikis = c;
        }

        public void Yak()
        {
            giris.Poll();
            cikis.TurnOn();
        }
        public void Sondur()
        {
            giris.Poll();
            cikis.TurnOff();
        }
    }
}
