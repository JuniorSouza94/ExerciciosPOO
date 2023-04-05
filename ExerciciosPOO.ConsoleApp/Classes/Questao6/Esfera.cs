namespace ExerciciosPOO.ConsoleApp.Classes.Questao6
{
    public class Esfera
    {
        private double raio;

        public Esfera(double r)
        {
            raio = r;
        }

        public double CalcularVolume()
        {
            return 4 * Math.PI * Math.Pow(raio, 3) / 3;
        }

        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }
    }
}
