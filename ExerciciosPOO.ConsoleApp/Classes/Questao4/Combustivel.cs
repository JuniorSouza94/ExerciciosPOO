namespace ExerciciosPOO.ConsoleApp.Classes.Questao4
{
    public class Combustivel
    {
        private double kmInicial;
        private double kmFinal;
        private double consumo;

        public Combustivel(double kmInicial, double kmFinal, double consumo)
        {
            this.kmInicial = kmInicial;
            this.kmFinal = kmFinal;
            this.consumo = consumo;
        }

        public double CalcularConsumo()
        {
            return (kmFinal - kmInicial) / consumo;
        }
    }
}
