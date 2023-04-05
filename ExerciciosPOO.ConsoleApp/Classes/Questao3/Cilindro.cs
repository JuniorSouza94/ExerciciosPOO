namespace ExerciciosPOO.ConsoleApp.Classes.Questao3
{
    public class Cilindro
    {
        private double raio;
        private double altura;

        public Cilindro(double raio, double altura)
        {
            this.raio = raio;
            this.altura = altura;
        }

        public double CalcularVolume()
        {
            return Math.PI * Math.Pow(raio, 2) * altura;
        }
    }
}
