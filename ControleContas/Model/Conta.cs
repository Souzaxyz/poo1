using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Model
{
    public class Conta
    {

        private string _numero;
        private decimal _saldo;
        private static decimal _saldoTotal;
        private static string _contaMaiorSaldo;
        private static decimal _maiorSaldo;
        //Polimorfismo de sobrecarga
        public Conta(string numero, Cliente titular)
        {
            _numero = numero;
            Titular = titular;
        }

        public Conta(string numero, decimal saldo, Cliente titular)
        {
            Titular = titular;
            _saldo = saldo;
            _numero = numero;
            _saldoTotal += saldo;
            if (_saldo > _maiorSaldo)
            {
                _maiorSaldo = _saldo;
                _contaMaiorSaldo = _numero;
            }
        }

        public string Numero
        {
            get => _numero;
            private set => _numero = value;
        }
        public decimal Saldo
        {
            get => _saldo;
            private set => _saldo = value;
        }

        public decimal SaldoTotal
        {
            get => _saldoTotal;
            private set => _saldoTotal = value;
        }




    public string _ContaMaiorSaldo
    {
        get => _contaMaiorSaldo;
    }
        public Cliente Titular { get; set; }
}




    }


