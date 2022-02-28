using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class InjDep
    {
    }

    public interface IBancos
    {
        public void RecebendoDouble(double parametro);

        public double RetornandoDouble();
    }

    public class Santander : IBancos
    {
        private double SaldoInicial = 1251146.24;
        public double SaldoAtual { get; set; }

        public Santander()
        {
            SaldoAtual = SaldoInicial;
        }

        public void RecebendoDouble(double parametro)
        {
            SaldoAtual += parametro;
            Console.WriteLine("Novo saldo no banco Santander apos transferencia é R$" + SaldoAtual);
        }

        public double RetornandoDouble()
        {
            var retirada = 1000.00;
            Console.WriteLine("Iniciando o processo de tranferencia");
            Console.WriteLine("Será retirado do Banco Santander o valor de R${0} do saldo atual de R${1} para ser transferido", retirada, SaldoAtual);
            SaldoAtual -= retirada;
            return retirada;
        }
    }

    public class Itau : IBancos
    {
        private double SaldoInicial = 125444.24;
        public double SaldoAtual { get; set; }

        public Itau()
        {
            SaldoAtual = SaldoInicial;
        }

        public void RecebendoDouble(double parametro)
        {
            SaldoAtual += parametro;
            Console.WriteLine("Novo saldo no banco Itau apos transferencia é R$" + SaldoAtual);
        }

        public double RetornandoDouble()
        {
            var retirada = 2000.00;
            Console.WriteLine("Iniciando o processo de tranferencia");
            Console.WriteLine("Será retirado do Banco Itau o valor de R${0} do saldo atual de R${1} para ser transferido", retirada, SaldoAtual);
            SaldoAtual -= retirada;
            return retirada;
        }
    }

    public class Caixa : IBancos
    {
        private double SaldoInicial = 1254226.24;
        public double SaldoAtual { get; set; }

        public Caixa()
        {
            SaldoAtual = SaldoInicial;
        }

        public void RecebendoDouble(double parametro)
        {
            SaldoAtual += parametro;
            Console.WriteLine("Novo saldo no banco Caixa é apos transferencia R$" + SaldoAtual);
        }

        public double RetornandoDouble()
        {
            var retirada = 3000.00;
            Console.WriteLine("Iniciando o processo de tranferencia");
            Console.WriteLine("Será retirado do Banco Caixa o valor de R${0} do saldo atual de R${1} para ser transferido", retirada, SaldoAtual);
            SaldoAtual -= retirada;
            return retirada;
        }
    }

    public class TranferenciaBancaria
    {
        private IBancos BancoRetira;
        private IBancos BancoRecebe;

        public TranferenciaBancaria()
        {

        }

        public TranferenciaBancaria(IBancos bancoRetira, IBancos bancoRecebe)
        {
            this.BancoRetira = bancoRetira;
            this.BancoRecebe = bancoRecebe;
        }
        
        public void IniciarTranferencia()
        {
            double valor = BancoRetira.RetornandoDouble();
            BancoRecebe.RecebendoDouble(valor);
        }

    }
}
