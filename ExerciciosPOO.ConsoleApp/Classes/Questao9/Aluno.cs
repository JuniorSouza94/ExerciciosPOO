﻿namespace ExerciciosPOO.ConsoleApp.Classes.Questao9
{
    public class Aluno
    {
        private double nota1;
        private double nota2;
        private double nota3;

        public Aluno(double nota1, double nota2, double nota3)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public double CalcularMediaHarmonica()
        {
            return 3 / (1 / nota1 + 1 / nota2 + 1 / nota3);
        }
    }
}
