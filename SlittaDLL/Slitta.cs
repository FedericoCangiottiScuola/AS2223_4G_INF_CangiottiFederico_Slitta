namespace SlittaDLL
{
    public class Slitta
    {
        double maxPeso;
        double maxVolume;
        List<Regalo> regali;

        public Slitta(double maxPeso, double maxVolume)
        {
            this.maxPeso = maxPeso;
            this.maxVolume = maxVolume;
            regali = new List<Regalo> { };
        }

        public bool AggiungiRegalo(Regalo inputRegalo)
        {
            double peso = 0;
            double volume = 0;

            foreach (Regalo regalo in regali)
            {
                peso += regalo.Peso;
                volume += regalo.Volume;
            }
            peso += inputRegalo.Peso;
            volume += inputRegalo.Volume;

            if (peso > maxPeso || volume > maxVolume)
            {
                return false;
            }

            regali.Add(inputRegalo);
            return true;
        }
    }
}
