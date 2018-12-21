using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo_v2.Funcionarios
{
    public class Auxiliar : Funcionario // 'Auxiliar' herda propriedades e métodos de 'Funcionario'
    {
        public Auxiliar(string cpf) // Construtor 'Auxiliar' recebe cpf e implementa salário e cpf na classe 'Funcionario'
            : base(2000.0, cpf)
        {

        }

        public override double GetBonificacao() // Calcular a bonificação de um diretor (é um método 'override' pois sobrescreve o método da classe-mãe) 
        {
            return Salario * 0.20; 
        }

        public override void AumentarSalario() // Aumentar salário do diretor
        {
            Salario *= 1.10;
        }
    }
}
