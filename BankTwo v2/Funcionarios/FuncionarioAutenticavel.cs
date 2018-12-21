using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo_v2.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel // Classe abstrata que herda propriedades e métodos de 'Funcionario' e da Interface 'IAutenticavel'
    {
        public FuncionarioAutenticavel(double salario, string cpf) // Construtor que recebe salario e cpf e implementa na classe base 'Funcionario'
            : base(salario, cpf)
        {

        }

        public string Senha { get; set; } // Criar propriedade 'Senha' para Funcionários que atendam o requisito de ser Autenticavel

        public bool Autenticar(string senha) // Verificar se senha informada é igual a cadastrada
        {
            return Senha == this.Senha;
        }
    }
}
