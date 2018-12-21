using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo_v2.Funcionarios
{
    public abstract class Funcionario 
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; } // Proteger o campo Set do 'Salario' para que não seja acessado por chamadas fora da hierarquia (Classe-mãe e Classes-filha)

        public Funcionario(double salario, string cpf) // Construtor 'Funcionario' recebe salario e cpf e atribui às propriedades e acumulador
        {
            Salario = salario;
            CPF = cpf;

            TotalDeFuncionarios++;
        }

        public abstract double GetBonificacao(); // Método abstrato para a que as Classes-filha possam sobrescrever
        public abstract void AumentarSalario(); // Método abstrato para que as Classe-filha possam sobrescrever
    }
}
