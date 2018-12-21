using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo_v2.Funcionarios
{
    public class Designer : Funcionario // 'Designer' herda propriedades e métodos de 'Funcionario'
    {
        public Designer(string cpf) // Construtor 'Designer' recebe cpf e implementa salário e cpf na classe 'Funcionario'
            : base(3000.0, cpf)
        {

        }

        public override double GetBonificacao() // Calcular a bonificação de um diretor (é um método 'override' pois sobrescreve o método da classe-mãe) 
        {
            return Salario * 0.17; 
        }

        public override void AumentarSalario() // Aumentar salário do diretor
        {
            Salario *= 1.11;
        }
    }
}
