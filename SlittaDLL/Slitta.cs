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

        /// <summary>
        /// Aggiunge un oggetto di tipo Regalo nella lista
        /// </summary>
        /// <param name="inputRegalo"></param>
        /// <returns>Operazione a buon fine [true], operazione non riuscita [false]</returns>
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

        /// <summary>
        /// Recupera le informazioni riguardo i regali inseriti
        /// </summary>
        /// <returns>Stringa con informazioni formattate</returns>
        public string VisualizzaRegali()
        {
            string ris = "";

            int i = 1;
            foreach(Regalo regalo in regali)
            {
                ris += $"{i}) Descrizione: {regalo.Descrizione}\nColore: {regalo.Colore}\nPeso: {regalo.Peso}\nVolume: {regalo.Volume}\n\n";
                i++;
            }

            return ris;
        }
    }
}
