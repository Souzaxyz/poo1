using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Model
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public int AnoNascimento { get; private set; }

        public Cliente (string nome, string cpf, int anoNascimento)
        {

            if (anoNascimento > 2005)
                throw new Exception("Precisa ter mais de 18 anos!");
            if (cpf.Length != 11)
                throw new Exception("Cpf inválido, o Cpf deve possuir somente números(11 números)");
            
            Nome = nome;
            Cpf = cpf;
            AnoNascimento = anoNascimento;
            

        }
    }
}
