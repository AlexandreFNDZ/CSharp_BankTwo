using BankTwo_v2.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo_v2
{
    public class ParceiroComercial : IAutenticavel // Segue implementação da Interface 'IAutenticavel'
    {
        public string Senha { get; set; } // Criar propriedade 'Senha' para Parceiros que atendam o requisito de ser Autenticavel

        public bool Autenticar(string senha) // Verificar se senha informada é igual a cadastrada
        {
            return Senha == this.Senha;            
        }
    }
}
