using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo_v2.Funcionarios
{
    public interface IAutenticavel // Interface 'Autenticavel' que dita regra para as classes-filha implementar o método 'Autenticar'
    {
        bool Autenticar(string senha); 
    }
}
