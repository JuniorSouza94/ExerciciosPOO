using ExerciciosPOO.ConsoleApp.Classes.Questao1;
using ExerciciosPOO.ConsoleApp.Classes.Questao10;
using ExerciciosPOO.ConsoleApp.Classes.Questao2;
using ExerciciosPOO.ConsoleApp.Classes.Questao3;
using ExerciciosPOO.ConsoleApp.Classes.Questao4;
using ExerciciosPOO.ConsoleApp.Classes.Questao5;
using ExerciciosPOO.ConsoleApp.Classes.Questao6;
using ExerciciosPOO.ConsoleApp.Classes.Questao7;
using ExerciciosPOO.ConsoleApp.Classes.Questao8;
using ExerciciosPOO.ConsoleApp.Classes.Questao9;

namespace ExerciciosPOO.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-------------------------[QUESTÃO 1]-------------------------\n");

            //Questão 1
            Caixa caixa = new Caixa(10, 5, 3);
            Console.WriteLine($"Volume da caixa: {caixa.CalcularVolume()}");

            Console.WriteLine("\n-------------------------[QUESTÃO 2]-------------------------\n");

            //Questão 2
            Temperatura temperatura = new Temperatura(77);
            Console.WriteLine($"Temperatura em Celsius: {temperatura.ConvFahrenheitToCelsius()}");

            Console.WriteLine("\n-------------------------[QUESTÃO 3]-------------------------\n");

            //Questão 3
            Cilindro cilindro = new Cilindro(5, 10);
            Console.WriteLine($"Volume do cilindro: {cilindro.CalcularVolume()}");

            Console.WriteLine("\n-------------------------[QUESTÃO 4]-------------------------\n");

            //Questão 4
            Combustivel combustivel = new Combustivel(100, 200, 10);
            Console.WriteLine($"Consumo de combustível: {combustivel.CalcularConsumo()}");

            Console.WriteLine("\n-------------------------[QUESTÃO 5]-------------------------\n");

            //Questão 5
            ConversorTemperatura conversor = new ConversorTemperatura(25);
            Console.WriteLine($"Temperatura em Fahrenheit: {conversor.ConverterParaFahrenheit()}");

            Console.WriteLine("\n-------------------------[QUESTÃO 6]-------------------------\n");

            //Questão 6
            Esfera esfera = new Esfera(5);
            Console.WriteLine($"Volume da esfera: {esfera.CalcularVolume()}");

            Console.WriteLine("\n-------------------------[QUESTÃO 7]-------------------------\n");

            //Questão 7
            double salarioBase = 1500.0;
            double totalVendas = 10000.0;
            double percentualComissao = 5.0;

            Vendedor vendedor = new Vendedor(salarioBase, totalVendas);
            double salarioTotal = vendedor.calcularSalarioTotal(percentualComissao);

            Console.WriteLine("O salário total do vendedor é: " + salarioTotal);

            Console.WriteLine("\n-------------------------[QUESTÃO 8]-------------------------\n");

            //Questão 8
            double raio = 2.0;
            double altura = 5.0;

            LataDeOleo lataDeOleo = new LataDeOleo(raio, altura);
            double volume = lataDeOleo.calcularVolume();

            Console.WriteLine("O volume da lata de óleo é: " + volume);

            Console.WriteLine("\n-------------------------[QUESTÃO 9]-------------------------\n");

            //Questão 9
            double nota1 = 7.8;
            double nota2 = 9.2;
            double nota3 = 6.5;

            Aluno aluno = new Aluno(nota1, nota2, nota3);
            double media = aluno.CalcularMediaHarmonica();

            Console.WriteLine("A média harmônica das notas é: " + media);

            Console.WriteLine("\n-------------------------[QUESTÃO 10]-------------------------\n");

            //Questão 10
            double notas1 = 8.5;
            double notas2 = 7.2;

            Alunos alunos = new Alunos(notas1, notas2);
            double medias = alunos.CalcularMedia();

            Console.WriteLine("A média ponderada das notas é: " + medias);

            Console.ReadKey();

        }
    }
}
