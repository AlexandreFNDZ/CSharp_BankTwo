using BankTwo_v2.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo_v2
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao; // Declara a variável do total de bonificações

        public void Registrar(Funcionario funcionario) // Acumular as bonificações que são registradas
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao() // Retornar o total de bonificações
        {
            return _totalBonificacao;
        }
    }
}
