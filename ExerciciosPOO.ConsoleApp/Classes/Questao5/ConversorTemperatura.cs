namespace ExerciciosPOO.ConsoleApp.Classes.Questao5
{
    public class ConversorTemperatura
    {
        private double temperaturaCelsius;

        public ConversorTemperatura(double tempCelsius)
        {
            temperaturaCelsius = tempCelsius;
        }

        public double ConverterParaFahrenheit()
        {
            return temperaturaCelsius * 9 / 5 + 32;
        }

        public double Celsius
        {
            get { return temperaturaCelsius; }
            set { temperaturaCelsius = value; }
        }
    }
}
