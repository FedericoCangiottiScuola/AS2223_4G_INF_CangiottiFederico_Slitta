namespace SlittaDLL
{
    public class Regalo
    {
        public double Peso { get; }
        public double Volume { get; }
        public string Colore { get; }
        public string Descrizione { get; }

        public Regalo(double peso, double volume, string colore, string descrizione)
        {
            Peso = peso;
            Volume = volume;
            Colore = colore;
            Descrizione = descrizione;
        }
    }
}
