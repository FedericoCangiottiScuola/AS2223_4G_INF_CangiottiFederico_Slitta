using SlittaDLL;

namespace AS2223_4G_INF_CangiottiFederico_Slitta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Slitta slitta = new Slitta(100.60, 140.67);
            Regalo computer = new Regalo(23.4, 12.5, "nero", "computer");
            Regalo libro = new Regalo(40.6, 25.8, "giallo", "libro");
            Regalo zaino = new Regalo(34.5, 70.6, "rosso", "zaino");

            slitta.AggiungiRegalo(computer);
            slitta.AggiungiRegalo(libro);
            slitta.AggiungiRegalo(zaino);
        }
    }
}
