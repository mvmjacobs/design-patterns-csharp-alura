using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioDeContas
{
    public class Conta
    {
        public string Titular { get; private set; }
        public string Agencia { get; private set; }
        public string Numero { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string titular, string agencia, string numero)
        {
            this.Titular = titular;
            this.Agencia = agencia;
            this.Numero = numero;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }
    }
}
