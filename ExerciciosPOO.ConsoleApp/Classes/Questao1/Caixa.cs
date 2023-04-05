namespace ExerciciosPOO.ConsoleApp.Classes.Questao1
{
    public class Caixa
    {
        private double _largura;
        private double _altura;
        private double _profundidade;

        public Caixa(double largura, double altura, double profundidade)
        {
            this._largura = largura;
            this._altura = altura;
            this._profundidade = profundidade;
        }

        public double CalcularVolume()
        {
            return _largura * _altura * _profundidade;
        }
    }
}
