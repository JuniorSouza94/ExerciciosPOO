namespace ExerciciosPOO.ConsoleApp.Classes.Questao7
{
    public class Vendedor
    {
        private double salarioBase;
        private double totalVendas;

        public Vendedor(double salarioBase, double totalVendas)
        {
            this.salarioBase = salarioBase;
            this.totalVendas = totalVendas;
        }

        public double calcularSalarioTotal(double percentualComissao)
        {
            double comissao = totalVendas * percentualComissao / 100;
            return salarioBase + comissao;
        }
    }
}
