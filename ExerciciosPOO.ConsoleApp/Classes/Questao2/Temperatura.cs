namespace ExerciciosPOO.ConsoleApp.Classes.Questao2
{
    public class Temperatura
    {
        private double temperaturaFahrenheit;

        public Temperatura(double temperaturaFahrenheit)
        {
            this.temperaturaFahrenheit = temperaturaFahrenheit;
        }

        public double ConvFahrenheitToCelsius()
        {
            return (temperaturaFahrenheit - 32) * 5 / 9;
        }
    }
}
