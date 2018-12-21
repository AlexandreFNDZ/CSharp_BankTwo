using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo_v2.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel // 'GerenteDeConta' herda propriedades e métodos de 'FuncionarioAutenticavel'
    {
        public GerenteDeConta(string cpf) // Construtor 'GerenteDeConta' recebe cpf e implementa salário e cpf na classe 'Funcionario'
            : base(4000.0, cpf)
        {

        }

        public override double GetBonificacao() // Calcular a bonificação de um diretor (é um método 'override' pois sobrescreve o método da classe-mãe) 
        {
            return Salario * 0.25; 
        }

        public override void AumentarSalario() // Aumentar salário do diretor
        {
            Salario *= 1.05;
        }
    }
}
