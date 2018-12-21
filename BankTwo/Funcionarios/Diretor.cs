using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao() // Calcular a bonificação de um diretor (é um método 'override' pois sobrescreve o método da classe-mãe) 
        {
            return Salario + base.GetBonificacao(); // Chamar o método da classe base (Funcionario)
        }

        public override void AumentarSalario() // Aumentar salário do diretor
        {
            Salario *= 1.15;
        }
    }
}
