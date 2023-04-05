namespace ExerciciosPOO.ConsoleApp.Classes.Questao8
{
    public class LataDeOleo
    {
        private double raio;
        private double altura;

        public LataDeOleo(double raio, double altura)
        {
            this.raio = raio;
            this.altura = altura;
        }

        public double calcularVolume()
        {
            return Math.PI * Math.Pow(raio, 2) * altura;
        }
    }
}
