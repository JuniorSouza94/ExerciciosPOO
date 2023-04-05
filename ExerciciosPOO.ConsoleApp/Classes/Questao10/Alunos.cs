namespace ExerciciosPOO.ConsoleApp.Classes.Questao10
{
    class Alunos
    {
        private double nota1;
        private double nota2;

        public Alunos(double nota1, double nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public double CalcularMedia()
        {
            return nota1 * 0.4 + nota2 * 0.6;
        }
    }
}
