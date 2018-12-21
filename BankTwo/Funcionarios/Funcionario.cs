using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; } 

        public virtual double GetBonificacao() // Calcular a bonificação de um funcionário (é um método 'virtual' pois pode ser sobrescrito pelas classes-filha)
        {
            return Salario * 0.1;
        }

        public virtual void AumentarSalario() // Aumentar salário do funcionario
        {
            Salario *= 1.1;
        }
    }
}
